namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();

        // 1. CHAMA O MÉTODO PARA PREENCHER O PICKER
        PreencherSuites();
    }

    /// <summary>
    /// Adiciona os nomes das suítes ao Picker.
    /// </summary>
    private void PreencherSuites()
    {
        // 2. LISTA DOS NOMES FORNECIDOS
        List<string> suites = new List<string>
        {
            "Suíte Super Luxo",
            "Suíte Luxo",
            "Suíte Single",
            "Suíte Crise" // É uma suíte ousada! 😉
        };

        // 3. DEFINE A LISTA COMO FONTE DE DADOS DO PICKER (pck_quarto)
        pck_quarto.ItemsSource = suites;
    }
}