using Valle_Express.ViewModels;

namespace Valle_Express.Views;

public partial class RepartidorMainView : ContentPage
{
	public RepartidorMainView()
	{
		InitializeComponent();
		BindingContext = new RepartidorViewModel();
	}
}