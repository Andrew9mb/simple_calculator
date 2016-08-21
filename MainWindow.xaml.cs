//Andrew Hunt
//Dr. Yoo
//Calculator App
//4/6/16

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

namespace calculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        char[] delimiterChars = { ' ' };
        bool equalPressed = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += "7";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += "4";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += "1";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += "8";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += "2";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += "9";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += "6";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += "3";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += ".";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += " / ";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += " * ";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += " - ";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += " + ";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            if (equalPressed == true)
            {
                InOut.Text = "";
                equalPressed = false;
            }
            InOut.Text += "0";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            InOut.Text = "";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            decimal outPut = 0;
            string myInput = InOut.Text;
            string[] words = myInput.Split(delimiterChars);
            string a = "";
            string b = "";
            
            for(int i = 0; i <words.Length; i++)
            {
                //if (words[0] != "*" | words[i] != "/" | words[i] != "+" | words[i] != "-")
                {
                    if (words[i] == "*")
                    {
                        a = words[i - 1];
                        b = words[i + 1];
                        outPut = Convert.ToDecimal(a) * Convert.ToDecimal(b);
                        words[i + 1] = Convert.ToString(outPut);
                    }

                    if (words[i] == "/")
                    {
                        a = words[i - 1];
                        b = words[i + 1];
                        outPut = Convert.ToDecimal(a) / Convert.ToDecimal(b);
                        words[i + 1] = Convert.ToString(outPut);
                    }

                    if (words[i] == "+")
                    {
                        a = words[i - 1];
                        b = words[i + 1];
                        outPut = Convert.ToDecimal(a) + Convert.ToDecimal(b);
                        words[i + 1] = Convert.ToString(outPut);
                    }

                    if (words[i] == "-")
                    {
                        a = words[i - 1];
                        b = words[i + 1];
                        outPut = Convert.ToDecimal(a) - Convert.ToDecimal(b);
                        words[i + 1] = Convert.ToString(outPut);
                    }
                }
            }
            InOut.Text = Convert.ToString(outPut);
            equalPressed = true;
        }

        
    }
}
