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

    internal class NegocioViewModel
    {
        public ICommand IrAGananciasCommand => new Command(GananciasScreen);
        public ICommand IrAMenuCommand => new Command(MenuScreen);
        public ICommand IrAHistorialCommand => new Command(HistorialScreen);

        public async void GananciasScreen()
        {
            await Shell.Current.GoToAsync(nameof(NegocioGanaciasView));
        }
        public async void MenuScreen()
        {
            await Shell.Current.GoToAsync(nameof(NegocioMenuView));
        }
        public async void HistorialScreen()
        {
            await Shell.Current.GoToAsync(nameof(NegocioHistorialView));
        }
    }
}
