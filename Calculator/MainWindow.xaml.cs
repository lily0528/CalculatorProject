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

        //private void Grid_Initialized(object sender, EventArgs e)
        //{ }

             private double total1 = 0;
        private double total2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool divideButtonClicked = false;


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

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 += double.Parse(resultTxtBox.Text);
            resultTxtBox.Text = "";

            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }
        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 + double.Parse(resultTxtBox.Text);
            resultTxtBox.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 + double.Parse(resultTxtBox.Text);
            resultTxtBox.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = true;
            divideButtonClicked = false;
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 + double.Parse(resultTxtBox.Text);
            resultTxtBox.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = true;
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
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = "";
        }

        private void btnDecimalPoint_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = ".";
        }


    }
}
