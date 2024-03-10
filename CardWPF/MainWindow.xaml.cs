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

namespace CardWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   public List<string> monthtxt=new List<string>() { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
        public List<string> yaertxt = new List<string>() { "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };
       
        public MainWindow()
        {
            InitializeComponent();
            datecbx.ItemsSource = monthtxt;
            datecbx.SelectedIndex = 0;
            monthcbx.ItemsSource = yaertxt;
            monthcbx.SelectedIndex = 0;
            

        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void tbcardxpnl_TextChanged(object sender, TextChangedEventArgs e)
        {
            int count =tbcardxpnl.Text.Length;
            if(count<5) { num1.Text = tbcardxpnl.Text; }
            if (count > 4 && count < 9) { num2.Text = tbcardxpnl.Text.Substring(4); }
            if (count > 8 && count < 13) { num3.Text = tbcardxpnl.Text.Substring(8); }
            if (count > 12 && count < 17) { num4.Text = tbcardxpnl.Text.Substring(12); }
        }

        private void tbholderxpnl_TextChanged(object sender, TextChangedEventArgs e)
        {
            cardholder.Text = tbholderxpnl.Text;
        }

        private void datecbx_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void datecbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string mon = monyearcard.Text;
            monyearcard.Text = datecbx.SelectedValue.ToString()+ mon.Remove(0,2);
        }

        private void monthcbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string mon = monyearcard.Text;
            monyearcard.Text = monyearcard.Text.Remove(3,2) + monthcbx.SelectedValue.ToString();
        }
    }
}
