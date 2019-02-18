using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema
{
    public class FormatAttribute : Attribute
    {
        public FormatAttribute(string format)
        {
            this.Format = format;
        }

        public string Format { get; set; }
    }
}
