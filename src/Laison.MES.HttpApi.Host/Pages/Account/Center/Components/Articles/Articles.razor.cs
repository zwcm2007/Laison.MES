using System.Collections.Generic;
using MyProAntDesignApp.Models;
using Microsoft.AspNetCore.Components;

namespace MyProAntDesignApp.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}