using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.Pow(radius, 2) * Math.PI;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}
