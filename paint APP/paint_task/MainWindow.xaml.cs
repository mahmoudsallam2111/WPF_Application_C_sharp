using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace paint_task
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

        private void change_color(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "red":
                    Ink.DefaultDrawingAttributes.Color = Colors.Red;
                    break;

                case "green":
                    Ink.DefaultDrawingAttributes.Color = Colors.Green;
                    break;
                case "blue":
                    Ink.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;

                case "yellow":
                    Ink.DefaultDrawingAttributes.Color = Colors.Yellow;
                    break;



            }
        }


        /// change brush size 
        private void brush_size(object sender, RoutedEventArgs e)
        {


            switch (((RadioButton)sender).Content.ToString())
            {
              

                case "small":



                    Ink.DefaultDrawingAttributes.Height = .5;
                    Ink.DefaultDrawingAttributes.Width = .5;


                    break;

                case "normal":

                    Ink.DefaultDrawingAttributes.Height = 2;
                    Ink.DefaultDrawingAttributes.Width = 2;

                    break;
                case "large":
                    Ink.DefaultDrawingAttributes.Height = 20;
                    Ink.DefaultDrawingAttributes.Width = 20;

                    break;



            }

              

        }

        private void change_mode(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {
                case "ink":
                    Ink.EditingMode = InkCanvasEditingMode.Ink;
                    break;

                case "select":
                    Ink.EditingMode = InkCanvasEditingMode.Select;

                    break;
                case "erase":
                    Ink.EditingMode = InkCanvasEditingMode.EraseByPoint;

                    break;

                case "erase by stroke":
                    Ink.EditingMode = InkCanvasEditingMode.EraseByStroke;

                    break;



            }

        }

        private int index { set; get; }
        private void add_shape(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {
                case "ellipse":
                    var myEllipse = new Ellipse();
                    myEllipse.Stroke = System.Windows.Media.Brushes.Black;
                    myEllipse.Fill = System.Windows.Media.Brushes.Red;
                    myEllipse.HorizontalAlignment = HorizontalAlignment.Left;
                    myEllipse.VerticalAlignment = VerticalAlignment.Center;
                    myEllipse.Width = 50;
                    myEllipse.Height = 75;
                    Ink.Children.Clear();
                    Ink.Children.Add(myEllipse);

                    break;

                case "rectangle":
                    var myrect = new Rectangle();
                    myrect.Stroke = System.Windows.Media.Brushes.Black;
                    myrect.Fill = System.Windows.Media.Brushes.Gold;
                    myrect.HorizontalAlignment = HorizontalAlignment.Left;
                    myrect.VerticalAlignment = VerticalAlignment.Center;
                    myrect.Width = 50;
                    myrect.Height = 75;
                    Ink.Children.Clear();
                    Ink.Children.Add(myrect);
                    break;
               



            }

        }

        private void pic_draw(object sender, MouseButtonEventArgs e)
        {
            //if (index==0)
            //{
            //    var myEllipse = new Ellipse();
            //    myEllipse.Stroke = System.Windows.Media.Brushes.Black;
            //    myEllipse.Fill = System.Windows.Media.Brushes.DarkBlue;
            //    myEllipse.HorizontalAlignment = HorizontalAlignment.Left;
            //    myEllipse.VerticalAlignment = VerticalAlignment.Center;
            //    myEllipse.Width = 50;
            //    myEllipse.Height = 75;
            //    Ink.Children.Add(myEllipse);
            //}
            //if (index==1)
            //{
            //    var myrect = new Rectangle();
            //    myrect.Stroke = System.Windows.Media.Brushes.Black;
            //    myrect.Fill = System.Windows.Media.Brushes.DarkBlue;
            //    myrect.HorizontalAlignment = HorizontalAlignment.Left;
            //    myrect.VerticalAlignment = VerticalAlignment.Center;
            //    myrect.Width = 50;
            //    myrect.Height = 75;
            //    Ink.Children.Add(myrect);

            //}

        }

        private void clear_content(object sender, RoutedEventArgs e)
        {
           Ink.Strokes.Clear();
            Ink.Children.Clear();
        }

        private void paste_btn(object sender, RoutedEventArgs e)
        {
            Ink.Paste();
        }

        private void copy_btn(object sender, RoutedEventArgs e)
        {
            Ink.CopySelection();

        }

        private void cut_btn(object sender, RoutedEventArgs e)
        {
            Ink.CutSelection();
        }

        private void save_btn(object sender, RoutedEventArgs e)
        {
            SaveFileDialog mydialog = new SaveFileDialog();
            mydialog.Title = "save dialoag inkcanvas";
            mydialog.ShowDialog();
            if (mydialog.FileName == "")
            {
                return;
            }

            FileStream fs = File.Open(mydialog.FileName , FileMode.OpenOrCreate);
            Ink.Strokes.Save(fs);
            fs.Close();

        }

        private void load_btn(object sender, RoutedEventArgs e)
        {

            OpenFileDialog mydialog = new OpenFileDialog();
            mydialog.Title = "load dialoag inkcanvas";
            mydialog.ShowDialog();
            if (mydialog.FileName == "")
            {
                return;
            }

            FileStream fs = File.Open(mydialog.FileName, FileMode.Open);
            StrokeCollection mystroke= new StrokeCollection(fs);
            Ink.Strokes = mystroke;
            fs.Close(); 
        }

        private void Window_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Window_ImageFailed_1(object sender, ExceptionRoutedEventArgs e)
        {

        }
    }
}
