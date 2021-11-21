using System.ComponentModel.DataAnnotations;

namespace Num2Words.Data
{
    public class NumberModel
    {
        [Required(ErrorMessage = "Please Enter a Number.")]
        [Range(0, float.MaxValue, ErrorMessage = "Only Positive Numbers Allowed.")]
        [DataType(DataType.Currency)]
        public float? Number { get; set; }
    }
}
