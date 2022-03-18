using diary.Entity;
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
    public partial class DetailedDiaryPage : ContentPage
    {
        public Person person1;
        public DetailedDiaryPage(Diary diary, Person person)
        {
            InitializeComponent();
            BindingContext = new DetailedDiary(Navigation, diary);
            person1 = person;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            detailContainer.FadeTo(1, 200, Easing.CubicInOut);
            detailContainer.TranslateTo(0, 0, 200, Easing.CubicInOut);


        }
    }
}