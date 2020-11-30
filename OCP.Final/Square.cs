using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Final
{
    public class Square : Shape
    {
        public double Length { get; set; }
        public override double Area()
        {
            return Length * Length;
        }
    }
}
