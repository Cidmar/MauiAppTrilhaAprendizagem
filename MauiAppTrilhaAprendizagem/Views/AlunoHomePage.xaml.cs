namespace MauiAppTrilhaAprendizagem.Views
{
    public partial class AlunoHomePage : ContentPage
    {
        public AlunoHomePage()
        {
            InitializeComponent();
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            // Retorna para a tela de login
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
