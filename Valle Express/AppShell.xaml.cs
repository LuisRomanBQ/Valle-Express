using Valle_Express.Views;

namespace Valle_Express
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LoginView), typeof(LoginView));
            Routing.RegisterRoute(nameof(ClienteMainView), typeof(ClienteMainView));
            Routing.RegisterRoute(nameof(RepartidorMainView), typeof(RepartidorMainView));
            Routing.RegisterRoute(nameof(RepartidorGananciasView), typeof(RepartidorGananciasView));
            Routing.RegisterRoute(nameof(RepartidorUbicacionView), typeof(RepartidorUbicacionView));
            Routing.RegisterRoute(nameof(RepartidorHistorialView), typeof(RepartidorHistorialView));
            Routing.RegisterRoute(nameof(RegistrarUsuarioView), typeof(RegistrarUsuarioView));
            Routing.RegisterRoute(nameof(NegocioMainView), typeof(NegocioMainView));
            Routing.RegisterRoute(nameof(NegocioGanaciasView), typeof(NegocioGanaciasView));
            Routing.RegisterRoute(nameof(NegocioHistorialView), typeof(NegocioHistorialView));
            Routing.RegisterRoute(nameof(NegocioMenuView), typeof(NegocioMenuView));
            Routing.RegisterRoute(nameof(ConfiguracionView), typeof(ConfiguracionView));

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new LoginView());
        }
    }
}
