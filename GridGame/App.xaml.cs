namespace GridGame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();//title screen into cheracter creation (obj user)
            object temp = null; // to save nabigaton page while in fight
            //MainPage = new NavigationPage(new MainPage()); when finishing cheracter creation and title screen
            //then push for menu and pop to get back into the game
        }
    }
}