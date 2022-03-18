using diary.Lists;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using diary.Entity;

namespace diary.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyDiary : ContentPage
    {
        public Person a { get; }

        public MyDiary(Person person)
        {
            a = person;
            InitializeComponent();

            BindingContext = DependencyService.Get<DiaryList>();

            phoneView.ItemsSource = DependencyService.Get<DiaryList>().Diaries.Where(x => x.Person == person).ToList();
            profileImage.Source = person.ImageUrl;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DiaryPageCreate(a));
        }
        public void OnMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);

            Navigation.PushAsync(new DiaryPageCreate(a));
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);


            var a = DisplayAlert("Information", "Deleted Diary Page", "OK");

            DependencyService.Get<DiaryList>().Diaries.Remove(mi.BindingContext as Diary);

        }
        public void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }


        }

        public void OnRefresh(object sender, EventArgs e)
        {
            var list = (Xamarin.Forms.ListView)sender;
            //put your refreshing logic here
            var itemList = DependencyService.Get<DiaryList>().Diaries.Where(x => x.Person == a).Reverse().ToList();
            DependencyService.Get<DiaryList>().Diaries.Clear();
            foreach (var s in itemList)
            {
                DependencyService.Get<DiaryList>().Diaries.Add(s);
            }
            list.IsRefreshing = false;
        }

        private void ccc_Clicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);

            Diary context = mi.BindingContext as Diary;

            Navigation.PushAsync(new DetailedDiaryPage(context, a));

        }

        private void aaa_Clicked(object sender, EventArgs e)
        {

            var mi = ((MenuItem)sender);

            Diary context = mi.BindingContext as Diary;

            Navigation.PushAsync(new DiaryEditPage(context, a));

        }
    }
}