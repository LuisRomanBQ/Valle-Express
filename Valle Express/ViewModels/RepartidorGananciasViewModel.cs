using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Valle_Express.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    class RepartidorGananciasViewModel
    {
        public int Pedidos { get; set; }
        public double Ganancias { get; set; }
        public ICommand GananciasDiarias => new Command(DailyProfits);
        public ICommand GananciasSemanales => new Command(WeeklyProfits);
        public ICommand GananciasMensuales => new Command(MonthlyProfits);
        public RepartidorGananciasViewModel()
        {
            DailyProfits();
        }

        public void DailyProfits()
        {
            Ganancias = 800;
            Pedidos = 15;
        }
        public void WeeklyProfits()
        {
            Ganancias = 2500;
            Pedidos = 67;
        }
        public void MonthlyProfits()
        {
            Ganancias = 30000;
            Pedidos = 158;
        }
    }
}
