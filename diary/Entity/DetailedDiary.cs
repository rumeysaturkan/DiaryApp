using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace diary.Entity
{
    public class DetailedDiary
    {

        public INavigation Navigation;
        public DetailedDiary(INavigation navigation, Diary diary)
        {
            PopDetailPageCommand = new Command(async () => await ExecutePopDetailPageCommand());
            Navigation = navigation;
            Diary = diary;

        }
        public Command PopDetailPageCommand { get; }
        public Diary Diary { get; set; }
        private async Task ExecutePopDetailPageCommand()
        {
            await Navigation.PopAsync();
        }
    }
}
