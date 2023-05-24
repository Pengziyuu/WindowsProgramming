using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    abstract public class Shape
    {
        const int TWO = 2;
        protected string _name;
        protected double _x1;
        protected double _y1;
        protected double _x2;
        protected double _y2;
        protected double _centerX;
        protected double _centerY;

        public double X1
        {
            get
            {
                return _x1;
            }
            set
            {
                _x1 = value;
            }
        }

        public double Y1
        {
            get
            {
                return _y1;
            }
            set
            {
                _y1 = value;
            }
        }

        public double X2
        {
            get
            {
                return _x2;
            }
            set
            {
                _x2 = value;
            }
        }

        public double Y2
        {
            get
            {
                return _y2;
            }
            set
            {
                _y2 = value;
            }
        }

        public double CenterX
        {
            get
            {
                if (_x1 != 0)
                    return (_x1 + _x2) / TWO;
                else
                    return _centerX;
            }
            set
            {
                _centerX = value;
            }
        }

        public double CenterY
        {
            get
            {
                if (_y1 != 0)
                    return (_y1 + _y2) / TWO;
                else
                    return _centerY;
            }
            set
            {
                _centerY = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        // 畫
        abstract public void Draw(IGraphics graphics);

        // 是否在圖形內
        abstract public bool IsIn(double pointX, double pointY);

        // 畫虛線
        abstract public void DottedLine(IGraphics graphics);

        // 取得形狀文字
        abstract public string GetShapeText();
    }
}
