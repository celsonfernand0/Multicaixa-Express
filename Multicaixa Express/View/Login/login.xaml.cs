using Multicaixa_Express.DTO;
using CommunityToolkit.Maui;
using Multicaixa_Express.View.Main.Home;

namespace Multicaixa_Express.View.Login;

public partial class login : ContentPage
{
    int cont = 0;
    string senha = String.Empty;
    

    public login()
    {
        InitializeComponent();
     

    }



    public void Click_char(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
       
        senha += btn.Text;
        
        cont++;
        switch (cont)
        {

            case 1:
                char1.BackgroundColor = Color.FromArgb("#fffff");

                break;

            case 2:

                char2.BackgroundColor = Color.FromArgb("#fffff");

                break;

            case 3:
                char3.BackgroundColor = Color.FromArgb("#fffff");

                break;

            case 4:
                char4.BackgroundColor = Color.FromArgb("#fffff");

                break;

            case 5:

                char5.BackgroundColor = Color.FromArgb("#fffff");
                break;

            case 6:

                char6.BackgroundColor = Color.FromArgb("#fffff");



                foreach (var item in new Usuario().Conta())
                {
                    if (item.Pin == senha)
                    {
                        App.Current.MainPage = new NavigationPage(new View.Main.Home.home());

                    }

                }





                break;

        }

    }


    private void Click_Del(object sender, EventArgs e)
    {

        if (senha != null)
        {
            senha = senha.Substring(0, senha.Length - 1);


        }

        switch (cont)
        {
            case 1:

                char1.BackgroundColor = Color.FromArgb("#808080");
                break;

            case 2:

                char2.BackgroundColor = Color.FromArgb("#808080");

                break;

            case 3:
                char3.BackgroundColor = Color.FromArgb("#808080");

                break;

            case 4:
                char4.BackgroundColor = Color.FromArgb("#808080");

                break;

            case 5:
                char5.BackgroundColor = Color.FromArgb("#808080");
                break;
            case 6:
                char6.BackgroundColor = Color.FromArgb("#808080");
                break;
        }

        cont--;

    }


}
