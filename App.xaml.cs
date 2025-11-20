// App.xaml.cs
namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // CORREÇÃO: A página principal deve ser o AppShell.
            // O AppShell.xaml definirá qual é a página inicial (Home).
            MainPage = new AppShell();
        }
        // ... (o método CreateWindow pode permanecer como está)

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 600;
            window.Height = 900;

            return window; 
        }


    }
}