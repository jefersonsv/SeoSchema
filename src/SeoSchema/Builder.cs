//using AngleSharp.Parser.Html;
using Newtonsoft.Json.Linq;
using SuperStructs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SeoSchema
{
    /// <summary>
    /// <see cref="https://schema.org/"/>
    /// </summary>
    public class Builder
    {
        IList<IEntity> entities;

        public Builder()
        {
            this.entities = new List<IEntity>();
        }

        public void Add(IEntity entity)
        {
            this.entities.Add(entity);
        }

        public string Generate()
        {
            StringBuilder inside = new StringBuilder();

            foreach (var it in entities)
            {
                var content = Generate(it);

                if (string.IsNullOrEmpty(content))
                    continue;

                inside.AppendLine(content);
            }

            if (inside.Length > 0)
                return inside.ToString();

            return null;
        }

        static T GetAttribute<T>(Enum enumValue) where T : Attribute
        {
            T attribute;

            MemberInfo memberInfo = enumValue.GetType().GetMember(enumValue.ToString())
                                            .FirstOrDefault();

            if (memberInfo != null)
            {
                attribute = (T)memberInfo.GetCustomAttributes(typeof(T), false).FirstOrDefault();
                return attribute;
            }
            return null;
        }

        static JObject GenerateRecursive(IEntity entity)
        {
            var parent = new JObject();
            parent.Add("@type", entity.GetType().Name);

            var props = entity.GetType().GetProperties().Where(w => w.GetValue(entity) != null);
            foreach (var item in props)
            {
                var valueObject = (IOr) item.GetValue(entity);
                var content = valueObject.Content;

                var entityInterface = content.GetType().GetInterface("IEntity");
                if (entityInterface != null)
                {
                    // object
                    parent.Add(item.Name, GenerateRecursive((IEntity) content));
                }
                else
                {
                    if (valueObject.Content.GetType().IsEnum)
                    {
                        // Enum property
                        var itemTypeAttribute = GetAttribute<ItemTypeAttribute>((Enum)valueObject.Content);
                        parent.Add(item.Name, JValue.FromObject(itemTypeAttribute.CanonicalUrl));
                    }
                    else
                    {
                        // Common property
                        var formatAttributeObject = item.GetCustomAttributes(typeof(FormatAttribute), false).FirstOrDefault();
                        if (formatAttributeObject != null && formatAttributeObject.GetType() == typeof(FormatAttribute) && content.GetType() == typeof(DateTime))
                        {
                            var formatAttribute = (FormatAttribute)formatAttributeObject;
                            var dateTime = (DateTime)content;
                            parent.Add(item.Name, JValue.FromObject(dateTime.ToString(formatAttribute.Format)));
                        }
                        else
                        {
                            // Without anyone special treatment
                            parent.Add(item.Name, JValue.FromObject(content));
                        }
                        
                    }
                }
            }

            return parent;
        }

        public static string Generate(IEntity entity)
        {
            CultureInfo ci = new CultureInfo("en-Us");
            //var parser = new HtmlParser();
            //var document = parser.Parse(string.Empty);

            // Generate json content
            var json = new JObject();
            json.Add("@context", "http://schema.org");

            foreach (var item in GenerateRecursive(entity))
            {
                json.Add(item.Key, item.Value);
            }

            var content = json.ToString();
            if (json.Count <= 2)
                return null;

            StringBuilder outside = new StringBuilder();
            outside.AppendLine(@"<script type=""application/ld+json"">");
            outside.AppendLine(json.ToString());
            outside.AppendLine(@"</script>");

            return outside.ToString();
        }
    }
}
