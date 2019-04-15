using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSaver
{
    /// <summary>
    /// The rectangle class inherits form shape class.
    /// </summary>
    class Rectangle : Shape
    {
        #region Ctor.
        public Rectangle() { }

        public Rectangle(double X, double Y)
        {
            x = X; //the x variable inherits from shape class.
            y = Y; //the y variable inherits from shape class.
        }
        #endregion

        #region Function.

        /// <summary>
        /// The function call to virtual function from shape class.
        /// </summary>
        public override void InitWithRandomValues()
        {
            base.InitWithRandomValues();
        }

        /// <summary>
        /// The function drawing the rectangle shape.
        /// </summary>
        public override void Draw()
        {
            for (int i = 0; i < y; i++)
            {
                Console.SetCursorPosition(shapePositionOnScreen_X, shapePositionOnScreen_Y + i);
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
            }
        }

        /// <summary>
        /// The function calculates the rectangle area.
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            shapeArea = x * y;
            return shapeArea;
        }

        /// <summary>
        /// The function calculates the rectangle perimeter.
        /// </summary>
        /// <returns></returns>
        public override double GetPerimeter()
        {
            shapePerimeter = 2 * x + 2 * y;
            return shapePerimeter;
        }

        /// <summary>
        /// Call The virtual function from the shape class and display all details about the rectangle.
        /// </summary>
        public override void ShowDetails()
        {
            base.ShowDetails();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "My name is rectangle";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion
    }
}
