using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using EFTQuests.Views;
using NLog;

namespace EFTQuests
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();


        public App()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            Application.Current.DispatcherUnhandledException += DispatcherOnUnhandledException;
            TaskScheduler.UnobservedTaskException += TaskSchedulerOnUnobservedTaskException;

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            BootStrapper.Start();

            var window = new MainWindow();

            window.DataContext = BootStrapper.RootVisual;

            window.Closed += (s, a) =>
            {
                BootStrapper.Stop();
            };

            window.Show();

        }

        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs args)
        {
            HandleException(args.ExceptionObject as Exception);
        }

        private void DispatcherOnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs args)
        {
            args.Handled = true;

            HandleException(args.Exception);
        }

        private void TaskSchedulerOnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs args)
        {
            args.SetObserved();

            HandleException(args.Exception.GetBaseException());
        }

        private void HandleException(Exception exception)
        {
            //TODO: improve - rly basic exception handling :D
            Logger.Error(exception.ToString);
        }
    }
}
