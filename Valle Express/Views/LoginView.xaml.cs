namespace Valle_Express.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new AppShell();

        await Shell.Current.GoToAsync($"//ClienteMainView");
    }
}