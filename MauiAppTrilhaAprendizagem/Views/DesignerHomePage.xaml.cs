namespace MauiAppTrilhaAprendizagem.Views
{
    public partial class DesignerHomePage : ContentPage
    {
        public DesignerHomePage()
        {
            InitializeComponent();
        }

        private async void OnCriarConteudosClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Criar Conteúdos", "Aqui o designer pedagógico poderá criar novos conteúdos.", "OK");
        }

        private async void OnEditarTrilhasClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Editar Trilhas", "Aqui o designer poderá editar e organizar trilhas existentes.", "OK");
        }

        private async void OnColaborarClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Colaboração", "Aqui o designer poderá colaborar com professores e ajustar materiais.", "OK");
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            // Volta para a tela de Login
            await Navigation.PopToRootAsync();
        }
    }
}
