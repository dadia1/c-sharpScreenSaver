using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSaver
{
    /// <summary>
    /// The horizontal line class inherits form shape class.
    /// </summary>
    class HorizontalLine : Shape
    {
        #region Ctor.
        public HorizontalLine() { }

        public HorizontalLine(double X)
        {
            x = X; //the x variable inherits from shape class.
        }
        #endregion

        #region Function.

        /// <summary>
        /// Call the virtual function from shape class and The local function initializes the local variables.
        /// </summary>
        public override void InitWithRandomValues()
        {
            base.InitWithRandomValues();
            y = 0; //initialize the y variable becuase y must be equals 0 in a horizontal line. 
        }

        /// <summary>
        /// The function drawing the horizontal line.
        /// </summary>
        public override void Draw()
        {
            for (int i = 0; i < x; i++)
            {
                Console.SetCursorPosition(shapePositionOnScreen_X + i, shapePositionOnScreen_Y);
                Console.Write("*");
            }
        }

        /// <summary>
        /// The function calculates the horizontal line area.
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            shapeArea = 0;
            return shapeArea;
        }

        /// <summary>
        ///The function calculates the horizontal line perimeter.
        /// </summary>
        /// <returns></returns>
        public override double GetPerimeter()
        {
            shapePerimeter = x;
            return shapePerimeter;
        }

        /// <summary>
        /// Call The virtual function from the shape class and display all details about the horizontal line.
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
            return "My name is horizontal line";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion
    }
}
