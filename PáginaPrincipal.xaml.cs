namespace MauiAppHotel
{
    // A classe já está corretamente declarada como 'partial'
    public partial class PáginaPrincipal : ContentPage
    {
        public PáginaPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manipulador de clique para navegar para a página de Contratação de Hospedagem.
        /// Este método deve ser referenciado pelo botão 'Fazer Contratação/Reserva' no XAML.
        /// </summary>
        private async void OnContratacaoClicked(object sender, EventArgs e)
        {
            // Navega para a rota registrada no AppShell.xaml.cs
            // É essencial usar 'async' e 'await' para navegação assíncrona.
            await Shell.Current.GoToAsync("ContratacaoRoute");
        }
        
        /// NOVO: Método de navegação para a tela Sobre.
                private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SobreRoute");
        }
        
        // NOTA: Toda a lógica do contador ('count', 'OnCounterClicked', referências a 'CounterBtn') foi removida.

    }
}