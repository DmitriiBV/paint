using System;
using System.Drawing;

namespace DZ_24_01_2021
{
    public class ClassCircle : BaseClassFigure
    {
        protected int diameter;
        public ClassCircle(Point pointStart, Point pointEnd, Pen pen, SolidBrush brushFill, bool selectFill) : base(pointStart, pointEnd, pen, brushFill, selectFill)
        {            
            diameter= Math.Min(width, height);
        }
        protected  PointF[] GetPoints(float radius, float pointStartX, float pointStartY, int numTops, float phi = 0)
        {
            PointF[] pointFs = new PointF[numTops];
            for (int i = 0; i < numTops; i++)
            {
                pointFs[i].X = (float)(pointStartX + radius * Math.Cos(phi + 2 * Math.PI * i / numTops));
                pointFs[i].Y = (float)(pointStartY + radius * Math.Sin(phi + 2 * Math.PI * i / numTops));
            }
            return pointFs;
        }
        public override void Show(Graphics temp)
        {            
            temp.DrawEllipse(pen, pointStart.X, pointStart.Y, diameter, diameter);             
            if (selectFill == true)
            {
                temp.FillEllipse(brushFill, new Rectangle(pointStart.X, pointStart.Y, diameter, diameter));
            }
        }
    }
}
