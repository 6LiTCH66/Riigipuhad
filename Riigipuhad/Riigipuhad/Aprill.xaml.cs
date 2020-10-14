using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Riigipuhad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aprill : ContentPage
    {
        Label lbl, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9;
        Image img, img1;
        public Aprill()
        {
            Title = "Aprill";
            lbl = new Label()
            {
                Text = "Suur reede",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl1 = new Label()
            {
                Text = "10. aprill",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text= "Suur reede on kristlik püha, mil tähistatakse Jeesus Kristuse ristilöömist ja surma " +
                "Kolgata mäel. See kuulub kokku rea teiste pühadega, mis seostuvad Jeesuse eluga. Suur reede " +
                "eelneb lihavõttepühadele ning võib langeda kokku juudiusu paasapühadega.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl3 = new Label()
            {
                Text= "Kanooniliste evangeeliumite järgi löödi Jeesus tõenäoliselt risti reedel (päev enne sabatit; " +
                "Johannese evangeelium 19:42). Tõenäoliselt toimus see kas aastal 33 või 34 (nagu pakkus välja Isaac Newton, " +
                "võrreldes kuuseise ning piibliaegse ja juuliuse kalendri erinevust). Kuuvarjutuse järgi otsustades (ja kooskõlas " +
                "Peetruse sõnadega Apostlite tegude raamatus, 2:20) toimus see reedel, 3. aprillil 33. aastal.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl4 = new Label()
            {
                Text= "Enamikus kristlikes usulahkudes on tavaks pidada suurel reedel erilisi jumalateenistusi. Nendeks puhkudeks on " +
                "kirjutatud ka arvukalt muusikat, näiteks Johann Sebastian Bachi Matteuse passioon.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl5 = new Label()
            {
                Text = "Katoliku kirikus on suur reede paastupäev. Luteri kirikus oli suur reede 16.-20. sajandil aasta suurim püha," +
                " mil töötegemine oli keelatud ja kõige suurem hulk inimesi tuli armulauale. Viimasel ajal on suuremad luterlikud kirikud " +
                "siiski hakanud loobuma kombest korraldada suurel reedel armulauda.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };

            lbl6 = new Label()
            {
                Text = "Ülestõusmispühade 1. püha",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };

            lbl7 = new Label()
            {
                Text = "12. aprill",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };

            lbl8 = new Label()
            {
                Text = "Ülestõusmispühad (ka lihavõttepühad ehk lihavõtted ja munapühad) on kristluses liikuvad pühad, " +
                "mis algavad esimese täiskuu pühapäevaga pärast kevadist pööripäeva. Pühad mälestavad Jeesus Kristuse surnust " +
                "ülestõusmist pärast ristilöömist. Ajaliselt langevad need kokku judaismi paasapühadega. Samale ajale jääb ka " +
                "maausuliste kiigepüha ehk munapüha.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl9 = new Label()
            {
                Text = "Paljudes riikides on ülestõusmispühad ka riigipüha, kuid selle pikkus erineb riigiti. " +
                "Eestis on riigipühaks kuulutatud vaid ülestõusmispühadele eelnev suur reede ja ülestõusmispühade 1. püha. " +
                "Mitmel pool Euroopas on riigipüha ka ülestõusmispühade 2. püha, kuid Riigikogus on sellekohased ettepanekud" +
                " korduvalt tagasi lükatud põhjendusega, et Eestis on kirik ja riik lahus ning Eesti ei ole kristlik riik.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            img = new Image
            {
                Source = ImageSource.FromFile("suurrede.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (s, e) => {
                if (Clipboard.HasText)
                {
                    await DisplayAlert("Success", string.Format("Vaata kõik vebsitile {0}", "https://xn--riigiphad-v9a.ee/et/suur+reede"), "OK");
                }
            };
            img.GestureRecognizers.Add(tapGestureRecognizer);

            img1 = new Image
            {
                Source = ImageSource.FromFile("munad.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };
            var tapGestureRecognizer1 = new TapGestureRecognizer();
            tapGestureRecognizer1.Tapped += async (s, e) => {
                if (Clipboard.HasText)
                {
                    await DisplayAlert("Success", string.Format("Vaata kõik vebsitile {0}", "https://xn--riigiphad-v9a.ee/et/%C3%BClest%C3%B5usmisp%C3%BChade+1.+p%C3%BCha"), "OK");
                }
            };
            img1.GestureRecognizers.Add(tapGestureRecognizer1);

            StackLayout stackLayout1 = new StackLayout()
            {
                Children = { lbl6, lbl7, lbl8, lbl9, img1 }
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, lbl1, lbl2, lbl3, lbl4, lbl5, img }
            };
            StackLayout stackLayout2 = new StackLayout()
            {
                Children = { stackLayout, stackLayout1 }
            };
            ScrollView scrollView = new ScrollView { Content = stackLayout2 };
            Content = scrollView;
        }
    }
}