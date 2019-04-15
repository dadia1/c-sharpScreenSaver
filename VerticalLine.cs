using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSaver
{
    /// <summary>
    /// The vertical line class inherits form shape class.
    /// </summary>
    class VerticalLine : Shape
    {
        #region Ctor.
        public VerticalLine() { }

        public VerticalLine(double Y)
        {
            y = Y; //the y variable inherits from shape class.
        }
        #endregion

        #region Function.
        /// <summary>
        /// Call the virtual function from shape class and The local function initializes the local variables .
        /// </summary>
        public override void InitWithRandomValues()
        {
            base.InitWithRandomValues();
            x = 0; //initialize the x variable becuase x must be equals 0 in a vertical line. 
        }

        /// <summary>
        /// The function drawing the vertical line.
        /// </summary>
        public override void Draw()
        {
            for (int i = 0; i < y; i++)
            {
                Console.SetCursorPosition(shapePositionOnScreen_X, shapePositionOnScreen_Y + i);
                Console.WriteLine("*");
            }
        }

        /// <summary>
        /// The function calculates the vertical line area.
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            shapeArea = 0;
            return shapeArea;
        }

        /// <summary>
        ///The function calculates the vertical line perimeter.
        /// </summary>
        /// <returns></returns>
        public override double GetPerimeter()
        {
            shapePerimeter = y;
            return shapePerimeter;
        }

        /// <summary>
        /// Call The virtual function from the shape class and display all details about the vertical line.
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
            return "My name is vertical line";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion
    }
}
