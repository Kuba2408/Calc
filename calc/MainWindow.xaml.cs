using System.Text;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string value = "0";
        private static string result = "0";
        bool pow = false;
        bool plus = false;
        bool minus = false;
        bool multiplication = false;
        bool division = false; 
        bool dividingByZero = false;
        public MainWindow()
        {
            InitializeComponent();
            Value.Text = value;
        }

        private void Equal(object sender, RoutedEventArgs e)
        {
            value = End(value); 
            Double math = 0;
            if (pow)
            {
                pow = false;
                math = Math.Pow(Double.Parse(result), Double.Parse(value));               
            }
            else if (plus)
            {
                plus = false;
                math = Double.Parse(result) + Double.Parse(value);
            }
            else if (minus)
            {
                    minus = false;
                    math = Double.Parse(result) - Double.Parse(value);
            }
            else if (multiplication) 
            {
                multiplication = false;
                math = Double.Parse(result) * Double.Parse(value);
            }
            else if (division) 
            {
                dividingByZero = false;
                if (value == "0")
                {
                    MessageBox.Show("NIE MOŻNA DZIELIĆ PRZEZ 0");
                    dividingByZero = true;
                    
                }
                else
                {
                    division = false;
                    math = Double.Parse(result) / Double.Parse(value);
                }
            }
            if (math != 0)
            {
                value = math.ToString();
            }
            if (!dividingByZero)
            {
                result = value;
                Value.Text = value;
                Result.Text = result;
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            if (value == "0")
            {
                result = "0";
                Result.Text = result;
                pow = false;
                plus= false;
                minus = false;
                multiplication = false;
                division = false;
            }
            else
            {
                value = "0";
                Value.Text = value;
            }
            
        }
        private void SignChange(object sender, RoutedEventArgs e)
        {
            value = End(value);
            Double math1 = Double.Parse(value);
            math1 = math1 * -1;           
            value = math1.ToString();
            Value.Text = value;
            
        }
        private void Sqrt(object sender, RoutedEventArgs e)
        {
            value = End(value);
            Double math1 = Math.Sqrt(Double.Parse(value));
            value = math1.ToString();
            Value.Text = value;
        }
        private void Bcksp(object sender, RoutedEventArgs e)
        {
            if (value.Length > 1)
            {
                value = value.Substring(0, value.Length - 1);
                Value.Text = value;
            }
            else if (value.Length <= 1)
            {
                value = "0";
                Value.Text = value;
            }
            }
        private void Square(object sender, RoutedEventArgs e)
        {
            value = End(value);
            Double math1 = Math.Pow(Double.Parse(value), 2);
            value = math1.ToString();
            Value.Text = value;
        }
        private void Power(object sender, RoutedEventArgs e)
        {
            value = End(value);
            if (!pow && !plus && !minus && !multiplication && !division) {
                pow = true;
                result = value;
                Result.Text = result+"^";
                value = "0";
                Value.Text = value;
                    }
        }
        private void Factorial(object sender, RoutedEventArgs e)
        {
            value = End(value);
            long math1 = 0;
            long math2 = 0;
            if (long.TryParse(value, out math1)) {  
                math2 = math1;
                for (long i = math1 - 1; i > 0; i--)
                {
                    math2 *= i;
                }
                value = math2.ToString();
                Value.Text = value;
            } else
            {
                MessageBox.Show("Silnia działa tylko na liczbach całkowitych");
            }
        }
        private void Multiplication(object sender, RoutedEventArgs e)
        {
            if (!pow && !plus && !minus && !multiplication && !division)
            {
                value = End(value);
                multiplication = true;
                result = value;
                Result.Text = result + "*";
                value = "0";
                Value.Text = value;
            }
        }
        private void Num1(object sender, RoutedEventArgs e)
        {
            if (value == "0")
            {
                value = "1";
            }
            else
            {
                value += "1";
            }
            Value.Text = value;
        }
        private void Num2(object sender, RoutedEventArgs e)
        {
            if (value == "0")
            {
                value = "2";
            }
            else
            {
                value += "2";
            }
            Value.Text = value;
        }
        private void Num3(object sender, RoutedEventArgs e)
        {
            if (value == "0")
            {
                value = "3";
            }
            else
            {
                value += "3";
            }
            Value.Text = value;
        }
        private void Division(object sender, RoutedEventArgs e)
        {
            if (!pow && !plus && !minus && !multiplication && !division)
            {
                value = End(value);
                division = true;
                result = value;
                Result.Text = result + "/";
                value = "0";
                Value.Text = value;
            }
        }
        private void Num4(object sender, RoutedEventArgs e)
        {
            if (value == "0")
            {
                value = "4";
            }
            else
            {
                value += "4";
            }
            Value.Text = value;
        }
        private void Num5(object sender, RoutedEventArgs e)
        {
            if (value == "0")
            {
                value = "5";
            }
            else
            {
                value += "5";
            }
            Value.Text = value;
        }
        private void Num6(object sender, RoutedEventArgs e)
        {
            if (value == "0")
            {
                value = "6";
            }
            else
            {
                value += "6";
            }
            Value.Text = value;
        }
        private void Minus(object sender, RoutedEventArgs e)
        {
            if (!pow && !plus && !minus && !multiplication && !division)
            {
                value = End(value);
                minus = true;
                result = value;
                Result.Text = result + "-";
                value = "0";
                Value.Text = value;
            }
        }
        private void Num7(object sender, RoutedEventArgs e)
        {
            if (value == "0")
            {
                value = "7";
            }
            else
            {
                value += "7";
            }
            Value.Text = value;
        }
        private void Num8(object sender, RoutedEventArgs e)
        {
            if (value == "0")
            {
                value = "8";
            }
            else
            {
                value += "8";
            }
            Value.Text = value;
        }
        private void Num9(object sender, RoutedEventArgs e)
        {
            if (value == "0")
            {
                value = "9";
            }
            else
            {
                value += "9";
            }
            Value.Text = value;
        }
        private void Plus(object sender, RoutedEventArgs e)
        {
            if (!pow && !plus && !minus && !multiplication && !division)
            {
                value = End(value);
                plus = true;
                result = value;
                Result.Text = result + "+";
                value = "0";
                Value.Text = value;
            }
        }
        private void Num0(object sender, RoutedEventArgs e)
        {
            if (value == "0")
            {
                value = "0";
            }
            else
            {
                value += "0";
            }
            Value.Text = value;
        }
        private void Comma(object sender, RoutedEventArgs e)
        {
            if (!value.Contains(','))
            {
                value += ",";
                Value.Text = value;
            }
        }
        private void Percentage(object sender, RoutedEventArgs e)
        {
            value = End(value);
            Double math1 = Double.Parse(value);
            math1 /= 100;
            value = math1.ToString(); 
            Value.Text = value;
        }
        private string End (string input)
        {
            if (input.EndsWith(","))
            {
                input += "0";
            }
            return input;
        }
    }
}