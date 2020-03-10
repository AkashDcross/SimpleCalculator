using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Testing1;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SimpleCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<String> numbers = new List<String>();
        List<String> History = new List<String>();

        string joiner;
        int[] numholder;

        public MainPage()
        {
            //fixing font size for default window
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


        // ------------ Here we are concatenating joiner every time the user presses a number-----------
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


        private void timess(object sender, RoutedEventArgs e)
        {
            display.Items.Clear();
            numbers.Add("*");
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);
        }


        private void dividee(object sender, RoutedEventArgs e)
        {
            display.Items.Clear();
            numbers.Add("/");
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);
        }

        private void subtract(object sender, RoutedEventArgs e)
        {
            display.Items.Clear();
            numbers.Add("-");
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);
        }

        //-----------------------------------------------------------------------------------------


        private void equal(object sender, RoutedEventArgs e)
        {
            joiner = "";
            display.Items.Clear();

            String condition = "";

            string section1 = "";
            string section2 = "";
            double sum = 0;


            int counter = 0;
            String[] numberHolder1 = numbers.ToArray();

            //Here is a construct which uses 2 loops to get the first section and second section of the sum  ( 232323 + 123123)
            for (int i = 0; i < numberHolder1.Length; i++)


            {



                if (numberHolder1[i].Contains("+")|| numberHolder1[i].Contains("-")|| numberHolder1[i].Contains("/")|| numberHolder1[i].Contains("*"))
                {
                    condition = numberHolder1[i];

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
            {
                sum = Convert.ToInt32(section1) + Convert.ToInt32(section2);
                History.Add(section1 +condition+section2+"="+sum);

            }

            if (condition == "-")
            {
                sum = Convert.ToInt32(section1) - Convert.ToInt32(section2);
                History.Add(section1 + condition + section2 + "=" + sum);

            }

            if (condition == "*")
            {
                sum = Convert.ToInt32(section1) * Convert.ToInt32(section2);
                History.Add(section1 + condition + section2 + "=" + sum);

            }

            if (condition == "/")
            {
                sum = Convert.ToDouble(section1) / Convert.ToInt32(section2);
                History.Add(section1 + condition + section2 + "=" + sum);

            }



            display.Items.Add(section1 +condition+section2+"="+sum);


          //Add the history here



            //this code is not nessessary as there is a dedicated button to clear the list which is the clearjoiner()
            // clearing is required as the program does not progress from previously stored numbers.
            numbers.Clear();
            joiner = "";


        }

        private void clearJoiner(object sender, RoutedEventArgs e)
        {
            //clear button used to temporarily correct calculators from adding onto previous sums ( which created an error as this programs only operates with 2 numbers)

            numbers.Clear();
            joiner="";

            display.Items.Clear();

        }

        private void RandomSum(object sender, RoutedEventArgs e)
        {
            display.Items.Clear();
            Random ran = new Random();
            double randomNum;

            String[] operatators = {"+","-","/","*"};
            int ranSelector = (ran.Next(0,operatators.Length));
            String ranOperator = Convert.ToString(operatators[ranSelector]);

            


            for (int i=1; i <= 2; i++)
            {
                randomNum = ran.Next(0, 9);
                numbers.Add(randomNum.ToString());

                if (i == 1) { numbers.Add(ranOperator); }
            }


            
            
            joiner = string.Join("", numbers);
            display.Items.Add(joiner);
            equal(null,null);

        }
    }
}
