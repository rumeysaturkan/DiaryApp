using diary.Entity;
using diary.Lists;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace diary.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        public MediaFile _mediaFile;

        private void Button_Clicked1(object sender, EventArgs e)
        {
            var data = DependencyService.Get<PersonList>().Persons.ToList();
            var d1 = data.Where(x => x.Email == emailEntry.Text).FirstOrDefault();
            if (emailEntry.Text != null && passwordEntry.Text != null && passwordEntry2.Text != null && nameEntry.Text != null)
            {
                if (passwordEntry.Text == passwordEntry2.Text)
                {
                    if (d1 == null)
                    {
                        if (passwordEntry.Text.Length <= 6)
                        {
                            DisplayAlert("Information", "enter long 6 character for password", "Ok");
                        }
                        else
                        {
                            DisplayAlert("Added", "", "OK");
                            DependencyService.Get<PersonList>().Persons.Add(new Person
                            {
                                Email = emailEntry.Text,
                                Name = nameEntry.Text,
                                Password = passwordEntry.Text,
                                ImageUrl = ImageUrlEntry.Text
                            });
                            Navigation.PushAsync(new MainPage());
                        }
                    }

                    else
                    {
                        DisplayAlert("Information", "Such an account already exists", "OK");
                        Navigation.PushAsync(new MainPage());
                    }
                }
                else
                {
                    DisplayAlert("Information", "Passwords not same", "Ok");
                }
            }
            else
            {
                DisplayAlert("Hoops", "Enter Value Please", "OK");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
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
                ImageUrlEntry.Text = _mediaFile.Path;
            }
        }
    }
}