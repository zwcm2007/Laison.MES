using Laison.Lapis.Shared.Shell;
using Laison.Lapis.UI;
using Laison.MES.UI;
using Prism.Modularity;
using System.Windows;
using AppContext = Laison.Lapis.UI.AppContext;

namespace Laison.MES.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : LapisApp
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            AppContext.Register(AppType.SaasClient);
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            //
            moduleCatalog.AddModule<LapisMESUIModule>();
        }
    }
}