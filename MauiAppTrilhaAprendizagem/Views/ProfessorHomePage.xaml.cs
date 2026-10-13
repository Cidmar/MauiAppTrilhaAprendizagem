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
            // Alterna para a tela de gerenciamento de trilhas
            await Navigation.PushAsync(new GerenciarTrilhasPage());
        }

        private async void OnAcompanharAlunosClicked(object sender, EventArgs e)
        {
            // Alterna para a tela de acompanhamento
            await Navigation.PushAsync(new AcompanharAlunosPage());
        }

        private async void OnRelatoriosClicked(object sender, EventArgs e)
        {
            // Alterna para a tela de relatórios
            await Navigation.PushAsync(new RelatoriosProfessorPage());
        }

        private async void OnSairClicked(object sender, EventArgs e)
        {
            // Retorna para a tela de Login
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}