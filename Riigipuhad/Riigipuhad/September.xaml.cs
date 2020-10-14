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
    public partial class September : ContentPage
    {
        Label _label, _label1, _label2, _label3, _label4;
        Image _image;
        public September()
        {
            Title = "September";
            _label = new Label()
            {
                Text = "Vanavanemate päev",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label1 = new Label()
            {
                Text = "13. september",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label2 = new Label()
            {
                Text = "1. jaanuaril 2010 võttis Riigikogu 81 poolthäälega vastu otsuse lisada vanavanemate päev riiklike tähtpäevade hulka. Vanavanemate päeva tähistatakse septembrikuu teisel pühapäeval ja eelnõu algataja valis selle päeva põhjusel, et ka emade- ja isadepäeva tähistatakse just kuu teisel pühapäeval. Seadusemuudatus sai teoks kodanikualgatuse korras ja eelnõu Pühade ja tähtpäevade seaduse muutmiseks esitas Erakond Eestimaa Rohelised fraktsioonile Kanal 2 reporter Heiki Valner.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label3 = new Label()
            {
                Text = "Vanavanemate päeva eesmärgiks on tänada ning avaldada austust vanavanematele laste ja lastelaste kasvatamise, jagatud hoole ning armastuse eest. Tähtpäev aitab lastel saada teadlikumaks sellest, millist tugevust, teadmisi ja elutarkust vanavanemad pakkuda suudavad ning tihendaks eri põlvkondade vahelist suhtlemist. Tähtpäev on asjakohane austusavaldus ka riigi poolt ning võimaldab avalikult näidata vanavanemate tähtsust eelkõige perekonna, aga ka ühiskonna jaoks tervikuna.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label4 = new Label()
            {
                Text = "Vanavanemate päeva tähistatakse ka mujal maailmas. Nii näiteks seadustas president Jimmy Carter 1979. aastal oma allkirjaga vanavanemate päeva rahvuspühana Ameerika Ühendriikides. Ameeriklased tähistavad vanavanemate päeva tööpühale (Labor Day, tähistatakse septembri esimesel esmaspäeval) järgneval esimesel pühapäeval ehk tavaliselt samal päeval, mil eestlased. Vanavanemate päeva tähistatakse kas riikliku tähtpäevana või rahvuspühana ka Kanadas, Prantsusmaal, Itaalias, Poolas, Inglismaal. Kõik riigid tähistavad seda päeva erinevatel kalendrikuudel. Kui Eestis on tegemist ilmaliku tähtpäevaga, siis Poolas on vanavanemate päev seotud katoliku kiriku usupühaga.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _image = new Image()
            {
                Source = ImageSource.FromFile("vana.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (s, e) => {
                if (Clipboard.HasText)
                {
                    bool action = await DisplayAlert("Success", string.Format("Vaata rohkem?"), "Jah", "Ei");
                    if(action == true)
                    {
                        Device.OpenUri(new Uri("https://et.wikipedia.org/wiki/Vanavanemate_p%C3%A4ev"));
                    }
                }
            };
            _image.GestureRecognizers.Add(tapGestureRecognizer);
            StackLayout stackLayout = new StackLayout()
            {
                Children = {_label, _label1, _label2, _label3, _label4, _image }
            };
            ScrollView scrollView = new ScrollView { Content = stackLayout };
            Content = scrollView;
        }
    }
}