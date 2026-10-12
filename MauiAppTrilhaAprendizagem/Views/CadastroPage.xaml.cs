using MauiAppTrilhaAprendizagem.Data;
using MauiAppTrilhaAprendizagem.Models;

namespace MauiAppTrilhaAprendizagem.Views
{
    public partial class CadastroPage : ContentPage
    {
        private readonly DatabaseContext _db;

        public CadastroPage()
        {
            InitializeComponent();
            _db = new DatabaseContext();
            _db.InitializeAsync();
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Nome = NomeEntry.Text,
                Email = EmailEntry.Text,
                Senha = SenhaEntry.Text,
                Perfil = PerfilPicker.SelectedItem?.ToString()
            };

            await _db.AddUsuarioAsync(usuario);
            await DisplayAlert("Sucesso", "Usuário cadastrado com sucesso!", "OK");

            // Limpa os campos após o cadastro
            NomeEntry.Text = string.Empty;
            EmailEntry.Text = string.Empty;
            SenhaEntry.Text = string.Empty;
            PerfilPicker.SelectedItem = null;
        }
    }
}
