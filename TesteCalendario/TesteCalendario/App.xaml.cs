using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace TesteCalendario
{
	public partial class App : Application
	{
		public App ()
		{
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjMwOTJAMzEzNjJlMzIyZTMwVTM2ZXRBV1YvUW02N0xrVjJ3Z3BwblpQd2R4L3Fra2tBQUdWL1hHVmVJYz0=");

            InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
