using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class Line : Shape
    {
        const string NAME = "Line";
        Shape _startShape;
        Shape _endShape;

        public Shape StartShape
        {
            get
            {
                return _startShape;
            }
            set
            {
                _startShape = value;
            }
        }

        public Shape EndShape
        { 
            get
            {
                return _endShape;
            }
            set
            {
                _endShape = value;
            } 
        }

        // 畫虛線
        public override void DottedLine(IGraphics graphics)
        {
        }

        // 畫
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawLine(StartShape.CenterX, StartShape.CenterY, EndShape.CenterX, EndShape.CenterY);
            _name = NAME;
        }

        // 取得文字
        public override string GetShapeText()
        {
            return "";
        }

        // 是否在圖形內
        public override bool IsIn(double pointX, double pointY)
        {
            return false;
        }
    }
}
