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
    internal class SubsidiaryClass : BaseClass
    {
        int grade;
        public SubsidiaryClass() { }
        public SubsidiaryClass(int x, int y, int size)
            : base(x, y, size)
        {
            this.grade = 0;
        }
        public override void Left(ref Canvas rectangle)
        {
            grade -= 10;
            RotateTransform rotateTransform2 = new RotateTransform(grade);
            rotateTransform2.CenterX = size / 2;
            rotateTransform2.CenterY = size / 2;
            rectangle.RenderTransform = rotateTransform2;
        }

        public override void Right(ref Canvas rectangle)
        {
            grade += 10;
            RotateTransform rotateTransform2 = new RotateTransform(grade);
            rotateTransform2.CenterX = size / 2;
            rotateTransform2.CenterY = size / 2;
            rectangle.RenderTransform = rotateTransform2;
        }
    }
}