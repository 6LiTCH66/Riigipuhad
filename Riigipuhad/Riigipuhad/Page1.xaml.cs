using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Riigipuhad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        
        Label lbl, lbl1, lbl2, lbl3;
        Image img;
        public Page1()
        {
            lbl = new Label()
            {
                Text = "Uusaasta",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            lbl1 = new Label()
            {
                Text = "01. jaanuar",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10),
            };
            lbl2 = new Label() /*https://xn--riigiphad-v9a.ee/ */
            {
                Text = "Uusaasta on püha, mil tähistatakse uue kalendriaasta algust. Lääneriikides, " +
                "kus kasutatakse Gregoriuse kalendrit, on uusaasta 1. jaanuaril. Eestis on 1. " +
                "jaanuari kui uusaastat nimetatud ka nääripäevaks.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 20),
            };
            lbl3 = new Label()
            {
                Text = "Eesti Vabariigis on 1. jaanuaril tähistatav uusaasta riigipüha, " +
                "sellele eelnev tööpäev on töölepingu seaduse alusel 3 tunni võrra lühendatud.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 5, 10),
            };
            img.Source = ImageSource.FromFile("uusaasta.jpg");
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, lbl1, lbl2, lbl3, img }
            };
            Content = stackLayout;
        }
    }
}