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

namespace ResistorDrawer
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        #region globalvariables
        string globalvaluevalue;
        double globalwidth;
        double part;

        #endregion
        public void drawRes(Canvas can, double xpos, double ypos, double width, string text)
        {
            can.Children.Clear();
            double Rwidth = 30;
            double Rheight = 20;

            double hacksn = (width - Rwidth) / 2;

            Line lineLeft = new Line();

            double pos1 = xpos + (Rwidth / 2);

            lineLeft.X1 = xpos;
            lineLeft.Y1 = ypos;
            lineLeft.X2 = xpos + hacksn;
            lineLeft.Y2 = ypos;
            lineLeft.Stroke = Brushes.Black;
            lineLeft.StrokeThickness = 2;
            can.Children.Add(lineLeft);


            Line lineright = new Line();
            lineright.X1 = xpos + hacksn + Rwidth;
            lineright.Y1 = ypos;
            lineright.X2 = xpos + hacksn + Rwidth + hacksn;
            lineright.Y2 = ypos;
            lineright.Stroke = Brushes.Black;
            lineright.StrokeThickness = 2;
            can.Children.Add(lineright);



            Rectangle R = new Rectangle();
            R.Stroke = Brushes.Black;
            R.StrokeThickness = 2;
            R.Width = Rwidth;
            R.Height = Rheight;
            Canvas.SetLeft(R, xpos + hacksn);
            Canvas.SetTop(R, ypos - (Rheight / 2));
            can.Children.Add(R);


            TextBlock tb = new TextBlock();
            tb.Text = text;
            Canvas.SetLeft(tb, xpos + hacksn);
            Canvas.SetTop(tb, ypos + 10);
            can.Children.Add(tb);
        }

        public void drawCond(Canvas can, double xpos, double ypos, double width, string text)
        {
            can.Children.Clear();
            double Rwidth = 40;
            double Rheight = 20;

            double hacksn = (width - Rwidth) / 2;
            #region lines
            Line lineLeft = new Line();

            double pos1 = xpos + (Rwidth / 2);

            lineLeft.X1 = xpos;
            lineLeft.Y1 = ypos;
            lineLeft.X2 = xpos + hacksn;
            lineLeft.Y2 = ypos;
            lineLeft.Stroke = Brushes.Black;
            lineLeft.StrokeThickness = 2;
            can.Children.Add(lineLeft);


            Line lineright = new Line();
            lineright.X1 = xpos + hacksn + Rwidth;
            lineright.Y1 = ypos;
            lineright.X2 = xpos + hacksn + Rwidth + hacksn;
            lineright.Y2 = ypos;
            lineright.Stroke = Brushes.Black;
            lineright.StrokeThickness = 2;
            can.Children.Add(lineright);

            #endregion

            Rectangle R1 = new Rectangle();
            R1.Stroke = Brushes.Black;
            R1.StrokeThickness = 2;
            R1.Width = (30 / 2);
            R1.Height = Rheight;
            R1.Fill = Brushes.Black;
            Canvas.SetLeft(R1, xpos + hacksn);
            Canvas.SetTop(R1, ypos - (Rheight / 2));
            can.Children.Add(R1);

            Rectangle R2 = new Rectangle();
            R2.Stroke = Brushes.Black;
            R2.StrokeThickness = 2;
            R2.Width = (30 / 2);
            R2.Height = Rheight;
            R2.Fill = Brushes.Black;
            Canvas.SetLeft(R2, xpos + hacksn + 25);
            Canvas.SetTop(R2, ypos - (Rheight / 2));
            can.Children.Add(R2);


            TextBlock tb = new TextBlock();
            tb.Text = text;
            Canvas.SetLeft(tb, xpos + hacksn);
            Canvas.SetTop(tb, ypos + 10);
            can.Children.Add(tb);
        }

        public void drawCoil(Canvas can, double xpos, double ypos, double width, string text)
        {
            can.Children.Clear();
            double Rwidth = 30;
            double Rheight = 20;

            double hacksn = (width - Rwidth) / 2;

            Line lineLeft = new Line();

            double pos1 = xpos + (Rwidth / 2);

            lineLeft.X1 = xpos;
            lineLeft.Y1 = ypos;
            lineLeft.X2 = xpos + hacksn;
            lineLeft.Y2 = ypos;
            lineLeft.Stroke = Brushes.Black;
            lineLeft.StrokeThickness = 2;
            can.Children.Add(lineLeft);


            Line lineright = new Line();
            lineright.X1 = xpos + hacksn + Rwidth;
            lineright.Y1 = ypos;
            lineright.X2 = xpos + hacksn + Rwidth + hacksn;
            lineright.Y2 = ypos;
            lineright.Stroke = Brushes.Black;
            lineright.StrokeThickness = 2;
            can.Children.Add(lineright);



            Rectangle R = new Rectangle();
            R.Stroke = Brushes.Black;
            R.StrokeThickness = 2;
            R.Width = Rwidth;
            R.Height = Rheight;
            R.Fill = Brushes.Black;
            Canvas.SetLeft(R, xpos + hacksn);
            Canvas.SetTop(R, ypos - (Rheight / 2));
            can.Children.Add(R);


            TextBlock tb = new TextBlock();
            tb.Text = text;
            Canvas.SetLeft(tb, xpos + hacksn);
            Canvas.SetTop(tb, ypos + 10);
            can.Children.Add(tb);
        }
        private void linksuntenmausl(object sender, MouseButtonEventArgs e)
        {
            double iposx = Mouse.GetPosition(drawcan).X;
            double iposy = Mouse.GetPosition(drawcan).Y;
            if (part == 3)
            {
                drawRes(drawcan, iposx, iposy, globalwidth, globalvaluevalue + "\u2126");
            }
            if (part == 2)
            {
                drawCond(drawcan, iposx, iposy, globalwidth, globalvaluevalue + "F");
            }
            if (part == 1)
            {
                drawCoil(drawcan, iposx, iposy, globalwidth, globalvaluevalue + "H");
            }

        }

        #region uidesign 
        private void valueentered(object sender, TextChangedEventArgs e)
        {
            globalvaluevalue = enteredvalue.Text;
        }

        private void coilbutton_Click(object sender, RoutedEventArgs e)
        {
            part = 1;

            resistorbutton.IsChecked = false;
            condensatorbutton.IsChecked = false;
        }

        private void condensatorbutton_Click(object sender, RoutedEventArgs e)
        {
            part = 2;

            resistorbutton.IsChecked = false;
            coilbutton.IsChecked = false;
        }

        private void resistorbutton_Click(object sender, RoutedEventArgs e)
        {
            part = 3;

            condensatorbutton.IsChecked = false;
            coilbutton.IsChecked = false;
        }

        private void widthslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            globalwidth = widthslider.Value * 10;
        }
    }
    #endregion
}
