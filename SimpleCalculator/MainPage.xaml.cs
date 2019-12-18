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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SimpleCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<String> numbers = new List<String>();

        string joiner;
        int[] numholder;

        public MainPage()
        {
            this.InitializeComponent();
            display.FontSize = 40;
            num0.FontSize = 40;
            num1.FontSize = 40;
            num2.FontSize = 40;
            num3.FontSize = 40;
            num4.FontSize = 40;
            num5.FontSize = 40;
            num6.FontSize = 40;
            num7.FontSize = 40;
            num8.FontSize = 40;
            num8.FontSize = 40;
            num9.FontSize = 40;
            clear.FontSize = 40;
            add.FontSize = 40;
            minus.FontSize = 40;
            equals.FontSize = 40;
            divide.FontSize = 40; 
            times.FontSize = 40;
        }

        private void display0(object sender, RoutedEventArgs e)
        {
            display.Items.Clear();

            numbers.Add("0");
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);


        }

        private void display1(object sender, RoutedEventArgs e)
        {
            display.Items.Clear();
            numbers.Add("1");
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);
        }

        private void display2(object sender, RoutedEventArgs e)
        {
            display.Items.Clear();
            numbers.Add("2");
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);

        }

        private void display3(object sender, RoutedEventArgs e)
        {
            display.Items.Clear();
            numbers.Add("3");
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);
        }

        private void display4(object sender, RoutedEventArgs e)
        {

            display.Items.Clear();
            numbers.Add("4");
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);
        }

        private void display5(object sender, RoutedEventArgs e)
        {
            display.Items.Clear();
            numbers.Add("5");
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);

        }

        private void display6(object sender, RoutedEventArgs e)
        {
            display.Items.Clear();
            numbers.Add("6");
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);
        }

        private void display7(object sender, RoutedEventArgs e)
        {
            display.Items.Clear();
            numbers.Add("7");
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);
        }

        private void display8(object sender, RoutedEventArgs e)
        {
            display.Items.Clear();
            numbers.Add("8");
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);
        }

        private void display9(object sender, RoutedEventArgs e)
        {
            display.Items.Clear();
            numbers.Add("9");
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);
        }

        private void addnum(object sender, RoutedEventArgs e)
        {
            display.Items.Clear();
            numbers.Add("+");
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);
        }

        private void equal(object sender, RoutedEventArgs e)
        {
            joiner = "";
            display.Items.Clear();

            String condition = "";

            string section1 = "";
            string section2 = "";
            int sum = 0;


            int counter = 0;
            String[] numberHolder1 = numbers.ToArray();

            for (int i = 0; i < numberHolder1.Length; i++)


            {



                if (numberHolder1[i].Contains("+"))
                {
                    condition = "+";

                    for (int j = 0; j < counter; j++)
                    {
                        section1 += numberHolder1[j];

                    }



                    for (int k = counter + 1; k < numberHolder1.Length; k++)
                    {
                        section2 += numberHolder1[k];

                    }

                }



                counter++;

            }


            if (condition == "+")
                sum = Convert.ToInt32(section1) + Convert.ToInt32(section2);

            display.Items.Add(sum);


        }

        private void clearJoiner(object sender, RoutedEventArgs e)
        {


        }
    }
}
