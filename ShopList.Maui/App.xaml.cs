using Microsoft.Extensions.DependencyInjection;

namespace ShopList.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Routing.RegisterRoute(
                nameof(Views.EditShopListItemPage),
                typeof(Views.EditShopListItemPage));

        }



        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}