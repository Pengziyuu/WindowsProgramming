using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel.State
{
    class PointerState : IState
    {
        Shape _selectedShape = null;

        // 滑鼠點擊
        public void MouseDown(Model model, double pointX, double pointY)
        {
            _selectedShape = model.GetClickedShape(pointX, pointY);
        }

        // 滑鼠移動
        public void MouseMove(Model model, double pointX, double pointY)
        {
        }

        // 滑鼠放開
        public void MouseUp(Model model, CommandManager commandManager, double pointX, double pointY)
        {
        }

        // 畫
        public void Draw(Model model, IGraphics graphics)
        {
            if (_selectedShape != null)
            {
                _selectedShape.DottedLine(graphics);
                model.ShapeText = _selectedShape.GetShapeText();
            }
            else
                model.ShapeText = "";
        }
    }
}
