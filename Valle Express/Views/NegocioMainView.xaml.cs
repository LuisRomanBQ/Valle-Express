using Valle_Express.ViewModels;
namespace Valle_Express.Views;

public partial class NegocioMainView : ContentPage
{
	public NegocioMainView()
	{
		InitializeComponent();
		BindingContext = new NegocioViewModel();
	}
}