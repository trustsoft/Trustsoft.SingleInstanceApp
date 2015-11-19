namespace Trustsoft.Wpf.SingleInstanceApp.Demo
{
    #region " Using Directives "

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows;

    using Trustsoft.SingleInstanceApp;

    #endregion

    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application, ISingleInstanceApp
    {
        #region " Constants "

        private const string UniqueKey = "{7E50767D-D49E-4C83-9A48-91438D6DDEC4}";

        #endregion

        #region " Static Methods "

        [STAThread]
        public static void Main()
        {
            if (SingleInstance<App>.InitializeAsFirstInstance(UniqueKey))
            {
                var application = new App();

                application.InitializeComponent();
                application.Run();

                // Allow single instance code to perform cleanup operations
                SingleInstance<App>.Cleanup();
            }
        }

        #endregion

        #region " Implementation of ISingleInstanceApp "

        public bool OnActivate(IList<string> args)
        {
            // handle command line arguments of second instance
            Current.MainWindow.Title = args.Any()
                                           ? args.Aggregate((s1, s2) => string.Format("{0}, {1}", s1, s2))
                                           : "Second instance launched";
            return true;
        }

        #endregion
    }
}