using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Categories that represent an assessment of the risk of fetal injury due to a drug or pharmaceutical used as directed by the mother during pregnancy.
    /// <see cref="https://schema.org/DrugPregnancyCategory"/>
    /// </summary>
    public enum DrugPregnancyCategory
    {
        [ItemType("https://schema.org/FDAcategoryA")]
        FDAcategoryA,

        [ItemType("https://schema.org/FDAcategoryB")]
        FDAcategoryB,

        [ItemType("https://schema.org/FDAcategoryC")]
        FDAcategoryC,

        [ItemType("https://schema.org/FDAcategoryD")]
        FDAcategoryD,

        [ItemType("https://schema.org/FDAcategoryX")]
        FDAcategoryX,

        [ItemType("https://schema.org/FDAnotEvaluated")]
        FDAnotEvaluated
    }
}
