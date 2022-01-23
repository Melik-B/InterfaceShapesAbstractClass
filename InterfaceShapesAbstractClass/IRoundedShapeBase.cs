using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceShapesAbstractClass
{
    abstract class IRoundedShapeBase
    {
        public abstract double Radius { get; set; }
        public abstract bool IsPiThree { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculateCircumference();
    }
}
