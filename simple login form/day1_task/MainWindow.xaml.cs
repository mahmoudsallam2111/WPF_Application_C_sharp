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

namespace day1_task
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

        private void ok_btn(object sender, RoutedEventArgs e)
        {
          MessageBoxResult mr =  MessageBox.Show($" welcome \n {fn_txt.Text} {ln_txt.Text} your gender :{gender_txt.Text} && your address {add_txt.Text} phone number : {phone_txt.Text} && mobile number : {mobile_txt.Text} && email{em_txt.Text} && job title{jt_txt.Text}" 
                ,"info message",MessageBoxButton.YesNo,MessageBoxImage.Information);
            if (mr==MessageBoxResult.Yes)
            {
                MessageBox.Show("your data is saved", "info");
            }
            else
            {
                MessageBox.Show("your data is not saved saved", "info");
                form.Close();
            }
        }

        private void cancle_btn(object sender, RoutedEventArgs e)
        {
          MessageBoxResult res =   MessageBox.Show("are u sure you want to cancle!!", "warning" , MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (res==MessageBoxResult.Yes)
            {
                form.Close();

            }
            else
            {
                fn_txt.Clear();
                ln_txt.Clear();
                add_txt.Clear();
                gender_txt.Clear();
                em_txt.Clear();
                phone_txt.Clear();
                mobile_txt.Clear();
                jt_txt.Clear();
                fn_txt.Focus();

            }
           
            
        }

    }
}
