using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public class AreaCalculator
    {
        public double TotalArea(Rectangle[] arrRectangles)
        {
            double area = 0;
            foreach (var objRectangle in arrRectangles)
            {
                area += objRectangle.Height * objRectangle.Width;
            }
            return area;
        }
    }
}
