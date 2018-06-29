using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HelloWorld
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

			MainPage =
				//new MainPage();
				//new GreetPage();
				//new QuotesPage();
				//new StackLayoutExercise1();
				//new StackLayoutExercise2();
				//new GridPage();
				//new GridExercise1();
				//new QuotesPage();
				//new GridExercise2();
				//new AbsolutePage();
				new AbsoluteLayoutExercise1();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
