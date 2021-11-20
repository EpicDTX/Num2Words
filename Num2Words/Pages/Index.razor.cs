using Num2Words.Data;

namespace Num2Words.Pages
{
    public partial class Index
    {
        public NumberModel model { get; set; } = new();
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

        }

        protected void HandleValidSubmit()
        {
            translator.Convert(1.0f);
        }
    }
}
