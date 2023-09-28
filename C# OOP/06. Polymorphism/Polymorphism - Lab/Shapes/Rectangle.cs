using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes;

public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.height = height;
        this.width = width;
    }

    public override double CalculateArea()
    {
        return height * width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (width + height);
    }
    
}
