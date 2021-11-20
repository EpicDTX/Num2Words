using System.ComponentModel.DataAnnotations;

namespace Num2Words.Data
{
    public class NumberModel
    {
        [Required(ErrorMessage = "Please Enter a Number.")]
        [DataType(DataType.Currency)]
        public float? Number { get; set; }
    }
}
