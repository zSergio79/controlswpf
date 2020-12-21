using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            var btn = (Panel)sender;
            var gradient = btn.OpacityMask as RadialGradientBrush;
            if (gradient == null)
                return;
            Point pt = Mouse.GetPosition(btn);
            gradient.GradientOrigin = new Point(pt.X / btn.ActualWidth, pt.Y / btn.ActualHeight);
            gradient.RadiusX = 0.25;
            gradient.RadiusY = 0.75;
            gradient.Center = gradient.GradientOrigin;
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Click");
            lbl.Content = (sender as Button).Content;
        }

        private void Button_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            lbl.Content = "2";
        }

        private void UniformGrid_MouseLeave(object sender, MouseEventArgs e)
        {
            var btn = (Panel)sender;
            var gradient = btn.OpacityMask as RadialGradientBrush;
            if (gradient == null)
                return;
            gradient.GradientOrigin = new Point(-1,-1);
            gradient.Center = gradient.GradientOrigin;
        }
    }
}
