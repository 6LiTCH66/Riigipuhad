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
    public partial class Veebruar : ContentPage
    {
        Label lbl, lbl1, lbl2, lbl3, lbl4;
        Image img;
        public Veebruar()
        {
            Title = "Veebruar";

            lbl = new Label()
            {
                Text = "Iseseisvuspäev, Eesti Vabariigi aastapäev",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10 ,10),
            };

            lbl1 = new Label()
            {
                Text = "24. veebruar",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text = "Eesti Vabariigi aastapäev on 24. veebruaril, millega tähistatakse Eesti Vabariigi " +
                "väljakuulutamist 1918. aasta 24. veebruaril. Sel päeval avaldati Tallinnas Manifest kõigile Eestimaa rahvastele" +
                ", milles kuulutati välja sõltumatu ja demokraatlik Eesti Vabariik. 24. veebruar on Eesti rahvuspüha ja iseseisvuspäev.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl3 = new Label()
            {
                Text = "Eesti taasiseseisvumise järgsel ajal on taastatud Eesti Vabariigi aastapäeva aegsete Eesti kaitseväe paraadide traditsioon, " +
                "nii nagu see on kombeks paljudes riikides. Samuti on tavaks, et Eesti president korraldab iseseisvuspäeval piduliku vastuvõtu, kus " +
                "annab üle riiklikud teenetemärgid, mille saajate nimekiri on varem ajakirjanduses ilmunud. Nii paraad kui ka vastuvõtt on eri aastail " +
                "toimunud eri linnades, 2014. aastal toimusid need Pärnus. Paraadist, vastuvõtust ja vastuvõtule eelnevast kontserdist, mille alguses " +
                "peab president aastapäevakõne, toimub otseülekanne televisioonis. Vastuvõtul toimuvat kätlemistseremooniat, kus president ja " +
                "presidendiproua kõiki külalisi tervitavad, on irooniliselt nimetatud pingviinide paraadiks (kõrvutades meeste pidulikke frakke " +
                "pingviinide mustvalge sulestikuga).",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl4 = new Label()
            {
                Text = "Kuna presidendi vastuvõtt korraldatakse alati Eesti Vabariigi aastapäeval, toimuvad samalaadsed vastuvõtud kohalikes " +
                "omavalitsustes sageli juba 23. veebruaril, koolides jt asutustes on aktused vahel aga veelgi varem. Viimastel aastatel on tavaks, " +
                "et peaminister peab kõne Tartus, Vanemuise teatris toimuval Tartu linna ja maakonna vastuvõtul. Tartus on traditsiooniks saanud ka " +
                "üliõpilaskorporatsioonide kogunemine Tartu tähetorni heisatud Eesti lipu tervitamisele 24. veebruaril.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            img = new Image
            {
                Source = ImageSource.FromFile("vabariigi.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = {lbl, lbl1, lbl2, lbl3, lbl4, img}
            };
            ScrollView scroll = new ScrollView { Content = stackLayout };
            Content = scroll;
        }
    }
}