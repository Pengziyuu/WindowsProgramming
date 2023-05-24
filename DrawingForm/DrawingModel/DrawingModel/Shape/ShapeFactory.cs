using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    public class ShapeFactory
    {
        Shape _hint;

        // 生成形狀
        public Shape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.None:
                    break;
                case ShapeType.Line:
                    _hint = new Line();
                    break;
                case ShapeType.Triangle:
                    _hint = new Triangle();
                    break;
                case ShapeType.Rectangle:
                    _hint = new Rectangle();
                    break;
            }
            return _hint;
        }
    }
}
