using System.Drawing;

namespace DZ_24_01_2021
{
    public class ClassRighttriangle: ClassTriangle
    {
        protected Point[] points;
        public ClassRighttriangle(Point pointStart, Point pointEnd, Pen pen, SolidBrush brushFill, bool selectFill) : base(pointStart, pointEnd, pen, brushFill, selectFill)
        {
            points = new Point[] { new Point(this.pointStart.X, this.pointStart.Y), 
                                   new Point(this.pointEnd.X,   this.pointStart.Y), 
                                   new Point(this.pointStart.X, this.pointEnd.Y) };
        }
        public override void Show(Graphics temp)
        {
            temp.DrawPolygon(pen, points);            
            if (selectFill == true)
            {
                temp.FillPolygon(brushFill, points);
            }
        }
    }
}
