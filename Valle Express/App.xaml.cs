using Valle_Express.Views;

namespace Valle_Express
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();
        }
    }
}
