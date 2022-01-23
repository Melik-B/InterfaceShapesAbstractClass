using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceShapesAbstractClass
{
    class RightTriangle : IShapeWithAnglesBase
    {
        public override double Width { get; set; }
        public override double Height { get; set; }

        double hypotenuse;

        public override double CalculateArea()
        {
            return (Width * Height) / 2;
        }

        public override double CalcuteCircumference()
        {
            hypotenuse = Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
            return hypotenuse + Width + Height;
        }
    }
}
