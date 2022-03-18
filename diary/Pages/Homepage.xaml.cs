using diary.Entity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace diary.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Homepage : ContentPage
    {
        public Person Person1;
        public Homepage(Person person)
        {
            InitializeComponent();

            profileImage.Source = person.ImageUrl;
            Name.Text = person.Name;
            Email.Text = person.Email;
            Person1 = person;

        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DiaryPageCreate(Person1));
        }
        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyDiary(Person1));
        }

        private void SwipeItemView_Invoked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DiaryPageCreate(Person1));
        }

        private void SwipeItemView_Invoked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyDiary(Person1));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}
