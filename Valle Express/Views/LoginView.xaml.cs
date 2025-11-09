using Valle_Express.ViewModels;

namespace Valle_Express.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
        BindingContext = new LoginViewModel();
	}
}