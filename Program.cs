
using hw1002;
using System;

namespace hw1002
   
{
    internal class Point
    {
        int c;
        int y;


        internal Point(int c, int y)
        {
            this.c = c;
            this.y = y;

        }

        internal int Getc()
        {
            return this.c;
        }
        internal int GetY()
        {

            return this.y;
        }

        internal void Setc(int cnum)
        {
            if (cnum < 0 || cnum > MyCanvas.MaxWidht)
            {
                Console.WriteLine("The width is off limit");
            }
            else
            {


                this.c = cnum;
            }
        }
        internal void SetY(int ynum)
        {
            if (ynum < 0 || ynum > MyCanvas.MaxHeight)
            {
                Console.WriteLine("the height is off limit:");
            }
            else
            {
                this.y = ynum;

            }
        }
        public override string ToString()
        {
            return base.ToString() + $"c={this.c} y={y}";
        }
    }
    internal class MyButton
    {
        protected Point topLeft;
        protected Point bottomRight;
        private int width;
        private int height;

        internal MyButton(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;

        }

        internal int GetWidth()
        {


            return width;

        }


        internal int GetHeight()
        {

            return height;
        }

        internal bool SetTopLefft(Point topLeft)
        {
            if (topLeft.Getc() > bottomRight.Getc() || topLeft.GetY() < bottomRight.GetY())
            {
                return false;
            }
            else
            {
                this.topLeft = topLeft;
                this.width = bottomRight.Getc() - topLeft.Getc();
                this.height = topLeft.GetY() - bottomRight.GetY();
                return true;
            }

        }

        internal bool SetBottomRight(Point bottomRight)
        {
            if (bottomRight.Getc() < topLeft.Getc() || bottomRight.GetY() > topLeft.GetY())
            {
                return false;
            }
            else
            {
                this.bottomRight = bottomRight;
                this.width = bottomRight.Getc() - topLeft.Getc();
                this.height = topLeft.GetY() - bottomRight.GetY();
                return true;
            }
        }
        internal Point GetTopLeft()
        {
            return this.topLeft;
        }

        internal Point GetBottomRight()
        {
            return this.bottomRight;
        }

        public override string ToString()
        {
            return $"The point top left is{topLeft.ToString()} and the point bottom right is{bottomRight.ToString()}";
        }
    }
}
public class MyCanvas
{
    public const int MaxWidht = 800;
    public const int MaxHeight = 600;
    static int buttonIndex = 0;
    static int MaxButtons = 3;
    static MyButton[] buttons = new MyButton[MaxButtons];




    public static bool CreateNewButton(int x1, int y1, int x2, int y2)
    {
        if (buttonIndex < MaxButtons)
        {
            MyButton button = new MyButton(new Point(x1, y1), new Point(x2, y2));
            buttons[buttonIndex] = button;
            buttonIndex++;
            return true;
        }
        return false;
    }
    public static void MoveButton(int button, int x, int y)
    {
        int a = buttons[button].GetTopLeft().Getc() + x;
        int b = buttons[button].GetTopLeft().GetY() + y;
        int c = buttons[button].GetBottomRight().Getc() + x;
        int d = buttons[button].GetBottomRight().GetY() + y;
        buttons[button] = new MyButton(new Point(a, b), new Point(c, d));


    }
    public static bool DeleteLastButton()
    {
        if (buttonIndex > 0)
        {

            buttonIndex = buttonIndex - 1;
            return true;
        }
        else
            return false;
    }
    public static void ClearAllButtons()
    {
        while (buttonIndex > 0)
        {

            buttonIndex = buttonIndex - 1;
        }


    }
    public static int GetCurrentNumberOFbuttons()
    {


        return buttonIndex;
    }
    public static int GetMaxNumberOFButtons()
    {

        return MaxButtons;
    }
    public static int GetTheMaxWidthOFButton()
    {
        int maxWidth = 0;

        for (int index = 0; index < buttonIndex; index++)
        {
            int b = buttons[index].GetWidth();
            if (b > maxWidth)
            {
                maxWidth = b;
            }
        }
        return maxWidth;
    }
    public static int GetTheMaxHeightOFButton()
    {
        int MaxHeight = 0;
        for (int i = 0; i < buttonIndex; i++)
        {
            int c = buttons[i].GetHeight();
            if (c > MaxHeight)
            {
                MaxHeight = c;
            }
        }
        return MaxHeight;
    }

}

internal class Program
    {
        private static void Main(string[] args)
        {
            
        }
    }
