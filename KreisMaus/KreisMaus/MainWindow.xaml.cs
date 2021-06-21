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
using System.Windows.Forms;
using System.Drawing;

namespace KreisMaus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int xposm = 0;
        int yposm = 0;
        int xr = 0;
        int yr = 0;
        int radys = 0;
        bool drag = false;

        int deltaX = 0;
        int deltaY = 0;

        public MainWindow()
        {
            InitializeComponent();
            
            
        }


        public void drawcircle(Canvas can, int x, int y, int rad, System.Windows.Media.Color col, int thicknes, System.Windows.Media.Color linecol,bool marker, System.Windows.Media.Color markercolory)
        {
            drawcan.Children.Clear();
            //Marker setzten: x (fadenkreuz)
            circle(can,x,y,col,linecol, rad,thicknes);
            markerdraw(can, x, y, markercolory);

        }

        public void circle(Canvas can, int x1, int y1, System.Windows.Media.Color col, System.Windows.Media.Color linecol, int rad,int thickness)
        {
            Ellipse circle = new Ellipse();
            Canvas.SetLeft(circle, x1 - rad);
            Canvas.SetTop(circle, y1 - rad);
            circle.Width = 2 * rad;
            circle.Height = 2 * rad;
            circle.Fill = new SolidColorBrush(col);
            circle.Stroke = new SolidColorBrush(linecol);
            circle.StrokeThickness = thickness;
            can.Children.Add(circle);

             
        }

        public void markerdraw(Canvas can, int x, int y, System.Windows.Media.Color markercolor)
        {
            //Marker setzten: x (fadenkreuz)


            Line line1 = new Line();
            line1.X1 = x - 3;
            line1.Y1 = y - 3;
            line1.X2 = x + 3;
            line1.Y2 = y + 3;
            line1.Stroke = new SolidColorBrush(markercolor);
            line1.StrokeThickness = 1;

            can.Children.Add(line1);

            Line line2 = new Line();
            line2.X1 = x - 3;
            line2.Y1 = y + 3;
            line2.X2 = x + 3;
            line2.Y2 = y - 3;
            line2.Stroke = new SolidColorBrush(markercolor);
            line2.StrokeThickness = 1;

            can.Children.Add(line2);
        }



        private void drawcan_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
           System.Windows.Point p = e.GetPosition(drawcan);
            xposm = Convert.ToInt32(p.X);
            yposm = Convert.ToInt32(p.Y);

            drawcircle(drawcan, xposm, yposm, radys, Colors.Gray, 1, Colors.Gray, true, Colors.Crimson);
            drag = true;

        }

        private void drawcan_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
            System.Windows.Point p1 = new System.Windows.Point();
            xr = (int)p1.X;
            yr = (int)p1.Y;
            deltaX = xposm - xr;
            deltaY = yposm - yr;

            int radiussses = (int)Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));

            drawcircle(drawcan, deltaX, deltaY, radiussses, Colors.Red, 1, Colors.Orange, true, Colors.Black);
            drag = false;

        }

        private async void drawcan_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            radiuslabel.Content = Convert.ToString(Math.Round((double)radys, 5));

            xlabel.Content = Convert.ToString(Math.Round((double)xposm, 5));

            ylabel.Content = Convert.ToString(Math.Round((double)yposm, 5));

            if (!drag)
                return;

            await Task.Delay(1);

            System.Windows.Point p1 = new System.Windows.Point();
            xr = (int)p1.X;
            yr = (int)p1.Y;
            deltaX = xposm - xr;
            deltaY = yposm - yr;

            radys = (int)Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));

            drawcircle(drawcan, xposm, yposm, radys, Colors.Black, 2, Colors.Orange, true, Colors.Black);


            drag = false;

        }

       
        private void colorbutton_Click(object sender, RoutedEventArgs e)
        {

            if (kreisradiobutton.IsChecked == true)
            {
                ColorDialog dialog = new ColorDialog();
                dialog.ShowDialog();
                System.Drawing.Color farbe = dialog.Color;
                byte r = farbe.R;
                byte g = farbe.G;
                byte b = farbe.B;
                System.Drawing.Color coloria = System.Drawing.Color.FromArgb(r, g, b);
                drawcircle(drawcan, xposm, yposm, radys, System.Drawing.Brushes.AntiqueWhite, 2, System.Drawing.Brushes.Blue, true, System.Drawing.Brushes.Gray);
                
            }



        }
    }
}
