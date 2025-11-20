namespace MauiAppHotel
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // REGISTRO DE ROTAS: Registre as rotas das páginas que não são a página inicial
            // Isso permite que você navegue para elas usando Shell.Current.GoToAsync("rota")

            // Certifique-se de que a namespace "Views" existe ou ajuste conforme necessário.
            Routing.RegisterRoute("ContratacaoRoute", typeof(Views.ContratacaoHospedagem));
        }
    }
}