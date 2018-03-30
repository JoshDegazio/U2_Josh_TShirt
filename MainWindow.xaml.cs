/*Josh Degazio
 *March 29th, 2018
 *Program that allows users to design their own t-shirt.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U2_Josh_TShirt
{
    //Global Variables. Allows for global calling of variables.
    public static class Globals
    {
        public static int fontentered;
        //ts = TShirt
        public static string ts_Text;
        public static string ts_Colour;
        public static string ts_Location;

    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void click_Apply(object sender, RoutedEventArgs e)
        {
            ResetValues();
            SetValues();
            ApplyDetails();
        }

        private void ApplyDetails()
        {
            //Checks inputed location
            if (Globals.ts_Location == "Top")
            {
                txt_ShirtTop.Visibility = System.Windows.Visibility.Visible;
                txt_ShirtCenter.Visibility = System.Windows.Visibility.Hidden;
                txt_ShirtBottom.Visibility = System.Windows.Visibility.Hidden;
                txt_ShirtTop.Text = Globals.ts_Text;
                FontSet(txt_ShirtTop);
            }
            else if (Globals.ts_Location == "Bottom")
            {
                txt_ShirtTop.Visibility = System.Windows.Visibility.Hidden;
                txt_ShirtCenter.Visibility = System.Windows.Visibility.Hidden;
                txt_ShirtBottom.Visibility = System.Windows.Visibility.Visible;
                txt_ShirtBottom.Text = Globals.ts_Text;
                FontSet(txt_ShirtBottom);
            }
            else if (Globals.ts_Location == "Center")
            {
                txt_ShirtTop.Visibility = System.Windows.Visibility.Hidden;
                txt_ShirtBottom.Visibility = System.Windows.Visibility.Hidden;
                txt_ShirtCenter.Visibility = System.Windows.Visibility.Visible;
                txt_ShirtCenter.Text = Globals.ts_Text;
                FontSet(txt_ShirtCenter);
            }
            //Changes shirt color based upon inputed color
            Rect_Shirt.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(Globals.ts_Colour);
        }

        //Changes the font based on input
        private void FontSet(TextBlock textBlock)
        {
            if (Globals.fontentered == 1)
            {
                textBlock.FontFamily = new FontFamily("Times New Roman");
            }
            else if (Globals.fontentered == 2)
            {
                textBlock.FontFamily = new FontFamily("Comic Sans MS");
            }
            else if (Globals.fontentered == 3)
            {
                textBlock.FontFamily = new FontFamily("Arial");
            }
            else if (Globals.fontentered == 4)
            {
                textBlock.FontFamily = new FontFamily("Arial Black");
            }
            else if (Globals.fontentered == 5)
            {
                textBlock.FontFamily = new FontFamily("Helvetica");
            }
            else if (Globals.fontentered == 6)
            {
                textBlock.FontFamily = new FontFamily("Verdana");
            }
            else if (Globals.fontentered == 7)
            {
                textBlock.FontFamily = new FontFamily("Georgia");
            }
            else if (Globals.fontentered == 8)
            {
                textBlock.FontFamily = new FontFamily("Bookman");
            }
            else if (Globals.fontentered == 9)
            {
                textBlock.FontFamily = new FontFamily("Courier New");
            }
            else
            {
                textBlock.FontFamily = new FontFamily("Impact");
            }
        }

        //Resets Values.
        private static void ResetValues()
        {
            Globals.ts_Text = "";
            Globals.ts_Location = "";
            Globals.ts_Colour = "";
            Globals.fontentered = 0;
        }

        //Sets values to what was inputed.
        private void SetValues()
        {
            Globals.ts_Text = inpt_tshirttext.Text;
            Globals.ts_Location = inpt_tshirtlocation.Text;
            Globals.ts_Colour = inpt_tshirtcolour.Text;
            int.TryParse(inpt_tshirtfont.Text, out Globals.fontentered);
        }
    }
}
