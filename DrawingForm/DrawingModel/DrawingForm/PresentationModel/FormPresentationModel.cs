using DrawingModel;
using System.Windows.Forms;

namespace DrawingForm.PresentationModel
{
    public class FormPresentationModel
    {
        bool _isLineEnabled = true;
        bool _isTriangleEnabled = true;
        bool _isRectangleEnabled = true;

        Model _model;

        public FormPresentationModel(Model model, Control canvas)
        {
            this._model = model;
            _model.SetPointerState();
        }

        // 點擊Line
        public void ClickLine()
        {
            _isLineEnabled = false;
            _isTriangleEnabled = true;
            _isRectangleEnabled = true;
            _model.ShapeType = ShapeType.Line;
            _model.SetLinkState();
        }

        // 點擊Triangle
        public void ClickTriangle()
        {
            _isLineEnabled = true;
            _isTriangleEnabled = false;
            _isRectangleEnabled = true;
            _model.ShapeType = ShapeType.Triangle;
            _model.SetDrawingState();
        }

        // 點擊Rectangl
        public void ClickRectangle()
        {
            _isLineEnabled = true;
            _isTriangleEnabled = true;
            _isRectangleEnabled = false;
            _model.ShapeType = ShapeType.Rectangle;
            _model.SetDrawingState();
        }

        // 按鈕全Enable
        public void EnableAll()
        {
            _isLineEnabled = true;
            _isTriangleEnabled = true;
            _isRectangleEnabled = true;
            _model.ShapeType = ShapeType.None;
            _model.SetPointerState();
        }

        // 放開Enable
        public void EnableReleased()
        {
            bool isDrawingLine = _model.IsLineEnable;
            if (_model.ShapeType == ShapeType.Line && isDrawingLine)
            {
                _isLineEnabled = false;
                _model.SetLinkState();
            }
            else
            {
                _isLineEnabled = true;
                _model.ShapeType = ShapeType.None;
                _model.SetPointerState();
            }
            _isTriangleEnabled = true;
            _isRectangleEnabled = true;
        }

        // 回傳Line狀態
        public bool IsLineEnable
        {
            get
            {
                return _isLineEnabled;
            }
        }

        // 回傳Triangle狀態
        public bool IsTriangleEnable
        {
            get
            {
                return _isTriangleEnabled;
            }
        }

        // 回傳Rectangl狀態
        public bool IsRectangleEnabled
        {
            get
            {
                return _isRectangleEnabled;
            }
        }

        // 畫
        public void Draw(IGraphics graphics)
        {
            _model.Draw(graphics);
        }
    }
}
