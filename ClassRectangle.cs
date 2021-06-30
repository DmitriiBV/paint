using System.Drawing;

namespace DZ_24_01_2021
{
    public class ClassRectangle : BaseClassFigure
    {
        protected Rectangle rectangle;
        public ClassRectangle(Point pointStart, Point pointEnd, Pen pen, SolidBrush brushFill, bool selectFill) : base(pointStart, pointEnd, pen, brushFill, selectFill)
        {
            rectangle = new Rectangle(this.pointStart.X, this.pointStart.Y, width, height);
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
