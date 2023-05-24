using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    public class Rectangle : Shape
    {
        const string NAME = "Rectangle";
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
            graphics.DrawRectangle(X1, Y1, X2, Y2);
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
            return X1 < pointX && pointX < X2 && Y1 < pointY && pointY < Y2;
        }
    }
}
