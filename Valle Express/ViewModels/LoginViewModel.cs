using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Valle_Express.Views;

namespace Valle_Express.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    internal class LoginViewModel
    {
        private readonly Page Referencia;
        public ICommand goToMainCommand { get; }
        public ICommand IrARegistroUsuarioCommand { get; }
        public LoginViewModel(Page Referencia)
        {
            this.Referencia = Referencia;
            goToMainCommand = new Command(async () => await IniciarSesion());
            IrARegistroUsuarioCommand = new Command(async () => await IrARegistro());
        }

        private async Task IniciarSesion()
        {
            Application.Current.MainPage = new AppShell();

            await Shell.Current.GoToAsync($"///{nameof(ClienteMainView)}");
        }
        private async Task IrARegistro()
        {
            await Referencia.Navigation.PushAsync(new RegistroUsuarioView());
        }
        public async void RegistroScreen()
        {
            await Shell.Current.GoToAsync($"RegistrarUsuarioView");
        }
    }
}
