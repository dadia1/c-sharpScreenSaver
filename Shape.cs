using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ScreenSaver
{
    abstract class Shape
    {
        #region Data members.

        public double x;
        public double y;
        public int shapePositionOnScreen_X;
        public int shapePositionOnScreen_Y;
        public ConsoleColor shapeColor;
        public double shapeArea;
        public double shapePerimeter;

        #endregion

        #region ctor.
        public Shape() { }

        public Shape(double X, double Y, int ShapePosition_on_Screen_x, int ShapePosition_on_Screen_y, ConsoleColor Shape_Color, double Shape_Area, double Shape_Perimeter)
        {
            x = X;
            y = Y;
            shapePositionOnScreen_Y = ShapePosition_on_Screen_y;
            shapePositionOnScreen_X = ShapePosition_on_Screen_x;
            shapeColor = Shape_Color;
            shapeArea = Shape_Area;
            shapePerimeter = Shape_Perimeter;
        }

        #endregion

        #region func.

        /// <summary>
        /// Function drawing the shape. 
        /// </summary>
        /// <returns>drawing shape.</returns>
        public abstract void Draw();

        /// <summary>
        /// The function calculates the shape area.
        /// </summary>
        /// <returns>shape area.</returns>
        public abstract double GetArea();

        /// <summary>
        /// The function calculates the shape Perimeter.
        /// </summary>
        /// <returns>shape Perimeter.</returns>
        public abstract double GetPerimeter();

        /// <summary>
        /// The function display all details about the shape.
        /// </summary>
        public virtual void ShowDetails()
        {
            Console.WriteLine("Shape position X = {0} \n Shape position Y = {1} \n Shape color = {2} \n Shape area = {3}" +
                " \n Shape perimeter = {4}", shapePositionOnScreen_X, shapePositionOnScreen_Y, shapeColor, shapeArea, shapePerimeter);
        }

        /// <summary>
        ///The function initializes all variables. 
        /// </summary>
        public virtual void InitWithRandomValues()
        {
            Random random = new Random();
            x = random.Next(2, 20);
            y = random.Next(2, 20);
            shapePositionOnScreen_X = random.Next(25);
            shapePositionOnScreen_Y = random.Next(80);
            Console.SetCursorPosition(shapePositionOnScreen_X, shapePositionOnScreen_Y);
            shapeColor = Console.ForegroundColor = (ConsoleColor)random.Next(16);
        }

        #endregion
    }
}
