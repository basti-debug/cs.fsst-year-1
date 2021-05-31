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

namespace KreisMaus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int xposm = 0;
        int yposm = 0;
        int rad = 0;

        public MainWindow()
        {
            InitializeComponent();
            
        }


        public void drawcircle(Canvas can, int x, int y, int rad, Color col, int thicknes, Color linecol,bool marker,Color markercolory)
        {
            //Marker setzten: x (fadenkreuz)
            circle(can,x,y,Colors.Red,Colors.Orange, 50,3);
            markerdraw(can, x, y, markercolory);

        }

        public void circle(Canvas can, int x1, int y1, Color col, Color linecol, int rad,int thickness)
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

        public void markerdraw(Canvas can, int x, int y, Color markercolor)
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
            Point p = e.GetPosition(drawcan);
            xposm = Convert.ToInt32(p.X);
            yposm = Convert.ToInt32(p.Y);

            drawcircle(drawcan, xposm, yposm, 10, Colors.Red, 1, Colors.Orange, true, Colors.Crimson);
        }

        private void drawcan_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
