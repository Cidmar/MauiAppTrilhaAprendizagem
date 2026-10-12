using SQLite;
using System.IO;
using MauiAppTrilhaAprendizagem.Models;

namespace MauiAppTrilhaAprendizagem.Data
{
    public class DatabaseContext
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseContext()
        {
            var dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "gamificacao.db3");

            _database = new SQLiteAsyncConnection(dbPath);
        }

        // Busca do usuario pelo e-mail
        public async Task<Usuario> GetUsuarioByEmailAsync(string email)
        {
            return await _database.Table<Usuario>()
                .Where(u => u.Email == email)
                .FirstOrDefaultAsync();
        }


        // Inicializa o banco e cria tabelas
        public async Task InitializeAsync()
        {
            await _database.CreateTableAsync<Usuario>();
        }

        // Mantém o método de conexão que você já tinha
        public SQLiteAsyncConnection GetConnection() => _database;

        // -------------------------------
        // CRUD de Usuário
        // -------------------------------

        // CREATE
        public Task<int> AddUsuarioAsync(Usuario usuario)
        {
            return _database.InsertAsync(usuario);
        }

        // READ - listar todos
        public Task<List<Usuario>> GetUsuariosAsync()
        {
            return _database.Table<Usuario>().ToListAsync();
        }

        // READ - buscar por email/senha (login)
        public Task<Usuario> GetUsuarioAsync(string email, string senha)
        {
            return _database.Table<Usuario>()
                .Where(u => u.Email == email && u.Senha == senha)
                .FirstOrDefaultAsync();
        }

        // UPDATE
        public Task<int> UpdateUsuarioAsync(Usuario usuario)
        {
            return _database.UpdateAsync(usuario);
        }

        // DELETE
        public Task<int> DeleteUsuarioAsync(Usuario usuario)
        {
            return _database.DeleteAsync(usuario);
        }
    }
}

