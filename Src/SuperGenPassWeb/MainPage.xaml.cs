using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SuperGenPassWeb.Resources;

namespace SuperGenPassWeb
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Конструктор
        public MainPage()
        {
            InitializeComponent();
            LocalizedApplicationBar();
			Browser.IsScriptEnabled = true;
			Browser.Navigate(new Uri("Html/SGP3.html", UriKind.Relative));
        }

        private void LocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.
            ApplicationBarIconButton AppBarClearAll =
                new ApplicationBarIconButton(new
                Uri("/Images/clearall.png", UriKind.Relative));
            AppBarClearAll.Text = AppResources.AppBarButtonClearAll;
            AppBarClearAll.Click += ClearAllClick;
            ApplicationBar.Buttons.Add(AppBarClearAll);

            ApplicationBarIconButton AppBarAbout =
                new ApplicationBarIconButton(new
                Uri("/Images/about.png", UriKind.Relative));
            AppBarAbout.Text = AppResources.AppBarButtonAbout;
            AppBarAbout.Click += AboutClick;
            ApplicationBar.Buttons.Add(AppBarAbout);
        }
		
        private void ClearAllClick(object sender, EventArgs e)
        {
			Browser.Navigate(new Uri("Html/SGP3.html", UriKind.Relative));
        }
		
        private void AboutClick(object sender, System.EventArgs e)
        {
            Uri targetUri = new Uri("/AboutPage.xaml", System.UriKind.Relative);
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(targetUri);
        }
    }
}