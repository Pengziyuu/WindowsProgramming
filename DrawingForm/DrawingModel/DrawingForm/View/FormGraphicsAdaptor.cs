using System;
using System.Drawing;
using DrawingModel;

namespace DrawingForm.PresentationModel
{
    class FormGraphicsAdaptor : IGraphics
    {
        const int TWO = 2;
        const int THICKNESS = 5;
        const int RADIUS = 10;
        const int OFFSET = 5;

        Graphics _graphics;

        public FormGraphicsAdaptor(Graphics graphics)
        {
            this._graphics = graphics;
        }

        // 清除
        public void ClearAll()
        {
        }

        // 畫三角形
        public void DrawTriangle(double x1, double y1, double x2, double y2)
        {
            double temp;
            if (x1 > x2)
            {
                temp = x1;
                x1 = x2;
                x2 = temp;
            }
            if (y1 > y2)
            {
                temp = y1;
                y1 = y2;
                y2 = temp;
            }
            CreateTriangle(x1, y1, x2, y2);
        }

        // 建三角形
        public void CreateTriangle(double x1, double y1, double x2, double y2)
        {
            Pen pen = new Pen(Color.Black, THICKNESS);
            SolidBrush solidBrush = new SolidBrush(Color.Orange);
            PointF point1 = new PointF((float)x1, (float)y2);
            PointF point2 = new PointF((float)x2, (float)y2);
            PointF point3 = new PointF((float)System.Math.Abs((x1 + x2)) / TWO, (float)y1);
            PointF[] curvePoints = { point1, point2, point3 };
            _graphics.DrawPolygon(pen, curvePoints);
            _graphics.FillPolygon(solidBrush, curvePoints);
        }

        // 畫矩形
        public void DrawRectangle(double x1, double y1, double x2, double y2)
        {
            Pen pen = new Pen(Color.Black, THICKNESS);
            SolidBrush solidBrush = new SolidBrush(Color.Yellow);
            PointF point1 = new PointF((float)x1, (float)y1);
            PointF point2 = new PointF((float)x2, (float)y1);
            PointF point3 = new PointF((float)x2, (float)y2);
            PointF point4 = new PointF((float)x1, (float)y2);
            PointF[] curvePoints = { point1, point2, point3, point4 };
            _graphics.DrawPolygon(pen, curvePoints);
            _graphics.FillPolygon(solidBrush, curvePoints);
        }

        // 畫虛線
        public void DottedLine(double x1, double y1, double x2, double y2)
        {
            Pen pen = new Pen(Color.Red, THICKNESS);
            pen.DashPattern = new float[] { THICKNESS, THICKNESS };
            PointF point1 = new PointF((float)x1, (float)y1);
            PointF point2 = new PointF((float)x2, (float)y1);
            PointF point3 = new PointF((float)x2, (float)y2);
            PointF point4 = new PointF((float)x1, (float)y2);
            PointF[] curvePoints = { point1, point2, point3, point4 };
            _graphics.DrawPolygon(pen, curvePoints);
            CreateEllipse(x1, y1, x2, y2);
        }

        // 建圓形
        public void CreateEllipse(double x1, double y1, double x2, double y2)
        {
            Pen pen1 = new Pen(Color.Black, THICKNESS);
            SolidBrush solidBrush = new SolidBrush(Color.White);
            _graphics.DrawEllipse(pen1, (float)x1 - OFFSET, (float)y1 - OFFSET, RADIUS, RADIUS);
            _graphics.DrawEllipse(pen1, (float)x2 - OFFSET, (float)y1 - OFFSET, RADIUS, RADIUS);
            _graphics.DrawEllipse(pen1, (float)x2 - OFFSET, (float)y2 - OFFSET, RADIUS, RADIUS);
            _graphics.DrawEllipse(pen1, (float)x1 - OFFSET, (float)y2 - OFFSET, RADIUS, RADIUS);
            _graphics.FillEllipse(solidBrush, (float)x1 - OFFSET, (float)y1 - OFFSET, RADIUS, RADIUS);
            _graphics.FillEllipse(solidBrush, (float)x2 - OFFSET, (float)y1 - OFFSET, RADIUS, RADIUS);
            _graphics.FillEllipse(solidBrush, (float)x2 - OFFSET, (float)y2 - OFFSET, RADIUS, RADIUS);
            _graphics.FillEllipse(solidBrush, (float)x1 - OFFSET, (float)y2 - OFFSET, RADIUS, RADIUS);
        }

        // 畫線
        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            Pen pen = new Pen(Color.Red, THICKNESS);
            _graphics.DrawLine(Pens.Black, (float)x1, (float)y1, (float)(x1 + x2) / TWO, (float)y1);
            _graphics.DrawLine(Pens.Black, (float)(x1 + x2) / TWO, (float)y1, (float)(x1 + x2) / TWO, (float)y2);
            _graphics.DrawLine(Pens.Black, (float)(x1 + x2) / TWO, (float)y2, (float)x2, (float)y2);
        }
    }
}
