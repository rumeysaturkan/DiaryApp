using diary.Lists;
using diary.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace diary
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var navigationPage = new NavigationPage(new MainPage());
            Device.SetFlags(new[] { "Shapes_Experimental", "Brush_Experimental" });
            navigationPage.BarBackgroundColor = Color.FromHex("#dee0e6");
            navigationPage.BarTextColor = Color.White;
            MainPage = navigationPage;
            DependencyService.Register<DiaryList>();
            DependencyService.Register<PersonList>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
