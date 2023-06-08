namespace Multicaixa_Express.View.Main.Home;

public partial class home : ContentPage
{
	public home()
	{
		InitializeComponent();
	}
    private void Click_Pagamentos(object sender, EventArgs e)
    {
        Navigation.PushAsync(new View.Main.Pagamentos.pagametos());
    }

    private void Click_Trasnferencias(object sender, EventArgs e)
    {
        Navigation.PushAsync(new View.Main.Transferencias.Transferencias());
    }

    private void Click_Levantamentos(object sender, EventArgs e)
    {
        Navigation.PushAsync(new View.Main.Levantamentos.Levantamentos());
    }
   
    private void Click_Consultas(object sender, EventArgs e)
    {
        Navigation.PushAsync(new View.Main.Consultas.Consultas());
    }
    
    private void Click_Compras_em_curso(object sender, EventArgs e)
    {
        Navigation.PushAsync(new View.Main.Compras_em_curso.Compras_em_curso());
    }

    private void Click_Compras(object sender, EventArgs e)
    {
        Navigation.PushAsync(new View.Main.Compras.Compras());
    }
}