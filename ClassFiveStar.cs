using System.Drawing;

namespace DZ_24_01_2021
{
    public class ClassFiveStar: ClassFourStar
    {
        public ClassFiveStar(Point pointStart, Point pointEnd, Pen pen, SolidBrush brushFill, bool selectFill) : base(pointStart, pointEnd, pen, brushFill, selectFill)
        {
            smallRadius = (float)(radius * 0.38196601);
        }
        public override void Show(Graphics temp)
        {
            temp.DrawPolygon(pen, GetPointsStar(radius, smallRadius, pointStart.X, pointStart.Y, 5, -0.32F, 0.31F));
            if (selectFill == true)
            {
                temp.FillPolygon(brushFill, GetPointsStar(radius, smallRadius, pointStart.X, pointStart.Y, 5, -0.32F, 0.31F));
            }
        }
    }
}
