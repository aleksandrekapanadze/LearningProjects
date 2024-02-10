namespace DddInPractice.Logic.UI
{
    public partial class App
    {
        public App()
        {
            Initer.Init(@"Server=(LocalDB)\MSSQLLocalDB;Database=DddInPractice;Trusted_Connection=true");
        }
    }
}
