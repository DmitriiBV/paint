using System.Drawing;

namespace DZ_24_01_2021
{
    public class ClassFourStar: ClassThreeStar
    {
        public ClassFourStar(Point pointStart, Point pointEnd, Pen pen, SolidBrush brushFill, bool selectFill) : base(pointStart, pointEnd, pen, brushFill, selectFill)
        {
        }      
        public override void Show(Graphics temp)
        {
            temp.DrawPolygon(pen, GetPointsStar(radius, smallRadius, pointStart.X, pointStart.Y, 4, 0.0F, 0.78F));
            if (selectFill == true)
            {
                temp.FillPolygon(brushFill, GetPointsStar(radius, smallRadius, pointStart.X, pointStart.Y, 4, 0.0F, 0.78F));
            }
        }
    }
}
