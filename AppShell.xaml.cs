// AppShell.xaml.cs
namespace MauiAppHotel
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Rotas já existentes
            Routing.RegisterRoute("ContratacaoRoute", typeof(Views.ContratacaoHospedagem));
            Routing.RegisterRoute("HospedagemContratadaRoute", typeof(Views.HospedagemContratada));

            // NOVO: Registro da rota para a página Sobre
            Routing.RegisterRoute("SobreRoute", typeof(Views.Sobre));
        }
    }
}