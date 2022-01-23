using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceShapesAbstractClass
{
    public abstract class IShapeWithAnglesBase
    {
        public abstract double Width { get; set; }
        public abstract double Height { get; set; }

        public abstract double CalculateArea();
        public abstract double CalcuteCircumference();
    }
}
