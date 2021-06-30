using System.Drawing;

namespace DZ_24_01_2021
{
    public class ClassStraightLine: BaseClassFigure
    {
        public ClassStraightLine(Point pointStart, Point pointEnd, Pen pen, SolidBrush brushFill, bool selectFill) : base(pointStart, pointEnd, pen, brushFill, selectFill)
        {
        }
        public override void Show(Graphics temp)
        {
            temp.DrawLine(pen, pointStart.X, pointStart.Y, pointEnd.X, pointEnd.Y);            
        }
    }
}
