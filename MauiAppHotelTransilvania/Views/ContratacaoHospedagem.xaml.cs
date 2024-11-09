namespace MauiAppHotelTransilvania.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}
    private void Avanco(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new HospedagemContratada());
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Ok");
		}
    }
}