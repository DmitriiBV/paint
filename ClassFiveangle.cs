using System.Drawing;

namespace DZ_24_01_2021
{
    public class ClassFiveangle: ClassTriangle
    {
        public ClassFiveangle(Point pointStart, Point pointEnd, Pen pen, SolidBrush brushFill, bool selectFill) : base(pointStart, pointEnd, pen, brushFill, selectFill)
        {            
        }
        public override void Show(Graphics temp)
        {
            temp.DrawPolygon(pen, GetPoints(radius, pointStart.X, pointStart.Y, 5, 60F));
            if (selectFill == true)
            {
                temp.FillPolygon(brushFill, GetPoints(radius, pointStart.X, pointStart.Y, 5, 60F));
            }
        }
    }
}
