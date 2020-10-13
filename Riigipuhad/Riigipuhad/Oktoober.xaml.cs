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
    public partial class Oktoober : ContentPage
    {
        Label _label1, _label2, _label3;
        Image _image;
        public Oktoober()
        {
            Title = "Oktoober";
            _label1 = new Label()
            {
                Text = "Hõimupäev",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label2 = new Label()
            {
                Text = "17. oktoober",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _label3 = new Label()
            {
                Text = "Teisipäeval, 16. oktoobril algavad Eestis järjekordsed hõimupäevad. Hõimupäevad on " +
                       "soome-ugri maailma tähtsaim regulaarne kultuurisündmus, Eestis hakati neid tähistama 78 " +
                       "aastat tagasi. Vastavalt 1931. aastal toimunud IV soome-ugri kultuurikongressi otsusele " +
                       "peetakse hõimupäevi kõikjal soome-ugri maailmas igal aastal oktoobrikuu kolmandal " +
                       "nädalavahetusel. 1940. aastal hõimupäevade tähistamise traditsioon katkes, kuid Eesti " +
                       "ungari seltside initsiatiivil taastati see 1988. aastal. 1991. aastast on hõimupäevade " +
                       "peakorraldajaks Fenno-Ugria Asutus. 2000. aastal kinnistas hõimupäevad oktoobri kolmandale " +
                       "nädalavahetusele ka Soome-ugri rahvaste IV maailmakongress Helsingis.Tänavused hõimupäevad on " +
                       "juubelihõngulised: tegemist on 20-ndate sõjajärgsete hõimupäevadega, mis on omakorda pühendatud" +
                       " Fenno-Ugria Asutuse 80. sünnipäevale. Eestisse saabub mitmeid soome-ugri rahvaste " +
                       "folklooriansambleid Soomest, Ungarist ja Venemaalt, kontsertidega esinevad soomlased, " +
                       "ungarlased, mordvalased, karjalased, komid ja udmurdid. Hõimupäevi peetakse ka enamikus " +
                       "Eesti maakondadest.",
                
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            _image = new Image()
            {
                Source = ImageSource.FromFile("okt.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = {_label1, _label2, _label3, _image }
            };
            ScrollView scrollView = new ScrollView { Content = stackLayout };
            Content = scrollView;
        }
    }
}