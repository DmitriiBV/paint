using System;
using System.Drawing;

namespace DZ_24_01_2021
{
    public class ClassSquare : ClassRectangle
    {
        protected int side;
        public ClassSquare(Point pointStart, Point pointEnd, Pen pen, SolidBrush brushFill, bool selectFill) : base(pointStart, pointEnd, pen, brushFill, selectFill)
        {
            side = Math.Min(width, height);
            rectangle = new Rectangle(this.pointStart.X, this.pointStart.Y, side, side);
        }
        public override void Show(Graphics temp)
        {
            temp.DrawRectangle(pen, rectangle);
            if (selectFill == true)
            {
                temp.FillRectangle(brushFill, rectangle);
            }
        }
    }
}
