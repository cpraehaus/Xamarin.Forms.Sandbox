using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms.StyleSheets;

namespace Xamarin.Forms.Sandbox
{
    public partial class App
    {
        void InitializeMainPage()
        {
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

            MainPage = new NavigationPage(new MainPage());
        }

        public static Application GetApplication()
        {
            return new App();
        }
    }
}
