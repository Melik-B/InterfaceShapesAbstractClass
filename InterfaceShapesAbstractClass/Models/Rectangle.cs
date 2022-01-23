using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceShapesAbstractClass
{
    class Rectangle : IShapeWithAnglesBase
    {
        public override double Width { get; set; }
        public override double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalcuteCircumference()
        {
            return 2 * (Height + Width);
        }
    }
}
