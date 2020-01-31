using System.Windows;
using Autofac;

namespace EFTQuests.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IContainer _appContainer;
        public MainWindow()
        {
            SetUpContainer();
            InitializeComponent();
        }

        private void SetUpContainer()
        {
            var builder = new ContainerBuilder();

            BuildupContainer(builder);

            var container = builder.Build();

            _appContainer = container;
        }

        private void BuildupContainer(ContainerBuilder builder)
        {
            //builder.RegisterType<Logger>().As<ILogger>();
            
        }

    }
}
