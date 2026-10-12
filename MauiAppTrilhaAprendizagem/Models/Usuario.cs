using SQLite;

namespace MauiAppTrilhaAprendizagem.Models
{
   public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int IdUsuario { get; set; }

        [NotNull]
        public string Nome { get; set; }

        [Unique, NotNull]
        public string Email { get; set; }

        [NotNull]
        public string Senha { get; set; }

        [NotNull]
        public string Perfil { get; set; } // Aluno, Professor, Designer
    }
}
