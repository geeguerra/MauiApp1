using MauiApp1.ViewModels;

namespace MauiApp1.View;

public partial class localPage : ContentPage
{
	public localPage(LocalViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}