using Valle_Express.ViewModels;
namespace Valle_Express.Views;

public partial class NegocioGanaciasView : ContentPage
{
	public NegocioGanaciasView()
	{
		InitializeComponent();
		BindingContext = new NegocioGananciasViewModel();
	}
}