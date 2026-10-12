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

            // Define que o AppShell é a página inicial
            MainPage = new AppShell();
        }
    }
}

