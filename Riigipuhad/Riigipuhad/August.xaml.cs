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
    public partial class August : ContentPage
    {
        Label lbl1, lbl2, lbl3, lbl4, lbl5, lbl6;
        Image img;
        public August()
        {
            Title = "August";
            lbl1 =new Label()
            {
                Text = "Taasiseseisvumispäev",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl2 = new Label()
            {
                Text = "20. august",
                FontAttributes = FontAttributes.Italic,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl3 = new Label()
            {
                Text = "Taasiseseisvumispäev (ka iseseisvuse taastamise päev) on Eesti Vabariigi riigipüha, millega igal aastal 20. augustil tähistatakse Eesti Vabariigi de facto taastamist Eesti Vabariigi Ülemnõukogu otsusega Eesti riiklikust iseseisvusest, mis võeti Eesti Komiteega kooskõlastatult vastu Eesti Vabariigi Ülemnõukogu istungil 20. augustil 1991 kell 23:03.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl4 = new Label()
            {
                Text = "Sama dokumendiga otsustati moodustada Eesti Vabariigi põhiseaduse väljatöötamiseks Põhiseaduslik Assamblee, mille koosseis kujundatakse delegeerimise teel Eesti Vabariigi kõrgeima seadusandliku riigivõimuorgani Eesti Vabariigi Ülemnõukogu ning Eesti Vabariigi kodanikkonna esinduskogu Eesti Kongressi poolt ja viia läbi Eesti Vabariigi uue põhiseaduse järgi Eesti Vabariigi parlamendivalimised 1992. aasta jooksul.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl5 = new Label()
            {
                Text = "Eesti Vabariigi Ülemnõukogu lähtus oma otsuses Eesti Vabariigi järjekestvusest rahvusvahelise õiguse subjektina.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            lbl6 = new Label()
            {
                Text = "27. jaanuaril 1998 Riigikogu poolt vastu võetud Pühade ja tähtpäevade seaduse parandusega sätestati taasiseseisvumispäev riigipühaks ja töövabaks päevaks ning sama aasta 20. augustil tähistati seda esimest korda riiklikult.",
                FontSize = 18,
                TextColor = Color.Black,
                Padding = new Thickness(10, 10, 10, 10),
            };
            img = new Image()
            {
                Source = ImageSource.FromFile("taa.jpg"),
                Margin = new Thickness(15, 20, 15, 5),
            };
            var tapGestureRecognizer1 = new TapGestureRecognizer();
            tapGestureRecognizer1.Tapped += async (s, e) => {
                if (Clipboard.HasText)
                {
                    bool action = await DisplayAlert("Success", string.Format("Vaata rohkem? {0}","https://xn--riigiphad-v9a.ee/et/taasiseseisvumisp%C3%A4ev"), "Jah", "Ei");
                    if(action == true)
                    {
                        Device.OpenUri(new Uri("https://riigipühad.ee/et/taasiseseisvumispäev"));
                    }
                }
            };
            img.GestureRecognizers.Add(tapGestureRecognizer1);
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, img}
            };
            ScrollView scrollView = new ScrollView { Content = stackLayout };
            Content = scrollView;
            
        }
    }
}