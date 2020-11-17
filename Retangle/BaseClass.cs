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
    internal class BaseClass
    {
        public int size;
        public int y;
        public int x;


        public BaseClass() { }
        public BaseClass(int x, int y, int size)
        {
            this.size = size;
            this.y = y;
            this.x = x;
        }


        public virtual void Left(ref Canvas rectangle)
        {
            if (x > 0)
            {
                x -= 5;
            }
            rectangle.Margin = new Thickness(x, y, 0, 0);
        }

        public virtual void Right(ref Canvas rectangle)
        {
            if (x < 600 - size)
            {
                x += 5;
            }
            rectangle.Margin = new Thickness(x, y, 0, 0);
        }
    }
}