﻿using Xamarin.Forms;

namespace HealthClinic
{
    public class App : Application
    {
        public App() => MainPage = new HealthClinicNavigationPage(new FoodListPage());
    }
}