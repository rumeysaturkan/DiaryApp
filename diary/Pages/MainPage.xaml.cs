using diary.Entity;
using diary.Lists;
using diary.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Xamarin.Forms;

namespace diary
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
            Task.Run(AnimateBorder);
        }

        public void Button_Clicked(object sender, EventArgs e)
        {

            var data = DependencyService.Get<PersonList>().Persons.ToList();
            Person d1 = data.Where(x => x.Email == emailEntry.Text && x.Password == passwordEntry.Text).FirstOrDefault();


            if (emailEntry.Text != null && passwordEntry.Text != null)
            {

                if (d1 == null)
                {
                    DisplayAlert("No Ticket Found", "", "OK");
                    Navigation.PushAsync(new RegisterPage());

                    Clean();


                }
                else
                {



                    Navigation.PushAsync(new Homepage(d1));
                    Clean();


                }
            }
            else
            {

                DisplayAlert("Hoops", "Enter Email and Password Please", "OK");
            }
        }
        private async void AnimateBorder()
        {
            Action<double> tealMovement = tInput => tealGrad.Offset = (float)tInput;
            Action<double> orangeMovement = oInput => orangeGrad.Offset = (float)oInput;

            while (true)
            {
                mainRect.Animate(name: "forward", callback: tealMovement, start: 0, end: 1, length: 1000, easing: Easing.SinIn);
                await Task.Delay(1000);
                mainRect.Animate(name: "backward", callback: tealMovement, start: 1, end: 0, length: 1000, easing: Easing.SinIn);
                await Task.Delay(1000);

                mainRect.Animate(name: "forward2", callback: orangeMovement, start: 1, end: 0, length: 1000, easing: Easing.SinIn);
                await Task.Delay(1000);
                mainRect.Animate(name: "backward2", callback: orangeMovement, start: 0, end: 1, length: 1000, easing: Easing.SinIn);
                await Task.Delay(1000);
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            Navigation.PushAsync(new RegisterPage());

        }
        public void Clean()
        {
            emailEntry.Text = "";
            passwordEntry.Text = "";

        }
    }
}

