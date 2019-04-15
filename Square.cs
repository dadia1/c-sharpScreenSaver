using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSaver
{
    /// <summary>
    /// The square class inherits form shape class.
    /// </summary>
    class Square : Shape
    {
        #region Ctor.
        public Square() { }
        public Square(double X, double Y)
        {
            x = X; //the x variable inherits from shape class.
            y = Y; //the y variable inherits from shape class.
        }
        #endregion

        #region Func.

        /// <summary>
        /// Call the virtual function from shape class and The local function initializes the local variables .
        /// </summary>
        public override void InitWithRandomValues()
        {
            base.InitWithRandomValues();
            Random random = new Random();
            y = x = random.Next(2, 10); //initialize the y and x variables becuase x and y must be equals in square. 
        }

        /// <summary>
        /// The function drawing the square shape.
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
        /// The function calculates the square area.
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            shapeArea = x * x;
            return shapeArea;
        }

        /// <summary>
        /// The function calculates the shape Perimeter.
        /// </summary>
        /// <returns></returns>
        public override double GetPerimeter()
        {
            shapePerimeter = x * 4;
            return shapePerimeter;
        }

        /// <summary>
        /// Call The function from the shape class and display all details about the square.
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
            return "My name is square";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion
    }
}
