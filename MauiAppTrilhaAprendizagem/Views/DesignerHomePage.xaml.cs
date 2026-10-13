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
            await Navigation.PushAsync(new CriarConteudosPage());
        }

        private async void OnEditarTrilhasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditarTrilhasPage());
        }

        private async void OnColaborarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ColaborarProfessoresPage());
        }

        private async void OnSairClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}