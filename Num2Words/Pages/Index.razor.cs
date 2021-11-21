using Num2Words.Data;

namespace Num2Words.Pages
{
    public partial class Index
    {
        protected string output = "";
        public NumberModel model { get; set; } = new();
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

        }

        protected void HandleValidSubmit()
        {
            if(model?.Number != null)
            {
                output = translator.Convert(model.Number.Value);
                output = output.ToUpper();
                output = "ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS";
            }
        }
    }
}
