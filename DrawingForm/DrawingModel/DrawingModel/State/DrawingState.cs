using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel.State
{
    class DrawingState : IState
    {
        ShapeFactory _shapeFactory = new ShapeFactory();
        double _startPointX;
        double _startPointY;
        bool _isPressed = false;
        Shape _hint;

        // 滑鼠點擊
        public void MouseDown(Model model, double pointX, double pointY)
        {
            _isPressed = true;
            _hint = _shapeFactory.CreateShape(model.ShapeType);
            _startPointX = pointX;
            _startPointY = pointY;
            _hint.X1 = pointX;
            _hint.Y1 = pointY;

        }

        // 滑鼠移動
        public void MouseMove(Model model, double pointX, double pointY)
        {
            if (_isPressed)
            {
                _hint.X2 = pointX;
                _hint.Y2 = pointY;
            }
        }

        // 滑鼠放開
        public void MouseUp(Model model, CommandManager commandManager, double pointX, double pointY)
        {
            if (_isPressed)
            {
                _isPressed = false;
                if (_startPointX > pointX)
                {
                    _hint.X1 = pointX;
                    _hint.X2 = _startPointX;
                }
                if (_startPointY > pointY)
                {
                    _hint.Y1 = pointY;
                    _hint.Y2 = _startPointY;
                }
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
