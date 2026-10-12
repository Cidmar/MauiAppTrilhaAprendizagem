namespace MauiAppTrilhaAprendizagem.Views
{
    public partial class ProfessorHomePage : ContentPage
    {
        public ProfessorHomePage()
        {
            InitializeComponent();
        }

        private async void OnGerenciarTrilhasClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Gerenciar Trilhas", "Aqui o professor poderá criar e gerenciar trilhas de aprendizagem.", "OK");
        }

        private async void OnAcompanharAlunosClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Acompanhar Alunos", "Aqui o professor poderá acompanhar o desempenho dos alunos.", "OK");
        }

        private async void OnRelatoriosClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Relatórios", "Aqui o professor poderá visualizar relatórios de participação e progresso.", "OK");
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            // Volta para a tela de Login
            await Navigation.PopToRootAsync();
        }
    }
}
