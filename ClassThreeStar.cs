using System;
using System.Drawing;

namespace DZ_24_01_2021
{
    public class ClassThreeStar: ClassTriangle
    {
        protected float smallRadius;
        public ClassThreeStar(Point pointStart, Point pointEnd, Pen pen, SolidBrush brushFill, bool selectFill) : base(pointStart, pointEnd, pen, brushFill, selectFill)
        {
            this.smallRadius = (float)(radius * 0.27196601);
        }
        protected  PointF[] GetPointsStar(float radius, float smallRadius, float pointStartX, float pointStartY, int numTops, float fhiR = 0, float fhiSmallR = 0)
        {
            PointF[] pointFs = new PointF[numTops*2];
            int j = 0;
            for (int i = 0; i < pointFs.Length; )
            {
                pointFs[i].X = (float)(pointStartX + radius * Math.Cos(fhiR + 2 * Math.PI * j / numTops));
                pointFs[i].Y = (float)(pointStartY + radius * Math.Sin(fhiR + 2 * Math.PI * j / numTops));
                i++;
                pointFs[i].X = (float)(pointStartX + smallRadius * Math.Cos(fhiSmallR + 2 * Math.PI * j / numTops));
                pointFs[i].Y = (float)(pointStartY + smallRadius * Math.Sin(fhiSmallR + 2 * Math.PI * j / numTops));
                i++;
                j++;
            }
            return pointFs;
        }
        public override void Show(Graphics temp)
        {
            temp.DrawPolygon(pen, GetPointsStar(radius, smallRadius, pointStart.X, pointStart.Y, 3, 0.52F, 1.57F));        
            if (selectFill == true)
            {
                temp.FillPolygon(brushFill, GetPointsStar(radius, smallRadius, pointStart.X, pointStart.Y, 3, 0.52F, 1.57F));
            }
        }
    }
}
