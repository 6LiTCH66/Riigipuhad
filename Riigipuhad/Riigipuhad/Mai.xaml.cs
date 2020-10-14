using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Riigipuhad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mai : ContentPage
    {
        Label lbl, lbl1, lbl2, lbl3;
        Image img;
        public Mai()
        {
            Title = "Mai";
            lbl = new Label()
            {
                Text = "Kevadpüha",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl1 = new Label()
            {
                Text = "01. mai",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text = "Kevadpüha on Eesti riigipüha, mida peetakse 1. mail. Pühaga tähistatakse kevade saabumist.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl3 = new Label()
            {
                Text = "1. mai kui kevadpüha kattub nii rahvusvahelise töörahvapühaga kui ka Eesti rahvakalendri volbripäevaga.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            img = new Image
            {
                Source = ImageSource.FromFile("kevad.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (s, e) => {
                if (Clipboard.HasText)
                {
                    await DisplayAlert("Success", string.Format("Vaata kõik vebsitile {0}", "https://xn--riigiphad-v9a.ee/et/kevadp%C3%BCha"), "OK");
                }
            };
            img.GestureRecognizers.Add(tapGestureRecognizer);
            StackLayout stackLayout = new StackLayout()
            {
                Children = {lbl, lbl1, lbl2, lbl3, img}
            };
            ScrollView scrollView = new ScrollView { Content = stackLayout };
            Content = scrollView;
        }
    }
}