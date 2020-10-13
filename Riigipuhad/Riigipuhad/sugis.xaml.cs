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
    public partial class sugis : TabbedPage
    {
        public sugis()
        {
            Title = "Sügis";
            InitializeComponent();
        }
    }
}