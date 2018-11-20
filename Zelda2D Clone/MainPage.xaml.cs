using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.System;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Zelda2D_Clone
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }
        private void Clicked_Up(object sender, RoutedEventArgs e)
        {
            Player.Margin = new Thickness(Player.Margin.Left, Player.Margin.Top - 20.0, Player.Margin.Right, Player.Margin.Bottom - 20.0);
        }

        private void Clicked_Down(object sender, RoutedEventArgs e)
        {
            Player.Margin = new Thickness(Player.Margin.Left, Player.Margin.Top + 20.0, Player.Margin.Right, Player.Margin.Bottom + 20.0);
        }

        private void Clicked_Left(object sender, RoutedEventArgs e)
        {
            Player.Margin = new Thickness(Player.Margin.Left - 20.0, Player.Margin.Top, Player.Margin.Right - 20.0, Player.Margin.Bottom);
        }

        private void Clicked_Right(object sender, RoutedEventArgs e)
        {
            Player.Margin = new Thickness(Player.Margin.Left + 20.0, Player.Margin.Top, Player.Margin.Right + 20.0, Player.Margin.Bottom);
        }
    }
}
