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

namespace MikoÜbungen2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public void Treppe(Canvas can, double width, int count)
        {
            can.Children.Clear();
            double xpos1 = 10;
            double ypos1 = 409;
            for(int i = 0; i < count; i++)
            {
                Line line = new Line();

                line.StrokeThickness = 1;
                line.Stroke = Brushes.Black;

                line.X1 = xpos1;
                line.Y1 = ypos1;
               
                ypos1 -= width;

                line.X2 = xpos1;
                line.Y2 = ypos1;

                can.Children.Add(line);

               

                Line line2 = new Line();
                line2.StrokeThickness = 1;
                line2.Stroke = Brushes.Black;

                line2.X1 = xpos1;
                line2.Y1 = ypos1;
                xpos1 += width;
                line2.X2 = xpos1;
                line2.Y2 = xpos1;

                can.Children.Add(line2);

               
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            Treppe(candraw, 20, 10);

            
        }
    }
}
