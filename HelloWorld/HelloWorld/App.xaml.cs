﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage =
                //new HelloWorld.MainPage();
                //new GreetPage();
                //new QuotesPage();
                //new StackLayoutExercise1();
                //new StackLayoutExercise2();
                //new GridPage();
                new GridExercise1();
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
