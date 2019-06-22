namespace DependencyInjectionTest
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(ITestService testService)
        {
            InitializeComponent();

            MainContent.Text = testService.GetText();
        }
    }
}
