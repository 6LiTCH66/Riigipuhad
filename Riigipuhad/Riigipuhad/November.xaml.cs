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
    public partial class November : ContentPage
    {
        Label _label1, _label2, _label3, _label4;
        Image _image;
        public November()
        {
            Title = "November";
            _label1 = new Label()
            {
                Text = "Hingedepäev",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label2 = new Label()
            {
                Text = "2. november",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label3 = new Label()
            {
                Text = "Katoliiklikus kirikukalendris kehtestati 1006. aastal 2. november hingedepäeva ehk usklike surnute mälestuspäevana.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label4 = new Label()
            {
                Text = "Eestlastel jääb hingedepäev hingedeaja sisse. Hingedepäeva on nimetatud juba " +
                       "14. sajandi allikates, kuid selle (nagu ka 1. novembri ehk pühakutepäeva) tähistamine on " +
                       "jäänud omauskumustele tugineva hingedeaja varju. " +
                       "1990. aastatel levis tava süüdata hingedepäeval koduakendel ja kalmistul sugulaste " +
                       "haudadel lahkunute mälestuseks küünlad.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _image = new Image()
            {
                Source = ImageSource.FromFile("nov.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };
            var tap = new TapGestureRecognizer();
            tap.Tapped += TapOnTapped;
            _image.GestureRecognizers.Add(tap);
            StackLayout stackLayout = new StackLayout()
            {
                Children = { _label1, _label2, _label3, _label4, _image}
            };
            ScrollView scrollView = new ScrollView { Content = stackLayout };
            Content = scrollView;
        }

        private void TapOnTapped(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}