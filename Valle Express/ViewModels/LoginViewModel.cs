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
        public ICommand goToMain => new Command(IniciarSesion);

        public async void IniciarSesion()
        {
            Application.Current.MainPage = new AppShell();

            await Shell.Current.GoToAsync($"///ClienteMainView");
        }
    }
}
