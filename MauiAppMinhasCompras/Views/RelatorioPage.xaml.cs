namespace MauiAppMinhasCompras.Views;

public partial class RelatorioPage : ContentPage
{
    public RelatorioPage()
    {
        InitializeComponent(); 
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        lst_relatorio.ItemsSource = await App.Db.GetRelatorioCategoria();
    }
}