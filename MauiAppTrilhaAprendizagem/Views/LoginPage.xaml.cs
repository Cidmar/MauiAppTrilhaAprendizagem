using MauiAppTrilhaAprendizagem.Data;
using MauiAppTrilhaAprendizagem.Models;

namespace MauiAppTrilhaAprendizagem.Views
{
    public partial class LoginPage : ContentPage
    {
        private readonly DatabaseContext _db;

        public LoginPage()
        {
            InitializeComponent();
            _db = new DatabaseContext();
            _db.InitializeAsync();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            var email = EmailEntry.Text;
            var senha = SenhaEntry.Text;

            var usuario = await _db.GetUsuarioByEmailAsync(email);

            if (usuario != null && usuario.Senha == senha)
            {
                await DisplayAlert("Bem-vindo!", $"Olá, {usuario.Nome} ({usuario.Perfil})", "OK");

                // Redireciona conforme o perfil
                Page destino = usuario.Perfil switch
                {
                    "Aluno" => new AlunoHomePage(),
                    "Professor" => new ProfessorHomePage(),
                    "Designer Pedagógico" => new DesignerHomePage(),
                    _ => new LoginPage()
                };

                await Navigation.PushAsync(destino);
            }
            else
            {
                await DisplayAlert("Erro", "Email ou senha incorretos.", "OK");
            }
        }

        private async void OnCadastroClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroPage());
        }
    }
}
