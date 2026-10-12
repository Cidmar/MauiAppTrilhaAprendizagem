using SQLite;

namespace MauiAppTrilhaAprendizagem.Models
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int IdUsuario { get; set; }

        [NotNull]
        public string Nome { get; set; } = string.Empty;

        [Unique, NotNull]
        public string Email { get; set; } = string.Empty;

        [NotNull]
        public string Senha { get; set; } = string.Empty;

        [NotNull]
        public string Perfil { get; set; } = string.Empty; // Aluno, Professor, Designer
    }
}
