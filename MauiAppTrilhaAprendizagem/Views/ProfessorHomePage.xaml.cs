namespace MauiAppTrilhaAprendizagem.Views
{
    public partial class ProfessorHomePage : ContentPage
    {
        public ProfessorHomePage()
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
