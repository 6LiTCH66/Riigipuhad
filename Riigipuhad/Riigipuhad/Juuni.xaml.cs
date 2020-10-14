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
    public partial class Juuni : ContentPage
    {
        
        Label lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10, lbl11;
        Image img, img1;
        public Juuni()
        {
            Title = "Juuni";
            lbl1 = new Label()
            {
                Text = "Võidupüha",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text = "23. juuni",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl3 = new Label()
            {
                Text = "Võidupüha on Eesti riigipüha, mida peetakse 23. juunil alates aastast 1934. Sellega tähistatakse Eesti võitu Võnnu lahingus Landeswehri üle 23. juunil 1919.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl4 = new Label()
            {
                Text = "Võidupüha on eraisikutele kohustuslikuks lipuheiskamise päevaks. Võidupüha tähistamine on tseremoniaalselt seotud jaanipäeva tähistamisega 24. juunil.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
                    
            };
            lbl5 = new Label()
            {
                Text = "Jaanipäev",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl6 = new Label()
            {
                Text = "24. juuni",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl7 = new Label()
            {
                Text = "Jaanipäev on Eestis 24. juunil tähistatav püha. 24. juunile eelnevat 23. juuni päeva nimetatakse jaanilaupäevaks ja nendevahelist ööd jaaniööks, seda tähistatakse Eestis, Lätis ja põhjamaades jaanituledega.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
                
            };
            lbl8 = new Label()
            {
                Text = "Jaanipäeva nimetus pärineb kirikukalendrist, kirikus tähistatakse sel päeval Ristija Johannese sünnipäeva.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl9 = new Label()
            {
                Text = "Eesti Vabariigis on jaanilaupäev ja jaanipäev riigipühad; jaanilaupäeval peetakse Eestis võidupüha, mis tähistab Eesti vägede võitu Vabadussõjas Võnnu lahingus 23. juunil 1919 Landeswehri üle.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl10 = new Label()
            {
                Text = "Pärimuslik jaanipidu Vana-Vigala ohvrihiie juures (juuni 2016)",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl11 = new Label()
            {
                Text = "Jaaniõhtut ja -ööd tähistatakse Eestis laialdaselt jaanituledega, millel on sümboolne seos pööripäeva ja päikese kõrgseisuga. Sel puhul on kombeks korraldada nii rahvapidusid kui ka tähistada püha sõprade ja tuttavate keskel väiksemate lõkkeõhtute või grillimisega koduaias või looduses. Tänapäevalgi on jaanipäev eestlaste jaoks üks aasta tähtsamaid pühi, mida ka välismaal viibides teistest sagedamini tähistatakse.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            img1 = new Image()
            {
                Source = ImageSource.FromFile("jaani.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (s, e) => {
                if (Clipboard.HasText)
                {
                    await DisplayAlert("Success", string.Format("Vaata kõik vebsitile {0}", "https://et.wikipedia.org/wiki/Jaanip%C3%A4ev"), "OK");
                }
            };
            img1.GestureRecognizers.Add(tapGestureRecognizer);

            img = new Image()
            {
                Source = ImageSource.FromFile("vord2.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };

            var tapGestureRecognizer1 = new TapGestureRecognizer();
            tapGestureRecognizer1.Tapped += async (s, e) => {
                if (Clipboard.HasText)
                {
                    await DisplayAlert("Success", string.Format("Vaata kõik vebsitile {0}", "https://et.wikipedia.org/wiki/V%C3%B5idup%C3%BCha"), "OK");
                }
            };
            img.GestureRecognizers.Add(tapGestureRecognizer1);

            StackLayout stackLayout1 = new StackLayout()
            {
                Children = { lbl5, lbl6, lbl7, lbl8, lbl9, lbl10, lbl11, img1}
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl1, lbl2, lbl3, lbl4, img}
            };
            StackLayout stackLayout2 = new StackLayout()
            {
                Children = { stackLayout, stackLayout1}
            };
            ScrollView scrollView = new ScrollView { Content = stackLayout2 };
            Content = scrollView;
        }
    }
}