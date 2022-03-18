using diary.Entity;
using diary.Lists;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace diary.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiaryEditPage : ContentPage
    {
        Person person1;
        public DiaryEditPage(Diary diary, Person person)
        {

            InitializeComponent();
            BindingContext = diary;
            titleEntry.Text = diary.Title;
            textEntry.Text = diary.Text;
            PointEntry.Text = diary.Point.ToString();
            ImageEntry.Text = diary.ImageUrl;
            person1 = person;
            profileImage.Source = person.ImageUrl;
        }
        public MediaFile _mediaFile;

        private void Button_Clicked(object sender, EventArgs e)
        {

            DependencyService.Get<DiaryList>().Diaries.Remove(BindingContext as Diary);
            DependencyService.Get<DiaryList>().Diaries.Add(new Diary
            {
                Person = person1,
                Title = titleEntry.Text,
                Point = Int16.Parse(PointEntry.Text),
                Date = DatePicker.Date,
                Text = textEntry.Text,
                ImageUrl = ImageEntry.Text
            });
            titleEntry.Text = "";
            textEntry.Text = "";
            PointEntry.Text = "";
            ImageEntry.Text = "";
            DisplayAlert("Information", "Added Diary", "ok");
            Navigation.PushAsync(new MyDiary(person1));

        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (e.NewDate == null)
            {
                return;
            }

        }
        public async void OnPickPhotoButtonClicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Error", "This is not support on your device.", "OK");
                return;
            }
            else
            {
                _mediaFile = await CrossMedia.Current.PickPhotoAsync();
                if (_mediaFile == null) return;
              
                ImageEntry.Text = _mediaFile.Path;
            }
        }
    }
}