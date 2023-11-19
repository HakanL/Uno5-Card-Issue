using Microsoft.UI.Xaml.Input;

namespace UnoApp5
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Item_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Console.WriteLine($"Item tapped: {sender.GetType().Name}");
        }
    }
}
