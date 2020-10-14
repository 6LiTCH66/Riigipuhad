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
    public partial class Marts : ContentPage
    {
        Label lbl, lbl1, lbl2, lbl3, lbl4, lbl5;
        Image img;
        public Marts()
        {
            Title = "Märts";
            lbl = new Label()
            {
                Text = "Emakeelepäev",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl1 = new Label()
            {
                Text = "14. märts",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text = "Emakeelepäeva tähistame <strong style=\"color:black\">14. märtsil</strong>. Esimest korda peeti emakeelepäeva 1996. aastal. " +
                "Selle tähtpäeva idee autoriks on Sonda kooliõpetaja <strong style=\"color:black\">Meinhard Laks</strong> (1922-2008), kes juba 1995. aastal hakkas koguma " +
                "toetusallkirju meie emakeele kaitseks.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
                TextType = TextType.Html,
            };
            lbl3 = new Label()
            {
                Text = "Ametlikult kuulutas riigikogu emakeelepäeva riiklikuks tähtpäevaks 1999. aastal.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl4 = new Label()
            {
                Text = "14. märts valiti emakeelepäevaks kui eesti esimese kirjaniku Kristian Jaak Petersoni (1801-1822) sünnipäev. " +
                "Tähelepanuväärne on, et Peterson, kes elas vaid 21 aastat, oskas vähemalt 16 keelt, kuid kirjutamiseks valis ta just eesti " +
                "keele, keele, mida 19. sajandi algul kutsuti lihtsalt maakeeleks. Petersoni oodist Kuu pärineb mõte, mida on ikka ja jälle " +
                "tsiteeritud:\n" +
                "• kas siis selle maa keel \n" +
                "• laulu tuules ei või \n" +
                "• taevani tõustes üle \n" +
                "• sigavikku omale otsida ?\n",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl5 = new Label()
            {
                Text = "Alates 2008. aastast on saanud traditsiooniks kirjutada emakeelepäeval e-etteütlust. E-etteütluse kirjutamine " +
                "on aastatega muutunud järjest populaarsemaks. E-etteütluse tekst loetakse ette Vikerraadios ja vastused saadetekase " +
                "elektrooniliselt.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            img = new Image
            {
                Source = ImageSource.FromFile("emakeel.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (s, e) => {
                if (Clipboard.HasText)
                {
                    bool action = await DisplayAlert("Success", string.Format("Vaata rohkem?"), "Jah", "Ei");
                    if(action == true)
                    {
                        Device.OpenUri(new Uri("https://monikaundo.weebly.com/emakeelepaumlev.html"));
                    }
                }
            };
            img.GestureRecognizers.Add(tapGestureRecognizer);
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, lbl1, lbl2, lbl3, lbl4, lbl5, img },
            };
            ScrollView scroll = new ScrollView { Content = stackLayout };
            Content = scroll;
        }
    }
}