using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Retangle
{
    public partial class MainWindow : Window
    {
        SubsidiaryClass rectangle2;
        BaseClass rectangle1;
        bool IsSwithed;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Start_Click(object Start, RoutedEventArgs e)
        {
            try
            {
                rectangle2 = new SubsidiaryClass(350, Convert.ToInt32(StartHigh.Text), Convert.ToInt32(StartSize.Text));
                rectangle1 = new BaseClass(350, Convert.ToInt32(StartHigh.Text), Convert.ToInt32(StartSize.Text));
                rectangle.Height = Convert.ToInt32(StartSize.Text);
                rectangle.Width = Convert.ToInt32(StartSize.Text);
                rectangle.Margin = new Thickness(rectangle1.x, rectangle1.y, 0, 0);
                StartSize.Height = 0;
                StartSize.Width = 0;
                StartHigh.Height = 0;
                StartHigh.Width = 0;
                Start1.Height = 0;
                Start1.Width = 0;
                Switcher.Height = 50;
                Switcher.Width = 100;
                IsSwithed = false;
            }
            catch
            {
                StartHigh.Text = "Введите начальную высоту!";
                StartSize.Text = "Введите длинну стороны!";
            }
        }
        private void Switch_Click(object Start, RoutedEventArgs e)
        {
            IsSwithed = true;
        }

        private void KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                if (IsSwithed == false)
                {
                    rectangle1.Left(ref rectangle);
                }
                else
                {
                    rectangle2.Left(ref rectangle);
                }
            }
            if (e.Key == Key.Right)
            {
                if (IsSwithed == false)
                {
                    rectangle1.Right(ref rectangle);
                }
                else
                {
                    rectangle2.Right(ref rectangle);
                }
            }
        }
    }
}