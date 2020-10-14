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
    public partial class Detsember : ContentPage
    {
        private Label _label, _label1, _label2, _label3, _label4, _label5, _label6, _label7, _label8, _label9;
        private Image _image, _image1, _image2;
        public Detsember()
        {
            Title = "Detsember";
            _label = new Label()
            {
                Text = "Jõululaupäev",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label1 = new Label()
            {
                Text = "24. detsember",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label2 = new Label()
            {
                Text = "Jõululaupäev (ka: jõuluõhtu) on 24. detsember, päev enne esimest jõulupüha. Eestis on see päev riigipüha.",    
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label3 = new Label()
            {
                Text = "Juliuse kalendri järgi, mida kasutab teiste seas Vene Õigeusu Kirik, langeb see päev praegu (aastatel 1900–2099) 6. jaanuarile.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _image = new Image()
            {
                Source = ImageSource.FromFile("joulu.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };
            var tapGestureRecognizer1 = new TapGestureRecognizer();
            tapGestureRecognizer1.Tapped += async (s, e) => {
                if (Clipboard.HasText)
                {
                    bool action = await DisplayAlert("Success", string.Format("Vaata rohkem? {0}","https://riigipühad.ee/et/jõululaupäev"), "Jah", "Ei");
                    if(action == true)
                    {
                        Device.OpenUri(new Uri("https://xn--riigiphad-v9a.ee/et/jõululaupäev"));
                    }
                }

            };
            _image.GestureRecognizers.Add(tapGestureRecognizer1);

            _label4 = new Label()
            {
                Text = "Esimene jõulupüha",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label5 = new Label()
            {
                Text = "25. detsember",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label6 = new Label()
            {
                Text = "Pärast Eesti iseseisvuse taastamist on esimene ja teine jõulupüha (25. ja 26. detsember) riigipühad ja puhkepäevad, alates 2005. aastast ka jõululaupäev. Jõulukombestikku mõjutab järjest rohkem rahvusvaheline traditsioon. Rahvusringhääling kannab üle nii jõululaupäeva kui esimese jõulupüha jumalateenistusi. Paljudes asulates püstitatakse juba advendiaja alguses keskväljakule elektrituledega ehitud jõulukuusk, mis jääb enamasti püsti kolmekuningapäevani (langeb kokku Vene Õigeusu Kiriku jõululaupäevaga). Skandinaaviast on üle võetud komme asetada akendele advendiküünlad. Paljudes lastega peredes pannakse jõulude eel õhtuti aknalauale suss, kuhu toob maiustusi päkapikk – jõuluvana abiline, kes kontrollib ja talle ette kannab, kas lapsed on hästi käitunud. Kaubandusettevõtted rõhutavad jõulude eel külluse, heaolu ja kinkide tegemise tähtsust, püüdes suurendada oma läbimüüki; jõuludekoratsioonid ilmuvad kauplustesse sageli juba novembrikuus. Jõuluaja traditsioonilisteks toitudeks on jäänud verivorstid ning seapraad ahjukartuli ja hapukapsastega. Nii nagu naaberriikides, nõnda ka Eestis sagenevad jõulude ja uusaasta aegu meditsiinistatistikas liigsöömisest ja -joomisest tekkinud vaevused.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _image1 = new Image()
            {
                Source = ImageSource.FromFile("es.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (s, e) => {
                if (Clipboard.HasText)
                {
                    bool action = await DisplayAlert("Success", string.Format("Vaata rohkem?"), "Jah", "Ei");
                    if(action == true)
                    {
                        Device.OpenUri(new Uri("https://riigipühad.ee/et/esimene+jõulupüha"));
                    }
                }

            };
            _image1.GestureRecognizers.Add(tapGestureRecognizer);
            _label7 = new Label()
            {
                Text = "Teine jõulupüha",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label8 = new Label()
            {
                Text = "26. detsember",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label9 = new Label()
            {
                Text = "Pärast Eesti iseseisvuse taastamist on esimene ja teine jõulupüha (25. ja 26. detsember) riigipühad ja puhkepäevad, alates 2005. aastast ka jõululaupäev. Jõulukombestikku mõjutab järjest rohkem rahvusvaheline traditsioon.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _image2 = new Image()
            {
                Source = ImageSource.FromFile("te.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };

            var tapGestureRecognizer2 = new TapGestureRecognizer();
            tapGestureRecognizer2.Tapped += async (s, e) => {
                if (Clipboard.HasText)
                {
                    bool action = await DisplayAlert("Success", string.Format("Vaata rohkem?"), "Jah", "Ei");
                    if(action == true)
                    {
                        Device.OpenUri(new Uri("https://xn--riigiphad-v9a.ee/et/teine+jõulupüha"));
                    }
                }

            };
            _image2.GestureRecognizers.Add(tapGestureRecognizer2);
            StackLayout stackLayout = new StackLayout()
            {
                Children = { _label, _label1, _label2, _label3, _image}
            };
            
            StackLayout stackLayout1 = new StackLayout()
            {
                Children = { _label4, _label5, _label6, _image1}
            };
            
            StackLayout stackLayout2 = new StackLayout()
            {
                Children = { _label7, _label8, _label9, _image2}
            };
            StackLayout stackLayout3 = new StackLayout()
            {
                Children = { stackLayout, stackLayout1, stackLayout2}
            };
            ScrollView scrollView = new ScrollView { Content = stackLayout3 };
            Content = scrollView;
        }
    }
}