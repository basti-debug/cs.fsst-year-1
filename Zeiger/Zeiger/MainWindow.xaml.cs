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

namespace Zeiger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Zeigerle(drawcan, 250, 100, 1,0,50);

        }


        public static void Zeigerle(Canvas can, int x, int y, int zeigerwert, int lowest, int high)
        {
            Ellipse rounder = new Ellipse();
            rounder.Width = 300;
            rounder.Height = 300;
            rounder.Stroke = Brushes.Black;

            Canvas.SetLeft(rounder, x);
            Canvas.SetTop(rounder, y);

            can.Children.Add(rounder);

            Rectangle recta1 = new Rectangle();
            recta1.Width = 300;
            recta1.Height = 150;
            recta1.Stroke = Brushes.White;
            recta1.Fill = Brushes.White;

            Canvas.SetLeft(recta1, x);
            Canvas.SetTop(recta1, y*2.5);

            can.Children.Add(recta1);

            Rectangle recta2 = new Rectangle();
            recta2.Width = 300;
            recta2.Height = 1;
            recta2.Stroke = Brushes.Black;
            recta2.Fill = Brushes.Black;

            Canvas.SetLeft(recta2, x);
            Canvas.SetTop(recta2, y * 2.5);

            can.Children.Add(recta2);

            Label labellow = new Label();
            labellow.Content = lowest+ " V";
            labellow.Height = 30;
            labellow.Foreground = Brushes.Black;
            labellow.Background = Brushes.White;
            labellow.Focusable = true;
            

            labellow.Visibility = Visibility.Visible;

            Canvas.SetLeft(labellow, x-40);
            Canvas.SetTop(labellow, y*2.3);

            can.Children.Add(labellow);


            Label labelhigh = new Label();
            labelhigh.Content = high + " V";
            labelhigh.Height = 30;
            labelhigh.Foreground = Brushes.Black;
            labelhigh.Background = Brushes.White;
            labelhigh.Focusable = true;


            labelhigh.Visibility = Visibility.Visible;

            Canvas.SetLeft(labelhigh, x + 300);
            Canvas.SetTop(labelhigh, y * 2.3);

            can.Children.Add(labelhigh);

        }

        
    }
}
