using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridExercise1 : ContentPage
    {
        public GridExercise1()
        {
            InitializeComponent();
        }

        public void Handle_Click(object sender, EventArgs e)
        {
            var label = sender as Button;

            if (label.Text == "Dial")
            {
                dialledNumberLabel.Text = string.Empty;
            }
            else
            {
                dialledNumberLabel.Text += label.Text;
            }
        }
    }
}