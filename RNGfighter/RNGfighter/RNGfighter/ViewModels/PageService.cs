﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

// the class to implement the IPageService interface

namespace RNGfighter
{
    public class PageService : IPageService
    {
        public async Task<bool> DisplayAlert(string title, string message, string ok, string cancel)
        {
            // property set in the app class
            return await Application.Current.MainPage.DisplayAlert(title, message, ok, cancel);
        }

        public async Task PushAsnyc(Page page)
        {
            await Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
