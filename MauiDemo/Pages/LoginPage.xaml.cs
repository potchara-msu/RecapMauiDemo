using MauiDemo.ViewModel;

namespace MauiDemo.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel();
	}
}