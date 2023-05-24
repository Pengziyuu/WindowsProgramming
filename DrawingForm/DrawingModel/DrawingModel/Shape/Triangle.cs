using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    public class Triangle : Shape
    {
        const int TWO = 2;
        const string NAME = "Triangle";
        const string TEXT1 = "Selected : ";
        const string TEXT2 = "(";
        const string TEXT3 = ", ";
        const string TEXT4 = ")";
        // 畫虛線
        public override void DottedLine(IGraphics graphics)
        {
            graphics.DottedLine(X1, Y1, X2, Y2);
        }

        // 畫圖
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawTriangle(X1, Y1, X2, Y2);
            _name = NAME;
        }

        // 取得文字
        public override string GetShapeText()
        {
            return TEXT1 + Name + TEXT2 + X1.ToString() + TEXT3 + Y1.ToString() + TEXT3 + X2.ToString() + TEXT3 + Y2.ToString() + TEXT4;
        }

        // 是否在圖形內
        public override bool IsIn(double pointX, double pointY)
        {
            double x1 = X1 - pointX;
            double y1 = Y2 - pointY;

            double x2 = X2 - pointX;
            double y2 = Y2 - pointY;

            double x3 = (X1 + X2) / TWO - pointX;
            double y3 = Y1 - pointY;

            double product1 = x1 * y2 - x2 * y1;
            double product2 = x2 * y3 - x3 * y2;
            double product3 = x3 * y1 - x1 * y3;
            return product1 * product2 > 0 && product2 * product3 > 0 ? true : false;
        }
    }
}