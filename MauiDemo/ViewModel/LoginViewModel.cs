using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace MauiDemo.ViewModel;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    string username="";

    [ObservableProperty]
    string password ="";

    [RelayCommand]
    void Login(){
        System.Diagnostics.Debug.Print("Username: " + Username);
        System.Diagnostics.Debug.Print("Password: " + Password);
    }

    [RelayCommand]
    async Task GotoPage(string page)
    {
        await Shell.Current.GoToAsync(page);
    }

}
