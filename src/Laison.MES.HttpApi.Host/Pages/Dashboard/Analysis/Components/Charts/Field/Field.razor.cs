using Microsoft.AspNetCore.Components;

namespace MyProAntDesignApp.Pages.Dashboard.Analysis
{
    public partial class Field
    {
        [Parameter]
        public string Label { get; set; }

        [Parameter]
        public string Value { get; set; }
    }
}