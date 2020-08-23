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

namespace Lecture60_calculate
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int income = int.Parse(txt_income.Text);
            int spend = int.Parse(txt_spend.Text);
            int price = int.Parse(txt_price.Text);
            int balance = income - spend;
            int day = price / balance;

            if (income < spend)
            {
                MessageBox.Show("ไม่มีเงินเก็บ","ERROR");
            }
            else
            {
                txt_save_money.Text = ("คุณต้องเก็บเงิน "+ balance +" บาท "+" เป็นเวลา "+day+" วัน ");
            }

        }

        private void txt_income_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            txt_income.Clear();
            txt_price.Clear();
            txt_save_money.Clear();
            txt_spend.Clear();

        }
    }
}
