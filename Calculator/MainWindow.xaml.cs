using org.mariuszgromada.math.mxparser;
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
//using Expression = org.mariuszgromada.math.mxparser.Expression;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            resultTxtBox.Text = "";
            this.Standard.Visibility = Visibility.Visible;
            this.Weight.Visibility = Visibility.Collapsed;
            this.Temperature.Visibility = Visibility.Collapsed;
            this.length.Visibility = Visibility.Collapsed;
            this.fileSize.Visibility = Visibility.Collapsed;
            this.time.Visibility = Visibility.Collapsed;
            this.Programmer.Visibility = Visibility.Collapsed;
        }

        private void Standard_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = "";
            this.Standard.Visibility = Visibility.Visible;
            this.Weight.Visibility = Visibility.Collapsed;
            this.Temperature.Visibility = Visibility.Collapsed;
            this.length.Visibility = Visibility.Collapsed;
            this.fileSize.Visibility = Visibility.Collapsed;
            this.time.Visibility = Visibility.Collapsed;
            this.Programmer.Visibility = Visibility.Collapsed;
        }

        private void Programmer_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = "";
            this.Standard.Visibility = Visibility.Collapsed;
            this.Weight.Visibility = Visibility.Collapsed;
            this.Temperature.Visibility = Visibility.Collapsed;
            this.length.Visibility = Visibility.Collapsed;
            this.fileSize.Visibility = Visibility.Collapsed;
            this.time.Visibility = Visibility.Collapsed;
            this.Programmer.Visibility = Visibility.Visible;
        }
        private void Weight_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = "";
            this.Standard.Visibility = Visibility.Collapsed;
            this.Weight.Visibility = Visibility.Visible;
            this.Temperature.Visibility = Visibility.Collapsed;
            this.length.Visibility = Visibility.Collapsed;
            this.fileSize.Visibility = Visibility.Collapsed;
            this.time.Visibility = Visibility.Collapsed;
            this.Programmer.Visibility = Visibility.Collapsed;
        }

        private void Temperature_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = "";
            this.Standard.Visibility = Visibility.Collapsed;
            this.Weight.Visibility = Visibility.Collapsed;
            this.Temperature.Visibility = Visibility.Visible;
            this.length.Visibility = Visibility.Collapsed;
            this.fileSize.Visibility = Visibility.Collapsed;
            this.time.Visibility = Visibility.Collapsed;
            this.Programmer.Visibility = Visibility.Collapsed;
        }

        private void Length_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = "";
            this.Standard.Visibility = Visibility.Collapsed;
            this.Weight.Visibility = Visibility.Collapsed;
            this.Temperature.Visibility = Visibility.Collapsed;
            this.length.Visibility = Visibility.Visible;
            this.fileSize.Visibility = Visibility.Collapsed;
            this.time.Visibility = Visibility.Collapsed;
            this.Programmer.Visibility = Visibility.Collapsed;
        }

        private void FileSize_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = "";
            this.Standard.Visibility = Visibility.Collapsed;
            this.Weight.Visibility = Visibility.Collapsed;
            this.Temperature.Visibility = Visibility.Collapsed;
            this.length.Visibility = Visibility.Collapsed;
            this.fileSize.Visibility = Visibility.Visible;
            this.time.Visibility = Visibility.Collapsed;
            this.Programmer.Visibility = Visibility.Collapsed;
        }

        private void Time_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = "";
            this.Standard.Visibility = Visibility.Collapsed;
            this.Weight.Visibility = Visibility.Collapsed;
            this.Temperature.Visibility = Visibility.Collapsed;
            this.length.Visibility = Visibility.Collapsed;
            this.fileSize.Visibility = Visibility.Collapsed;
            this.time.Visibility = Visibility.Visible;
            this.Programmer.Visibility = Visibility.Collapsed;
        }

        private double total1 = 0;
        private double total2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool divideButtonClicked = false;
        bool modulusButtonClicked = false;
        bool powerButtonClicked = false;
        bool factorialButtonClicked = false;
        bool squareButtonClicked = false;
        //bool proButtonClicked = false;


        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "0";
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "1";
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "2";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "3";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "4";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "5";
        }

        //MESSED UP BUTTON *** button9 == btn6 
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "6";
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "7";
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "8";

        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "9";
        }
        private void BtnNegative_Click(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text == "-" || resultTxtBox.Text != "")
            {
                return;
            }
            resultTxtBox.Text = resultTxtBox.Text + "-";
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text != "")
            {
                total1 = total1 += double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = "";

                plusButtonClicked = true;
                minusButtonClicked = false;
                multiplyButtonClicked = false;
                divideButtonClicked = false;
                modulusButtonClicked = false;
                powerButtonClicked = false;
                factorialButtonClicked = false;
                squareButtonClicked = false;
            }
        }
        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text != "")
            {
                total1 = total1 + double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = "";

                plusButtonClicked = false;
                minusButtonClicked = true;
                multiplyButtonClicked = false;
                divideButtonClicked = false;
                modulusButtonClicked = false;
                powerButtonClicked = false;
                factorialButtonClicked = false;
                squareButtonClicked = false;
            }
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text != "")
            {
                total1 = total1 + double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = "";

                plusButtonClicked = false;
                minusButtonClicked = false;
                multiplyButtonClicked = true;
                divideButtonClicked = false;
                modulusButtonClicked = false;
                powerButtonClicked = false;
                factorialButtonClicked = false;
                squareButtonClicked = false;
            }
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text != "")
            {
                total1 = total1 + double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = "";

                plusButtonClicked = false;
                minusButtonClicked = false;
                multiplyButtonClicked = false;
                divideButtonClicked = true;
                modulusButtonClicked = false;
                powerButtonClicked = false;
                factorialButtonClicked = false;
                squareButtonClicked = false;
            }
        }

        private void BtnMod_Click(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text != "")
            {
                total1 = total1 + double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = "";

                plusButtonClicked = false;
                minusButtonClicked = false;
                multiplyButtonClicked = false;
                divideButtonClicked = false;
                modulusButtonClicked = true;
                powerButtonClicked = false;
                factorialButtonClicked = false;
                squareButtonClicked = false;
            }
        }

        private void BtnPower_Click(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text != "")
            {
                total1 = total1 + double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = "";

                plusButtonClicked = false;
                minusButtonClicked = false;
                multiplyButtonClicked = false;
                divideButtonClicked = false;
                modulusButtonClicked = false;
                powerButtonClicked = true;
                factorialButtonClicked = false;
                squareButtonClicked = false;
            }
        }

        private void BtnFactorial_Click(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text != "")
            {
                total1 = total1 + double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = "";

                plusButtonClicked = false;
                minusButtonClicked = false;
                multiplyButtonClicked = false;
                divideButtonClicked = false;
                modulusButtonClicked = false;
                powerButtonClicked = false;
                factorialButtonClicked = true;
                squareButtonClicked = false;
            }
        }

        private void BtnSquare_Click(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text != "")
            {
                total1 = total1 + double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = "";

                plusButtonClicked = false;
                minusButtonClicked = false;
                multiplyButtonClicked = false;
                divideButtonClicked = false;
                modulusButtonClicked = false;
                powerButtonClicked = false;
                factorialButtonClicked = false;
                squareButtonClicked = true;
            }
        }

        private void BtnProgrammer_Click(object sender, RoutedEventArgs e)
        {
            total1 = 0;
            if (resultTxtBox.Text == "")
            {
                LastResultTxtBox.Text = "Please input correct number!";
                return;
            }
            total1 = total1 + double.Parse(resultTxtBox.Text);
            resultTxtBox.Text = "";

            var hexadecimal = int.Parse(total1.ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
            var binary = Convert.ToString(Convert.ToInt32(total1), 2);
            var octal = Convert.ToString(Convert.ToInt32(total1), 10);
            var integer = total1.ToString();
            ProgrammerResultTxtBox.Text = $"Integer:{integer} Hexadecimal:{hexadecimal}\nBinary:{binary} Octal:{octal}";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmButton") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }
        private void BtnPercent_Click(object sender, RoutedEventArgs e)
        {
            if (resultTxtBox.Text != "")
            {
                if (resultTxtBox.Text.Substring(resultTxtBox.Text.Length - 1) == "%")
                {
                    var data = double.Parse(resultTxtBox.Text.Remove(resultTxtBox.Text.Length - 1));
                    resultTxtBox.Text = "";
                    var result = double.Parse(data.ToString()) / 100;
                    resultTxtBox.Text = result.ToString();
                }
                else
                {
                    total1 = total1 + double.Parse(resultTxtBox.Text);
                    resultTxtBox.Text = "";
                    resultTxtBox.Text = total1.ToString("0.0%");
                }
            }
        }

        private void BtnWeight_Click(object sender, RoutedEventArgs e)
        {

            total1 = total1 + double.Parse(resultTxtBox.Text);
            resultTxtBox.Text = "";
        }
        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            if (plusButtonClicked == true)
            {
                total2 = total1 + double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = total2.ToString();
                total1 = 0;
            }
            else if (minusButtonClicked == true)
            {
                total2 = total1 - double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = total2.ToString();
                total1 = 0;
            }
            else if (multiplyButtonClicked == true)
            {
                total2 = total1 * double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = total2.ToString();
                total1 = 0;
            }
            else if (divideButtonClicked == true)
            {
                total2 = total1 / double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = total2.ToString();
                total1 = 0;
            }
            else if (modulusButtonClicked == true)
            {
                var num2 = resultTxtBox.Text;
                if (num2 != "")
                {
                    total2 = total1 % double.Parse(num2);
                    resultTxtBox.Text = total2.ToString();
                    total1 = 0;
                }
            }
            else if (powerButtonClicked == true)
            {
                var num2 = resultTxtBox.Text;
                if (num2 != "")
                {
                    total2 = Math.Pow(double.Parse(total1.ToString()), double.Parse(num2.ToString()));
                    resultTxtBox.Text = total2.ToString();
                    total1 = 0;
                }
            }
            else if (factorialButtonClicked == true)
            {
                long num = 1;
                for (long i = 1; i <= long.Parse(total1.ToString()); i++)
                {
                    num = num * i;
                }
                resultTxtBox.Text = num.ToString();
                total1 = 0;
            }
            else if (squareButtonClicked == true)
            {
                resultTxtBox.Text = Math.Sqrt(double.Parse(total1.ToString())).ToString();
                total1 = 0;
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = "";
            total1 = 0;
        }

        private void BtnDecimalPoint_Click(object sender, RoutedEventArgs e)
        {

            resultTxtBox.Text = resultTxtBox.Text + ".";
        }

        private void WeightComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double milligram = 0, gram = 0, kilogram = 0, ounce = 0, pound = 0;
            total1 = 0;
            ComboBoxItem typeItem = (ComboBoxItem)WeightComboBox.SelectedItem;
            if (typeItem.Content == null)
            {
                return;
            }
            string value = typeItem.Content.ToString();
            if (resultTxtBox.Text == "")
            {
                LastResultTxtBox.Text = "Please input correct number!";
                return;
            }
            total1 = total1 + double.Parse(resultTxtBox.Text);
            if (value == "---Choice Origin Unit---")
            {
                return;
            }
            if (value == "milligrams")
            {
                milligram = double.Parse(total1.ToString());
                gram = 0.001 * milligram;
                kilogram = 0.000001 * gram;
                ounce = 28.3495231 * gram;
                pound = 0.45359237 * kilogram;
            }
            if (value == "grams")
            {
                gram = double.Parse(total1.ToString());
                milligram = 1000 * gram;
                kilogram = 0.001 * gram;
                ounce = 28.3495231 * gram;
                pound = 0.45359237 * kilogram;
            }

            if (value == "kilograms")
            {
                kilogram = double.Parse(total1.ToString());
                gram = 1000 * kilogram;
                milligram = 1000 * gram;
                ounce = 28.3495231 * gram;
                pound = 0.45359237 * kilogram;
            }

            if (value == "ounces")
            {
                ounce = double.Parse(total1.ToString());
                gram = ounce / 28.3495231;
                milligram = 1000 * gram;
                kilogram = gram / 1000;
                pound = 0.45359237 * kilogram;
            }
            if (value == "pounds")
            {
                pound = double.Parse(total1.ToString());
                kilogram = pound / 0.45359237;
                gram = kilogram / 1000;
                ounce = 28.3495231 * gram;
                milligram = 1000 * gram;
            }
            LastResultTxtBox.Text = $" Milligram: {milligram.ToString()} Gram: {gram.ToString()}\nKilogram: {kilogram.ToString()} Ounce: {ounce.ToString()}\n Pound: {pound.ToString()}";
        }

        private void Temperature_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            total1 = 0;
            double celsius = 0, fahrenheit = 0;
            ComboBoxItem typeItem = (ComboBoxItem)temperatureComboBox.SelectedItem;
            if (typeItem.Content == null)
            {
                return;
            }
            string value = typeItem.Content.ToString();
            if (resultTxtBox.Text == "")
            {
                LastResultTxtBox.Text = "Please input correct number!";
                return;
            }
            total1 = total1 + double.Parse(resultTxtBox.Text);

            if (value == "---Choice Origin Unit---")
            {
                return;
            }
            if (value == "Celsius")
            {
                celsius = double.Parse(total1.ToString());
                fahrenheit = (celsius * 9) / 5 + 32;
            }
            if (value == "Fahrenheits")
            {
                fahrenheit = double.Parse(total1.ToString());
                celsius = (fahrenheit - 32) * 5 / 9;
            }
            temperatureResultTxtBox.Text = $"Celsius:{celsius.ToString()} Fahrenheits:{fahrenheit.ToString()}";
        }

        private void Length_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            total1 = 0;
            double millimetres = 0, centimeters = 0, meters = 0, kilometers = 0, inches = 0, feet = 0;
            ComboBoxItem typeItem = (ComboBoxItem)lengthComboBox.SelectedItem;
            if (typeItem.Content == null)
            {
                return;
            }
            string value = typeItem.Content.ToString();
            if (resultTxtBox.Text == "")
            {
                LastResultTxtBox.Text = "Please input correct number!";
                return;
            }
            total1 = total1 + double.Parse(resultTxtBox.Text);

            if (value == "---Choice Origin Unit---")
            {
                return;
            }
            if (value == "millimetres")
            {
                millimetres = double.Parse(total1.ToString());
                centimeters = 0.1 * millimetres;
                meters = 0.001 * centimeters;
                kilometers = 0.001 * meters;
                inches = 2.54 * centimeters;
                feet = 30.48 * centimeters;
            }
            if (value == "centimeters")
            {
                centimeters = double.Parse(total1.ToString());
                millimetres = 10 * centimeters;
                meters = 0.001 * centimeters;
                kilometers = 0.001 * meters;
                inches = 2.54 * centimeters;
                feet = 30.48 * centimeters;
            }
            if (value == "meters")
            {
                meters = double.Parse(total1.ToString());
                centimeters = 100 * meters;
                millimetres = 10 * centimeters;
                kilometers = 0.001 * meters;
                inches = 2.54 * centimeters;
                feet = 30.48 * centimeters;
            }

            if (value == "kilometers")
            {
                kilometers = double.Parse(total1.ToString());
                meters = 1000 * kilometers;
                centimeters = 100 * meters;
                millimetres = 10 * centimeters;
                inches = 2.54 * centimeters;
                feet = 30.48 * centimeters;
            }
            if (value == "inches")
            {
                inches = double.Parse(total1.ToString());
                centimeters = inches / 2.54;
                meters = 0.01 * centimeters;
                kilometers = 0.001 * meters;
                millimetres = 10 * centimeters;
                feet = 30.48 * centimeters;
            }

            if (value == "feet")
            {
                feet = double.Parse(total1.ToString());
                centimeters = feet / 30.48;
                meters = 0.01 * centimeters;
                kilometers = 0.001 * meters;
                millimetres = 10 * centimeters;
                inches = 2.54 * centimeters;
            }
            lengthResultTxtBox.Text = $"Millimetres:{millimetres.ToString("G")} Centimeters:{centimeters.ToString("G")}\nMeters:{meters.ToString("G")} Kilometers:{kilometers.ToString("G")}\n Inches:{inches.ToString("G")} Feet:{feet.ToString("G")}";
        }

        private void FileSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            total1 = 0;
            double bytes = 0, kilobytes = 0, megabytes = 0, gigabytes = 0, terabytes = 0;
            ComboBoxItem typeItem = (ComboBoxItem)fileSizeComboBox.SelectedItem;
            if (typeItem.Content == null)
            {
                return;
            }
            string value = typeItem.Content.ToString();
            if (resultTxtBox.Text == "")
            {
                LastResultTxtBox.Text = "Please input correct number!";
                return;
            }
            total1 = total1 + double.Parse(resultTxtBox.Text);

            if (value == "---Choice Origin Unit---")
            {
                return;
            }
            if (value == "bytes")
            {
                bytes = double.Parse(total1.ToString());
                kilobytes = bytes / 1024;
                megabytes = kilobytes / 1024;
                gigabytes = megabytes / 1024;
                terabytes = gigabytes / 1024;
            }

            if (value == "kilobytes")
            {
                kilobytes = double.Parse(total1.ToString());
                bytes = kilobytes * 1024;
                megabytes = kilobytes / 1024;
                gigabytes = megabytes / 1024;
                terabytes = gigabytes / 1024;
            }

            if (value == "megabytes")
            {
                megabytes = double.Parse(total1.ToString());
                kilobytes = megabytes * 1024;
                bytes = kilobytes * 1024;
                gigabytes = megabytes / 1024;
                terabytes = gigabytes / 1024;
            }

            if (value == "gigabytes")
            {
                gigabytes = double.Parse(total1.ToString());
                megabytes = gigabytes * 1024;
                kilobytes = megabytes * 1024;
                bytes = kilobytes * 1024;
                terabytes = gigabytes / 1024;
            }


            if (value == "terabytes")
            {
                terabytes = double.Parse(total1.ToString());
                gigabytes = terabytes * 1024;
                megabytes = gigabytes * 1024;
                kilobytes = megabytes * 1024;
                bytes = kilobytes * 1024;
            }
            fileSizeResultTxtBox.Text = $"Bytes:{bytes.ToString()} Kilobytes:{kilobytes.ToString()}\nMegabytes:{megabytes.ToString()} Gigabytes:{gigabytes.ToString()}\n Terabytes:{terabytes.ToString()}";
        }

        private void Time_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            total1 = 0;
            double hours = 0, minutes = 0, seconds = 0;
            ComboBoxItem typeItem = (ComboBoxItem)timeComboBox.SelectedItem;
            if (typeItem.Content == null)
            {
                return;
            }
            string value = typeItem.Content.ToString();
            if (resultTxtBox.Text == "")
            {
                LastResultTxtBox.Text = "Please input correct number!";
                return;
            }
            total1 = total1 + double.Parse(resultTxtBox.Text);

            if (value == "---Choice Origin Unit---")
            {
                return;
            }
            if (value == "hours")
            {
                hours = double.Parse(total1.ToString());
                minutes = 60 * hours;
                seconds = 60 * minutes;
            }
            if (value == "minutes")
            {
                minutes = double.Parse(total1.ToString());
                hours = minutes / 60;
                seconds = 60 * minutes;
            }
            if (value == "seconds")
            {
                seconds = double.Parse(total1.ToString());
                minutes = seconds / 60;
                hours = minutes / 60;
            }
            timeResultTxtBox.Text = $"Hours:{hours.ToString()} Minutes:{minutes.ToString()}\nSeconds:{seconds.ToString()}";
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            int i = resultTxtBox.Text.Length;
            resultTxtBox.Text = resultTxtBox.Text.Substring(0, i - 1);
        }


    }
}

