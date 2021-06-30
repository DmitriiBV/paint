using System.Drawing;

namespace DZ_24_01_2021
{
    public class ClassTriangle: ClassCircle
    {
        protected float radius;
        public ClassTriangle(Point pointStart, Point pointEnd, Pen pen, SolidBrush brushFill, bool selectFill) : base(pointStart, pointEnd, pen, brushFill, selectFill)
        {
            radius = diameter / 2;
        }
        public override void Show(Graphics temp)
        {
            temp.DrawPolygon(pen, GetPoints(radius, pointStart.X, pointStart.Y, 3, 300.022F));
            if (selectFill == true)
            {
                temp.FillPolygon(brushFill, GetPoints(radius, pointStart.X, pointStart.Y, 3, 300.022F));
            }
        }
    }
}
