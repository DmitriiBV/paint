using System.Drawing;

namespace DZ_24_01_2021
{
    public class ClassSixangle: ClassFiveangle
    {
        public ClassSixangle(Point pointStart, Point pointEnd, Pen pen, SolidBrush brushFill, bool selectFill) : base(pointStart, pointEnd, pen, brushFill, selectFill)
        {
        }
        public override void Show(Graphics temp)
        {
            temp.DrawPolygon(pen, GetPoints(radius, pointStart.X, pointStart.Y, 6, 0.525F));
            if (selectFill == true)
            {
                temp.FillPolygon(brushFill, GetPoints(radius, pointStart.X, pointStart.Y, 6, 0.525F));
            }
        }
    }
}
