using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WinStarDate.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppPage : ContentPage
    {
        public AppPage()
        {
            InitializeComponent();
            while (true)
                try
                {
                    data.Date = DateTime.Parse(Preferences.Get("Data", "1968-09-08"));
                    break;
                } catch (FormatException e)
                {
                    Preferences.Clear();
                }
        }
        private void calcola_Click(object sender, EventArgs e)
        {
            int i = int.Parse(data.Date.Date.ToUniversalTime().ToString("dd")) + 1;
            String s = "" + i;
            if (s.Length == 1)
                s = "0" + s;
            risultato.Text = $"{Resources["srisultato"]} {data.Date.Date.ToUniversalTime().ToString("yy")}{data.Date.Date.ToUniversalTime().ToString("MM")}.{s}";
            Preferences.Set("Data", data.Date.ToString());

        }
    }
}