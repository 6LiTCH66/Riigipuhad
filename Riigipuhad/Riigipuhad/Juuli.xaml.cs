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
    public partial class Juuli : ContentPage
    {
        Label _label;
        public Juuli()
        {
            Title = "Juuli";
            _label = new Label()
            {
                Text = "Juulis on pole Riigipühad",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 10, 10, 10),
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { _label}
            };
            Content = stackLayout;
        }
    }
}