using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceShapesAbstractClass
{
    class Circle : IRoundedShapeBase
    {
        public override double Radius { get; set; }
        public override bool IsPiThree { get; set; } = true;

        public override double CalculateArea()
        {
            double pi = Math.PI;
            if (IsPiThree)
                pi = 3;
            return pi * Radius * Radius;
        }

        public override double CalculateCircumference()
        {
            double pi = Math.PI;
            if (IsPiThree)
                pi = 3;
            return 2 * pi * Radius;
        }
    }
}
