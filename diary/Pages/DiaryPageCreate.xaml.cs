using diary.Entity;
using diary.Lists;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace diary.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiaryPageCreate : ContentPage
    {

        public Person Person1;
        public DiaryPageCreate(Person person)
        {
            InitializeComponent();
            Person1 = person;
            profileImage.Source = person.ImageUrl;

        }


        public MediaFile _mediaFile;

        private void Button_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<DiaryList>().Diaries.Add(new Diary
            {
                Person = Person1,
                Title = tiletEntry.Text,
                Point = Int16.Parse(PointEntry.Text),
                Date = DatePicker.Date,
                Text = textEntry.Text,
                ImageUrl = ImageEntry.Text

            });


            DisplayAlert("Information", "Added Diary", "ok");
            Navigation.PushAsync(new MyDiary(Person1));

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