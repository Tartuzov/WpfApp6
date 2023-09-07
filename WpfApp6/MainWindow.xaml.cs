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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<double> list = new List<double>();
        List<string> list1 = new List<string>();
        double rez = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NowEx.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AllEx.Clear();
            NowEx.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (NowEx.Text.Length > 0)
            {
                NowEx.Text = NowEx.Text.Remove(NowEx.Text.Length - 1);
                if (NowEx.Text.Length == 0)
                    NowEx.Text = "0";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (NowEx.Text.Length == 1 && NowEx.Text[0] == '0')
                NowEx.Text = "7";
            else
                NowEx.Text += "7";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (NowEx.Text.Length == 1 && NowEx.Text[0] == '0')
                NowEx.Text = "8";
            else
                NowEx.Text += "8";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (NowEx.Text.Length == 1 && NowEx.Text[0] == '0')
                NowEx.Text = "9";
            else
                NowEx.Text += "9";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (NowEx.Text.Length == 1 && NowEx.Text[0] == '0')
                NowEx.Text = "4";
            else
                NowEx.Text += "4";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (NowEx.Text.Length == 1 && NowEx.Text[0] == '0')
                NowEx.Text = "5";
            else
                NowEx.Text += "5";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (NowEx.Text.Length == 1 && NowEx.Text[0] == '0')
                NowEx.Text = "6";
            else
                NowEx.Text += "6";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (NowEx.Text.Length == 1 && NowEx.Text[0] == '0')
                NowEx.Text = "1";
            else
                NowEx.Text += "1";
        }
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (NowEx.Text.Length == 1 && NowEx.Text[0] == '0')
                NowEx.Text = "2";
            else
                NowEx.Text += "2";
        }
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if(NowEx.Text.Length == 1 && NowEx.Text[0]=='0')
                NowEx.Text = "3";
            else
                NowEx.Text+="3";
        }
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if(NowEx.Text.Length!=0)
            NowEx.Text += ",";
        }
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            NowEx.Text += "0";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            AllEx.Text += NowEx.Text+" /";
            list.Add(double.Parse(NowEx.Text));
            list1.Add("/");
            NowEx.Clear();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            AllEx.Text += NowEx.Text + " *";
            list.Add(double.Parse(NowEx.Text));
            list1.Add("*");
            NowEx.Clear();
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            AllEx.Text += NowEx.Text + " -";
            list.Add(double.Parse(NowEx.Text));
            list1.Add("-");
            NowEx.Clear();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            AllEx.Text += NowEx.Text + " +";
            list.Add(double.Parse(NowEx.Text));
            list1.Add("+");
            NowEx.Clear();
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            list.Add(double.Parse(NowEx.Text));
            AllEx.Text +=" " +NowEx.Text + " = ";
            AllEx.Clear();
            NowEx.Clear();
            for (int i = 1,j=0; i < list.Count; i++)
            {
                if (list1[j] == "/")
                {
                    if (list[i] == 0)
                        MessageBox.Show("EROR!");
                    else
                    {
                        rez+=list[i-1] / list[i];
                        j++;
                    }
                }
                else if (list1[j] == "*")
                {
                        rez += list[i-1] * list[i];
                        j++;
                }
                else if (list1[j] == "-")
                {
                        rez += list[i - 1] - list[i];
                        j++;
                }
                else if (list1[j] == "+")
                {
                        rez += list[i-1] + list[i];
                        j++;
                }
            }
            NowEx.Text=rez.ToString();
            list.Clear();
            list1.Clear();
            rez = 0;
        }
    }
}
