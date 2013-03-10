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
			Browser.IsScriptEnabled = true;
			Browser.Navigate(new Uri("Html/SGP3.html", UriKind.Relative));
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