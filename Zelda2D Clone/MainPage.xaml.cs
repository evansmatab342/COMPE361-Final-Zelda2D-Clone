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
using Zelda2D_Clone.Levels_and_Movement;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Zelda2D_Clone
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        /* The following "Clicked_YY" methods are used for moving the player. 
         * There are four buttons, one for each method in the MainPage.xaml
         * The current iteration for moving the player changes the margins of an image each time a "Clicked_YY" method is clicked. 
         * Margin is of type Thickness so we call a new Thickness constructor. The margin is constructed from a "Top," a "Bottom," a "Left," and a "Right."
         * We change the value of these to change where an image is located.
         * 
         * Bugs:
         *      11/20/2018
         *      - The image disappears when moving "out of range." Unsure what the range is. 
         *          Doesn't seem to be the window area as it disappears before reaching the end of the screen.
         *      - At some point, when positioned at an arbritrary point on the grid, the "Up" and "Down" buttons stoppped working.
         *          Have not gotten this bug to occur after repositioning the image.
         */
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

        /* 11/20/2018
         * The method  below, "keyPressed," does the same as the code above but does it through keyboard inputs instead of clicking buttons. 
         * Bugs:
         *      -Same as above. 
         *      -Currently trying to make this work without having to add the TextBox control but it appears there is a "Focus" problem.
         *          Tried adding the event to the image(the player, Link) but it is never called because the image is never "in Focus."
         *          The TextBox is a temporary solution as it is easy to bring it into focus by simply clickig on it. 
         */
        private void keyPressed(object sender, KeyRoutedEventArgs e)
        {
            switch (e.Key)  //Holds a VirtualKey type that specifies which key was pressed when the event is called.
            {
                case VirtualKey.A:
                    Player.Margin = new Thickness(Player.Margin.Left - 20.0, Player.Margin.Top, Player.Margin.Right - 20.0, Player.Margin.Bottom);
                    break;
                case VirtualKey.W:
                    Player.Margin = new Thickness(Player.Margin.Left, Player.Margin.Top - 20.0, Player.Margin.Right, Player.Margin.Bottom - 20.0);
                    break;
                case VirtualKey.S:
                    Player.Margin = new Thickness(Player.Margin.Left, Player.Margin.Top + 20.0, Player.Margin.Right, Player.Margin.Bottom + 20.0);
                    break;
                case VirtualKey.D:
                    Player.Margin = new Thickness(Player.Margin.Left + 20.0, Player.Margin.Top, Player.Margin.Right + 20.0, Player.Margin.Bottom);
                    break;
            }
        }
    }
}
