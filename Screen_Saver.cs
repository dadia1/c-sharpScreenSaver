using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ScreenSaver
{
    //delegate void BeepSoundHandler(object sender, EventArgs e);

    /// <summary>
    /// The Screen Saver class inherits form shape class.
    /// </summary>
    class Screen_Saver : Shape
    {
        //public event BeepSoundHandler Beep;

        /// <summary>
        /// The function starts the program randomly without end, until the user presses any key.
        /// </summary>
        public static void Start()
        {
            Screen_Saver screen_Saver = new Screen_Saver();

            while (!Console.KeyAvailable)
            {
                Square square = new Square();
                Rectangle rectangle = new Rectangle();
                Circle circle = new Circle();
                VerticalLine verticalLine = new VerticalLine();
                HorizontalLine horizontalLine = new HorizontalLine();

                Random random = new Random();

                int RandClass = 0;
                RandClass = random.Next(1, 5);

                switch (RandClass)
                {
                    case 1:
                        square.InitWithRandomValues();
                        screen_Saver.CallBack(square.shapePositionOnScreen_X, square.shapePositionOnScreen_Y);
                        square.GetArea();
                        square.GetPerimeter();
                        square.Draw();
                        Thread.Sleep(1200);
                        Console.WriteLine();
                        Console.SetCursorPosition(0, 0);
                        square.ShowDetails();
                        Thread.Sleep(2000);
                        break;

                    case 2:
                        rectangle.InitWithRandomValues();
                        screen_Saver.CallBack(rectangle.shapePositionOnScreen_X, rectangle.shapePositionOnScreen_Y);
                        rectangle.GetArea();
                        rectangle.GetPerimeter();
                        rectangle.Draw();
                        Thread.Sleep(1200);
                        Console.WriteLine();
                        Console.SetCursorPosition(0, 0);
                        rectangle.ShowDetails();
                        Thread.Sleep(2000);
                        break;

                    case 3:
                        circle.InitWithRandomValues();
                        screen_Saver.CallBack(circle.shapePositionOnScreen_X, circle.shapePositionOnScreen_Y);
                        circle.GetArea();
                        circle.GetPerimeter();
                        circle.Draw();
                        Thread.Sleep(1200);
                        Console.WriteLine();
                        Console.SetCursorPosition(0, 0);
                        circle.ShowDetails();
                        Thread.Sleep(2000);
                        break;

                    case 4:
                        verticalLine.InitWithRandomValues();
                        screen_Saver.CallBack(verticalLine.shapePositionOnScreen_X, verticalLine.shapePositionOnScreen_Y);
                        verticalLine.GetArea();
                        verticalLine.GetPerimeter();
                        verticalLine.Draw();
                        Thread.Sleep(1200);
                        Console.WriteLine();
                        Console.SetCursorPosition(0, 0);
                        verticalLine.ShowDetails();
                        Thread.Sleep(2000);
                        break;

                    case 5:
                        horizontalLine.InitWithRandomValues();
                        screen_Saver.CallBack(horizontalLine.shapePositionOnScreen_X, horizontalLine.shapePositionOnScreen_Y);
                        horizontalLine.GetArea();
                        horizontalLine.GetPerimeter();
                        horizontalLine.Draw();
                        Thread.Sleep(1200);
                        Console.WriteLine();
                        Console.SetCursorPosition(0, 0);
                        horizontalLine.ShowDetails();
                        Thread.Sleep(2000);
                        break;
                }
                Console.Clear();
            }
        }

        /// <summary>
        /// The function makes a sound when the position of the shape is exactly in the middle of the screen.
        /// </summary>
        /// <param name="setX">Set X, shape Position On Screen</param>
        /// <param name="setY">Set Y, shape Position On Screen</param>
        public void CallBack(int setX, int setY)
        {
            if (setX == 12 && setY == 40)
            {
                Console.Beep();
            }
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
