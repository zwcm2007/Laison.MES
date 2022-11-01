using System.Threading.Tasks;
using MyProAntDesignApp.Models;
using MyProAntDesignApp.Services;
using Microsoft.AspNetCore.Components;

namespace MyProAntDesignApp.Pages.Profile
{
    public partial class Basic
    {
        private BasicProfileDataType _data = new BasicProfileDataType();

        [Inject] protected IProfileService ProfileService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _data = await ProfileService.GetBasicAsync();
        }
    }
}