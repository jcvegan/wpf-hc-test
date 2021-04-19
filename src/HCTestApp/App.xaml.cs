using HCTestApp.Services;
using HCTestApp.Views;
using Prism.Ioc;
using Prism.Unity;
using System.Windows;

namespace HCTestApp
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IPersonDataService, PersonDataService>();
        }
    }
}
