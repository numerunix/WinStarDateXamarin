using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WinStarDate.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/numerunix/WinStarDateXamarin"));
        }

        public ICommand OpenWebCommand { get; }
    }
}