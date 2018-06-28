using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        public string[] quotes = {
            "Before God we are all equally wise - and equally foolish.",
            "Do not worry about your difficulties in Mathematics. I can assure you mine are still greater.",
            "I never teach my pupils. I only attempt to provide the conditions in which they can learn.",
            "If I had only known, I would have been a locksmith.",
            "Only two things are infinite, the universe and human stupidity, and I'm not sure about the former."
        };

        private int index = 0;

        public QuotesPage()
        {
            InitializeComponent();

            quoteLabel.Text = quotes[0];
        }

        public void Handle_Clicked(object sender, EventArgs e)
        {
            index++;
            if (index == quotes.Length)
            {
                index = 0;
            }
            quoteLabel.Text = quotes[index];
        }
    }
}