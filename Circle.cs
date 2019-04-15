using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSaver
{
    /// <summary>
    /// The circle class inherits form shape class.
    /// </summary>
    class Circle : Shape
    {
        #region Data members.
        public double radius;
        #endregion

        #region Ctor.
        public Circle() { }

        public Circle(double r)
        {
            radius = r;
        }
        #endregion

        #region Function.

        /// <summary>
        /// The function initializes the local variables and call to function from shape class.
        /// </summary>
        public override void InitWithRandomValues()
        {
            Random random = new Random();
            radius = random.Next(2, 10);
            base.InitWithRandomValues();
        }

        /// <summary>
        /// The function drawing the circle shape.
        /// </summary>

        public override void Draw()
        {
            double radius_in = radius - 0.4;
            double radius_out = radius + 0.4;
            int i = 0;

            for (y = radius; y >= -radius; --y)
            {
                Console.SetCursorPosition(shapePositionOnScreen_X, shapePositionOnScreen_Y + i);

                for (x = -radius; x < radius_out; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= radius_in * radius_in && value <= radius_out * radius_out)
                    {
                        Console.Write("*");
                    }
                    else if (value < radius_in * radius_in && value < radius_out * radius_out)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                i++;
            }
        }

        /// <summary>
        /// The function calculates the circle area.
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            shapeArea = Math.PI * Math.Pow(radius, 2);
            return shapeArea;
        }

        /// <summary>
        /// The function calculates the circle perimeter.
        /// </summary>
        /// <returns></returns>
        public override double GetPerimeter()
        {
            shapePerimeter = 2 * Math.PI * radius;
            return shapePerimeter;
        }

        /// <summary>
        /// Call The virtual function from the shape class and display all details about the circle and add print the radius details.
        /// </summary>
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Radius = " + radius);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "My name is circle";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion
    }
}
