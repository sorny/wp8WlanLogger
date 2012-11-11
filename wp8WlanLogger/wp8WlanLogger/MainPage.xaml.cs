using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using wp8WlanLogger.Resources;
using Microsoft.Phone.Maps;


namespace wp8WlanLogger
{
    public partial class MainPage : PhoneApplicationPage
    {
        const string LOGGING_ON = "ON";
        const string LOGGING_OFF = "OFF";

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        
        // Placeholder code to contain the ApplicationID and AuthenticationToken
        // that must be obtained online from the Windows Phone Dev Center
        // before publishing an app that uses the Map control.
        private void map_Loaded(object sender, RoutedEventArgs e)
        {
            MapsSettings.ApplicationContext.ApplicationId = "<applicationid>";
            MapsSettings.ApplicationContext.AuthenticationToken = "<authenticationtoken>";
        }

        private void onOff_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button) sender;
            if (button.Content.Equals(LOGGING_ON))
            {
                activateLogging(button);
            }
            else if (button.Content.Equals(LOGGING_OFF))
            {
                deactivateLogging(button);
            }
            else
            {
                throw new InvalidOperationException("The state of the Button is unknown: " + button.Content);
            }

        }

        private void deactivateLogging(Button button)
        {
            button.Content = LOGGING_ON;
        }

        private void activateLogging(Button button)
        {
            button.Content = LOGGING_OFF;
        }

        private void Sync_Click(object sender, RoutedEventArgs e)
        {
            //sync
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}