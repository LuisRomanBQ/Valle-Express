using Valle_Express.ViewModels;

namespace Valle_Express.Views;

public partial class RepartidorGananciasView : ContentPage
{
	public RepartidorGananciasView()
	{
		InitializeComponent();
		BindingContext = new RepartidorGananciasViewModel();
	}
}