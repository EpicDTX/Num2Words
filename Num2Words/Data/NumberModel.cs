using System.ComponentModel.DataAnnotations;

namespace Num2Words.Data
{
    public class NumberModel
    {
        [Required(ErrorMessage = "Please Enter a Number.")]
        [Range(0, float.MaxValue, ErrorMessage = "Only Positive Numbers Allowed.")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Number Can Only Have 2 Digits After The Demical")]
        [DataType(DataType.Currency)]
        public float? Number { get; set; }
    }
}
