using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        Xamarin.Forms.BoxView bok;
        Label bokl;
        public MainPage()
        {
            Grid abs = new Grid();
            bok = new BoxView {Color = Color.Black };
            abs.Children.Add(bok, 0, 0);

            bokl = new Label { BackgroundColor = Color.Coral, Text = "кнопка" };
            abs.Children.Add(bokl, 0, 1);
            Grid.SetColumnSpan(bokl, 3);
            Grid.SetRowSpan(bokl, 2);
            
            Content = abs;
        }
    }
}
