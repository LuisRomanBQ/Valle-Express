using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Valle_Express.Models;
using Valle_Express.Services;
using Valle_Express.Views;

namespace Valle_Express.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    internal class LoginViewModel
    {
        public ICommand goToMain => new Command(IniciarSesion);
        public ICommand fastLogin => new Command(InicioRapido);
        public ICommand IrARegistroUsuarioCommand => new Command(RegistrarUsuario);
        public UsuarioService RestService { get; set; } = new UsuarioService();
        public List<Usuario> Usuarios { get; set; }  = new List<Usuario>();
        public string Correo {  get; set; }
        public string Contraseña { get; set; }

        public async Task CargarLista()
        {
            Usuarios = await RestService.GetUsuarios();
        }
        public async void InicioRapido()
        {
            Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
            await Shell.Current.GoToAsync($"///ClienteMainView");
        }
        public async void IniciarSesion()
        {
            if (Usuarios == null || Usuarios.Count == 0)
            {
                Usuarios = await RestService.GetUsuarios();
            }
            bool Logged = false;
            await Shell.Current.DisplayAlert(
    "DEBUG",
    $"Usuarios cargados: {Usuarios.Count}",
    "OK"
);
            foreach (var Usuario in Usuarios)
            {
                if(Usuario.UsuarioEmail == Correo)
                {
                    if(Usuario.UsuarioHash == Contraseña)
                    {
                        Logged = true;
                        break;
                    }
                }
            }
            if (Logged)
            {
                Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;

                await Shell.Current.GoToAsync($"///ClienteMainView");
            }
            else
                await Shell.Current.DisplayAlert("Inicio Fallido","Correo/ Contraseña Incorrectos","OK");
        }
        public async void RegistrarUsuario()
        {
            await Shell.Current.GoToAsync($"RegistrarUsuarioView");
        }
    }
}
