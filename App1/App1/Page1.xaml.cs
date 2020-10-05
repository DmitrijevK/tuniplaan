using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        Label pis1, pis2, pis3, pis4, pis5, pis6, pis7, pis8, pis9, ad1, ad2, ad3, ad4, ad5, ras1, ras2, ras3, ras4, ras5, ras6, ras7, ras8, ras9, ras10, ras11, ras12, ras13, ras14;//Kirill Dmitrijev
        Frame bok1;//Kirill Dmitrijev
        bool taps = false;
        public Page1()
        {
            Grid abs = new Grid();
            for (int i = 0; i < 10; i++)
            {
                abs.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }

            for (int i = 0; i < 5; i++)
            {
                abs.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }
            //с верху//Kirill Dmitrijev
            bok1 = new Frame { BackgroundColor = Color.White, BorderColor = Color.Black };
            abs.Children.Add(bok1, 0, 0);
            Grid.SetRowSpan(bok1, 2);
            pis1 = new Label { BackgroundColor = Color.White, Text = "1" };
            abs.Children.Add(pis1, 2, 0);
            pis2 = new Label { BackgroundColor = Color.White, Text = "2" };
            abs.Children.Add(pis2, 3, 0);
            pis3 = new Label { BackgroundColor = Color.White, Text = "3" };
            abs.Children.Add(pis3, 4, 0);
            pis4 = new Label { BackgroundColor = Color.White, Text = "4" };
            abs.Children.Add(pis4, 5, 0);
            pis5 = new Label { BackgroundColor = Color.White, Text = "5" };
            abs.Children.Add(pis5, 6, 0);
            pis6 = new Label { BackgroundColor = Color.White, Text = "6" };
            abs.Children.Add(pis6, 7, 0);
            pis7 = new Label { BackgroundColor = Color.White, Text = "7" };
            abs.Children.Add(pis7, 8, 0);
            pis8 = new Label { BackgroundColor = Color.White, Text = "8" };
            abs.Children.Add(pis8, 9, 0);
            pis9 = new Label { BackgroundColor = Color.White, Text = "9" };
            abs.Children.Add(pis9, 10, 0);
            //с боку//Kirill Dmitrijev
            ad1 = new Label { BackgroundColor = Color.White, Text = "Пн" };
            abs.Children.Add(ad1, 0, 1);
            Grid.SetRowSpan(ad1, 2);
            ad2 = new Label { BackgroundColor = Color.White, Text = "Вт" };
            abs.Children.Add(ad2, 0, 2);
            Grid.SetRowSpan(ad2, 2);
            ad3 = new Label { BackgroundColor = Color.White, Text = "Ср" };
            abs.Children.Add(ad3, 0, 3);
            Grid.SetRowSpan(ad3, 2);
            ad4 = new Label { BackgroundColor = Color.White, Text = "Чт" };
            abs.Children.Add(ad4, 0, 4);
            Grid.SetRowSpan(ad4, 2);
            ad5 = new Label { BackgroundColor = Color.White, Text = "Пт" };
            abs.Children.Add(ad5, 0, 5);
            Grid.SetRowSpan(ad5, 2);

            //САМО РАСПИСАНИЕ//Kirill Dmitrijev

            ras1 = new Label { BackgroundColor = Color.Green, Text = "Keel ja \n Kirjandus" };
            Grid.SetRowSpan(ras1, 2);
            abs.Children.Add(ras1, 2, 1);

            ras2 = new Label { BackgroundColor = Color.DeepPink, Text = "Võrgud ja Seadm." };//Kirill Dmitrijev
            Grid.SetRowSpan(ras2, 2);
            abs.Children.Add(ras2, 4, 1);
            //Kirill Dmitrijev
            ras3 = new Label { BackgroundColor = Color.LightBlue, Text = "Mob. Rak." };
            Grid.SetRowSpan(ras3, 3);
            abs.Children.Add(ras3, 7, 1);

            ras4 = new Label { BackgroundColor = Color.LightYellow, Text = "Transp.log.hut." };
            Grid.SetRowSpan(ras4, 3);
            abs.Children.Add(ras4, 2, 2);

            ras5 = new Label { BackgroundColor = Color.Gray, Text = "Inglise W.hald" };//Kirill Dmitrijev
            Grid.SetRowSpan(ras5, 2);
            abs.Children.Add(ras5, 6, 2);

            ras6 = new Label { BackgroundColor = Color.DeepPink, Text = "Eesti keel \n teise kellena" };
            Grid.SetRowSpan(ras6, 2);
            abs.Children.Add(ras6, 8, 2);

            ras7 = new Label { BackgroundColor = Color.DeepPink, Text = "W.paig.sead." };
            Grid.SetRowSpan(ras7, 3);
            abs.Children.Add(ras7, 2, 3);

            ras8 = new Label { BackgroundColor = Color.LightYellow, Text = "Transp.log.hut." };
            Grid.SetRowSpan(ras8, 5);
            abs.Children.Add(ras8, 5, 3);

            ras9 = new Label { BackgroundColor = Color.Pink, Text = "Keemia \n Biologia" };
            abs.Children.Add(ras9, 10, 3);
            //Kirill Dmitrijev
            ras10 = new Label { BackgroundColor = Color.DeepPink, Text = "W.paig.sead." };
            Grid.SetRowSpan(ras10, 3);
            abs.Children.Add(ras10, 2, 4);

            ras11 = new Label { BackgroundColor = Color.Gray, Text = "Võrgud ja Seadm." };
            Grid.SetRowSpan(ras11, 2);
            abs.Children.Add(ras11, 6, 4);
            //Kirill Dmitrijev
            ras12 = new Label { BackgroundColor = Color.Gray, Text = "Inglise W.hald" };
            Grid.SetRowSpan(ras12, 2);
            abs.Children.Add(ras12, 8, 4);

            ras13 = new Label { BackgroundColor = Color.Pink, Text = "Keemia \n Biologia" };
            abs.Children.Add(ras12, 2, 5);

            ras14 = new Label { BackgroundColor = Color.LightBlue, Text = "Mob. Rak." };
            Grid.SetRowSpan(ras12, 3);//Kirill Dmitrijev
            abs.Children.Add(ras12, 4, 5);


            var tap = new TapGestureRecognizer();
            
            tap.Tapped += (s, e) =>
            {
                // ---------------------------------------
                ras6 = (Label)s;
                if (taps == true)
                {
                    ras6.FontSize = 10;
                    ras6.Text = "B236, Alina";
                }
                else
                {
                    ras6.FontSize = 20;
                    ras6.Text = "Eesti keel \n teise kellena";
                    taps = true;
                }
                // ---------------------------------------
                ras5 = (Label)s;
                if (taps == true)
                {
                    ras5.FontSize = 10;
                    ras5.Text = "B242, j.Voron.";
                }
                else
                {
                    ras5.FontSize = 20;
                    ras5.Text = "Inglise W.hald";
                    taps = true;
                }
                // ---------------------------------------
                ras4 = (Label)s;
                if (taps == true)
                {
                    ras4.FontSize = 10;
                    ras4.Text = "B212, j.Skrul";
                }
                else
                {
                    ras4.FontSize = 20;
                    ras4.Text = "Transp.log.hut.";
                    taps = true;
                }
                // ---------------------------------------
                ras2 = (Label)s;
                if (taps == true)
                {
                    ras2.FontSize = 10;
                    ras2.Text = "A243, L.Shkarbanova";
                }
                else
                {
                    ras2.FontSize = 20;
                    ras2.Text = "Võrgud ja Seadm.";
                    taps = true;
                }
                // ---------------------------------------
                ras1 = (Label)s;
                if (taps == true)
                {
                    ras1.FontSize = 10;
                    ras1.Text = "B221, L.Mihailova";
                }
                else
                {
                    ras1.FontSize = 20;
                    ras1.Text = "Keel ja \n Kirjandus";
                    taps = true;
                }
                // ---------------------------------------
                ras14 = (Label)s;
                if (taps == true)
                {
                    ras14.FontSize = 10;
                    ras14.Text = "E107, Maria oleinik";
                }
                else
                {
                    ras14.FontSize = 20;
                    ras14.Text = "Mob. Rak.";
                    taps = true;
                }
                ras3 = (Label)s;
                // ---------------------------------------
                if (taps == true)
                {
                    ras1.FontSize = 10;
                    ras1.Text = "E107, Maria oleinik";
                    taps = false;

                }
                else
                {
                    ras1.FontSize = 20;
                    ras1.Text = "Mob. Rak.";
                    taps = true;
                }
            };
            ras1.GestureRecognizers.Add(tap);
            Content = abs;
        }//Kirill Dmitrijev
    }
}//Kirill Dmitrijev