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

    internal class RepartidorViewModel
    {
        public ICommand IrAGananciasCommand => new Command(GananciasScreen);
        public ICommand IrAUbicacionCommand => new Command(UbicacionScreen);
        public ICommand IrAHistorialCommand => new Command(HistorialScreen);

        public async void GananciasScreen()
        {
            await Shell.Current.GoToAsync(nameof(RepartidorGananciasView));
        }
        public async void UbicacionScreen()
        {
            await Shell.Current.GoToAsync(nameof(RepartidorUbicacionView));
        }
        public async void HistorialScreen()
        {
            await Shell.Current.GoToAsync(nameof(RepartidorHistorialView));
        }
    }
}
