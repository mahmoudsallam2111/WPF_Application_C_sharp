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

namespace notepad_task
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

        public int flag { get; set; }
        private void change_mode(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Editable":
                    flag= 1;
                    break;

                case "Readonly":
                    flag = 2;
                    break;

            }

        }

        private void set_txt_btn(object sender, RoutedEventArgs e)
        {
            if (flag==1)
            {
                txt_box.Text = "Replace default text with initial text value";
            }
            
        }

        private void clr_btn_Click(object sender, RoutedEventArgs e)
        {
            if (flag==1)
            {
                txt_box.Clear();

            }
            
        }

        private void select_btn_Click(object sender, RoutedEventArgs e)
        {
            if (flag == 1)
            {
                if (txt_box.SelectionLength == 0)
                {
                    txt_box.SelectAll();

                }
                
            }


        }

        private void prepend_btn_Click(object sender, RoutedEventArgs e)
        {
            if (flag==1)
            {

                txt_box.AppendText("****hello from append");

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (flag == 1)
            {

                string temp = txt_box.Text;
                txt_box.Clear();
                txt_box.Text = $"***Prepended text * ** {temp}";

            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (flag==1)
            {
                string temp = txt_box.Text;
                txt_box.Clear();
                txt_box.Text = $"***inserted  text * ** {temp}";

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (flag==1)
            {
                if (txt_box.SelectedText.Length > 0)
                {
                    Clipboard.SetText(txt_box.Text);
                    txt_box.Cut();
                    MessageBox.Show($"Cut : {Clipboard.GetText()}", "Cut txt");
                }
                else
                {
                    MessageBox.Show("you must select txt", "warning" );
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (flag==1)
            {
                txt_box.Paste();

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (flag==1)
            {
                txt_box.Undo();
            }
        }

        private void btn_style(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "left":
                    if (flag==1)
                    {
                        txt_box.TextAlignment = TextAlignment.Left;

                    }
                    break;

                case "right":
                    if (flag == 1)
                    {
                        txt_box.TextAlignment = TextAlignment.Right;

                    }
                    break;
                    default:
                    if (flag==1) {
                        txt_box.TextAlignment = TextAlignment.Center;
                    }
                    break;

            }

        }

        private void txt_box_TextChanged(object sender, TextChangedEventArgs e)   
        {
            if (flag==2)
            {
                txt_box.IsReadOnly= true;    ///make text box read only

            }
        }
    }
}
