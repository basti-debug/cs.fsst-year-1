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

namespace MikoÜbungen3
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            drawrect(5);
        }

        private void drawrect(int count)
        {
            
            int xpos = 50;
            int ypos = 50;
            int width = 50;
            
            for(int i = 0; i < count; i++)
            {
                Rectangle recita = new Rectangle();
                recita.Stroke = Brushes.Black;
                recita.StrokeThickness = 1;
                recita.Width = width;
                recita.Height = width;

                Canvas.SetLeft(recita, xpos);
                Canvas.SetBottom(recita, ypos);
                ypos = ypos + (width / 4);
                xpos = xpos + width;
                width = width / 2;
                drawcan.Children.Add(recita);
            }
                
            


        }
    }
}
