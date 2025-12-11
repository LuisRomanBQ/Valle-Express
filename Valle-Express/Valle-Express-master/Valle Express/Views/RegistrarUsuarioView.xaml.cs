namespace Valle_Express.Views;

public partial class RegistrarUsuarioView : ContentPage
{
	public RegistrarUsuarioView()
	{
		InitializeComponent();
	}
    private async void OnCrearCuentaClicked(object sender, EventArgs e) {
        string nombre = txtNombre.Text;
        string correo = txtCorreo.Text;
        string telefono = txtTelefono.Text;
        string password = txtPassword.Text;

        if (string.IsNullOrWhiteSpace(nombre) ||
            string.IsNullOrWhiteSpace(correo) ||
            string.IsNullOrWhiteSpace(password)) {
            await DisplayAlert("Error", "Por favor completa todos los campos obligatorios.", "OK");
            return;
        }

        if (password.Length < 6) {
            await DisplayAlert("Advertencia", "La contraseña debe tener al menos 6 caracteres.", "OK");
            return;
        }

        // Aquí puedes agregar la lógica de registro con tu base de datos o API
        await DisplayAlert("Éxito", $"Bienvenido, {nombre}!", "OK");
    }

    private async void OnIniciarSesionTapped(object sender, TappedEventArgs e) {
        // Navegar a la página de inicio de sesión
        await Navigation.PushAsync(new LoginView());
    }
}

