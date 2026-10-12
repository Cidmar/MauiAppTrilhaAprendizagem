namespace MauiAppTrilhaAprendizagem.Views
{
    public partial class AlunoHomePage : ContentPage
    {
        public AlunoHomePage()
        {
            InitializeComponent();
        }

        private async void OnTrilhasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrilhaMatematicaPage());
        }

        private async void OnExerciciosClicked(object sender, EventArgs e)
        {
            // Aqui futuramente você pode abrir uma página de exercícios e avaliações
            await DisplayAlert("Exercícios", "Aqui o aluno acessará exercícios e avaliações.", "OK");
        }

        private async void OnProgressoClicked(object sender, EventArgs e)
        {
            // Aqui futuramente você pode abrir uma página de progresso detalhado
            await DisplayAlert("Progresso", "Aqui o aluno acompanhará seu progresso.", "OK");
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            // Volta para a tela de Login
            await Navigation.PopToRootAsync();
        }
    }
}
