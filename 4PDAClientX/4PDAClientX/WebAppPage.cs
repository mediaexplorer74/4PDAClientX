using Xamarin.Essentials;
using Xamarin.Forms;

namespace WorkingWithWebview
{
    public class WebAppPage : ContentPage
    {
        public WebAppPage()
        {
            var l = new Label
            {
                Text = "These buttons leave the current app and open the built-in web browser app for the platform"
            };

            var openUrl = new Button
            {
                Text = "Open 4pda.to/forum using built-in Web Browser app"
            };
            openUrl.Clicked += async (sender, e) =>
            {
                await Launcher.OpenAsync("https://4pda.to/forum");
            };

            var makeCall = new Button
            {
                Text = "Make call using built-in Phone app"
            };
            makeCall.Clicked += async (sender, e) =>
            {
                await Launcher.OpenAsync("tel:7777777777777777777777777777777");
            };

            Content = new StackLayout
            {
                Padding = new Thickness(5, 20, 5, 0),
                HorizontalOptions = LayoutOptions.Fill,
                Children = {
                    l,
                    openUrl,
                    makeCall
                }
            };
        }
    }
}
