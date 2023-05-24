using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel.State
{
    class LinkState : IState
    {
        ShapeFactory _shapeFactory = new ShapeFactory();
        bool _isPressed = false;
        Shape _hint;
        Shape _temp = null;
        Shape _startShape = null;
        Shape _endShape = null;

        // 滑鼠點擊
        public void MouseDown(Model model, double pointX, double pointY)
        {
            _startShape = model.GetClickedShape(pointX, pointY);
            model.IsLineEnable = true;
            if (_startShape != null)
            {
                _isPressed = true;
                _hint = _shapeFactory.CreateShape(model.ShapeType);
                _temp = _shapeFactory.CreateShape(ShapeType.Rectangle);
                _temp.CenterX = pointX;
                _temp.CenterY = pointY;
                ((Line)_hint).StartShape = _startShape;
                ((Line)_hint).EndShape = _temp;
            }
        }

        // 滑鼠移動
        public void MouseMove(Model model, double pointX, double pointY)
        {
            if (model.IsLineEnable && _startShape != null)
            {
                _temp.CenterX = pointX;
                _temp.CenterY = pointY;
            }
        }

        // 滑鼠放開
        public void MouseUp(Model model, CommandManager commandManager, double pointX, double pointY)
        {
            if (_isPressed)
            {
                int count = 0;
                _endShape = model.GetClickedShape(pointX, pointY);
                if (_endShape != null)
                {
                    count++;
                    model.IsLineEnable = false;
                    ((Line)_hint).EndShape = _endShape;
                }
                if (count != 0)
                    commandManager.Execute(new DrawCommand(model, _hint));
            }
        }

        // 畫
        public void Draw(Model model, IGraphics graphics)
        {
            if (_isPressed)
                _hint.Draw(graphics);
            model.ShapeText = "";
        }
    }
}