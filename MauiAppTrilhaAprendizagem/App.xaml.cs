using MauiAppTrilhaAprendizagem.Data;

namespace MauiAppTrilhaAprendizagem
{
    public partial class App : Application
    {
        static DatabaseContext _database;

        public static DatabaseContext Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new DatabaseContext();
                    _database.InitializeAsync().Wait();
                }
                return _database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell(); // Define o AppShell como página inicial
        }
    }
}

