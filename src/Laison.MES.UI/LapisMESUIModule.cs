using Prism.Ioc;
using Prism.Modularity;
using System;

namespace Laison.MES.UI
{
    [Module(ModuleName = "LapisMESUIModule", OnDemand = true)]
    public class LapisMESUIModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
