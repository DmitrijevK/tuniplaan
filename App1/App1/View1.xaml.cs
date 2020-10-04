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
    public partial class View1 : ContentView
    {
        Label pis1, pis2, pis3, pis4, pis5, pis6, pis7, pis8, pis9, ad1, ad2, ad3, ad4, ad5, ras1, ras2, ras3, ras4, ras5, ras6, ras7, ras8, ras9, ras10, ras11, ras12, ras13, ras14;
        Frame bok1;
        public View1()
        {
            Grid abs = new Grid();
            for (int i = 0; i < 10; i++)
            {
                abs.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }

            for (int i = 0; i < 5; i++)
            {
                abs.RowDefinitions.Add(new RowDefinition{ Height = new GridLength(1, GridUnitType.Star) });
            }
            //с верху
            bok1 = new Frame { BackgroundColor = Color.White, BorderColor = Color.Black };
            abs.Children.Add(bok1, 0, 0);
            Grid.SetRowSpan(bok1, 2);
            pis1 = new Label { BackgroundColor = Color.White, Text = "1" };
            abs.Children.Add(pis1, 3, 0);
            pis2 = new Label { BackgroundColor = Color.White, Text = "2" };
            abs.Children.Add(pis2, 4, 0);
            pis3 = new Label { BackgroundColor = Color.White, Text = "3" };
            abs.Children.Add(pis3, 5, 0);
            pis4 = new Label { BackgroundColor = Color.White, Text = "4" };
            abs.Children.Add(pis4, 6, 0);
            pis5 = new Label { BackgroundColor = Color.White, Text = "5" };
            abs.Children.Add(pis5, 7, 0);
            pis6 = new Label { BackgroundColor = Color.White, Text = "6" };
            abs.Children.Add(pis6, 8, 0);
            pis7 = new Label { BackgroundColor = Color.White, Text = "7" };
            abs.Children.Add(pis7, 9, 0);
            pis8 = new Label { BackgroundColor = Color.White, Text = "8" };
            abs.Children.Add(pis8, 10, 0);
            pis9 = new Label { BackgroundColor = Color.White, Text = "9" };
            abs.Children.Add(pis9, 11, 0);
            //с боку
            ad1 = new Label { BackgroundColor = Color.White, Text = "Понедельник" };
            abs.Children.Add(ad1, 0, 1);
            Grid.SetRowSpan(ad1, 2);
            ad2 = new Label { BackgroundColor = Color.White, Text = "Вторник" };
            abs.Children.Add(ad2, 0, 2);
            Grid.SetRowSpan(ad2, 2);
            ad3 = new Label { BackgroundColor = Color.White, Text = "Среда" };
            abs.Children.Add(ad3, 0, 3);
            Grid.SetRowSpan(ad3, 2);
            ad4 = new Label { BackgroundColor = Color.White, Text = "Четверг" };
            abs.Children.Add(ad4, 0, 4);
            Grid.SetRowSpan(ad4, 2);
            ad5 = new Label { BackgroundColor = Color.White, Text = "Пятница" };
            abs.Children.Add(ad5, 0, 5);
            Grid.SetRowSpan(ad5, 2);

            //САМО РАСПИСАНИЕ

            ras1 = new Label { BackgroundColor = Color.Green, Text = "Keel ja \n Kirjandus" };
            Grid.SetRowSpan(ras1, 2);
            abs.Children.Add(ras1, 3,1);

            ras2 = new Label { BackgroundColor = Color.DeepPink, Text = "Võrgud ja Seadm." };
            Grid.SetRowSpan(ras2, 2);
            abs.Children.Add(ras2, 5, 1);

            ras3 = new Label { BackgroundColor = Color.LightBlue, Text = "Mob. Rak." };
            Grid.SetRowSpan(ras3, 3);
            abs.Children.Add(ras3, 8, 1);

            ras4 = new Label { BackgroundColor = Color.LightYellow, Text = "Transp.log.hut." };
            Grid.SetRowSpan(ras4, 3);
            abs.Children.Add(ras4, 3, 2);

            ras5 = new Label { BackgroundColor = Color.Gray, Text = "Inglise W.hald" };
            Grid.SetRowSpan(ras5, 2);
            abs.Children.Add(ras5, 7, 2);

            ras6 = new Label { BackgroundColor = Color.DeepPink, Text = "Eesti keel \n teise kellena" };
            Grid.SetRowSpan(ras6, 2);
            abs.Children.Add(ras6, 9, 2);

            ras7 = new Label { BackgroundColor = Color.DeepPink, Text = "W.paig.sead." };
            Grid.SetRowSpan(ras7, 3);
            abs.Children.Add(ras7, 3, 3);

            ras8 = new Label { BackgroundColor = Color.LightYellow, Text = "Transp.log.hut." };
            Grid.SetRowSpan(ras8, 5);
            abs.Children.Add(ras8, 6, 3);

            ras9 = new Label { BackgroundColor = Color.Pink, Text = "Keemia \n Biologia" };
            abs.Children.Add(ras9, 11, 3);

            ras10 = new Label { BackgroundColor = Color.DeepPink, Text = "W.paig.sead." };
            Grid.SetRowSpan(ras10, 3);
            abs.Children.Add(ras10, 3, 4);

            ras11 = new Label { BackgroundColor = Color.Gray, Text = "Võrgud ja Seadm." };
            Grid.SetRowSpan(ras11, 2);
            abs.Children.Add(ras11, 7, 4);

            ras12 = new Label { BackgroundColor = Color.Gray, Text = "Inglise W.hald" };
            Grid.SetRowSpan(ras12, 2);
            abs.Children.Add(ras12, 9, 4);

            ras13 = new Label { BackgroundColor = Color.Pink, Text = "Keemia \n Biologia" };
            abs.Children.Add(ras12, 3, 5);

            ras14 = new Label { BackgroundColor = Color.LightBlue, Text = "Mob. Rak." };
            Grid.SetRowSpan(ras12, 3);
            abs.Children.Add(ras12, 5, 5);

            Content = abs; 
        }
    }
}