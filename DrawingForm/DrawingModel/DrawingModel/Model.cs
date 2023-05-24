using DrawingModel.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    public enum ShapeType
    {
        None,
        Line,
        Triangle,
        Rectangle
    };

    public class Model
    {
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();
        const string LINE = "Line";
        bool _isDrawLine = false;
        string _shapeText = "";
        List<Shape> _shapes = new List<Shape>();
        ShapeType _shapeType = ShapeType.None;
        CommandManager _commandManager = new CommandManager();
        IState _state;

        public ShapeType ShapeType
        {
            get
            {
                return _shapeType;
            }
            set
            {
                _shapeType = value;
            }
        }

        // 滑鼠點擊
        public void PressedPointer(double pointX, double pointY)
        {
            _state.MouseDown(this, pointX, pointY);

            NotifyModelChanged();
        }

        // 回傳點到的形狀
        public Shape GetClickedShape(double pointX, double pointY)
        {
            foreach (Shape aShape in _shapes)
            {
                if (aShape.IsIn(pointX, pointY))
                    return aShape;
            }
            return null;
        }

        // 滑鼠移動
        public void MovedPointer(double pointX, double pointY)
        {
            _state.MouseMove(this, pointX, pointY);
            NotifyModelChanged();
        }

        // 滑鼠放開
        public void ReleasedPointer(double pointX, double pointY)
        {
            _state.MouseUp(this, _commandManager, pointX, pointY);
            NotifyModelChanged();
        }

        // 清除
        public void Clear()
        {
            _isDrawLine = false;
            _shapes.Clear();
            _commandManager.Clear();
            NotifyModelChanged();
        }

        // 畫
        public void DrawShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        // 清除
        public void DeleteShape()
        {
            _shapes.RemoveAt(_shapes.Count - 1);
        }

        // 復原
        public void Undo()
        {
            _commandManager.Undo();
            NotifyModelChanged();
        }

        // 重做
        public void Redo()
        {
            _commandManager.Redo();
            NotifyModelChanged();
        }

        // 畫形狀
        public void Draw(IGraphics graphics)
        {
            graphics.ClearAll();
            foreach (Shape aShape in _shapes)
            {
                if (aShape.Name == LINE)
                    aShape.Draw(graphics);
            }

            foreach (Shape aShape in _shapes)
            {
                if (aShape.Name != LINE)
                    aShape.Draw(graphics);
            }

            _state.Draw(this, graphics);
        }

        // 通知
        private void NotifyModelChanged()
        {
            if (_modelChanged != null)
                _modelChanged();
        }

        public bool IsLineEnable
        {
            get
            {
                return _isDrawLine;
            }
            set
            {
                _isDrawLine = value;
            }
        }

        public bool IsUndoEnable
        {
            get
            {
                return _commandManager.IsUndoEnable;
            }
        }

        public bool IsRedoEnable
        {
            get
            {
                return _commandManager.IsRedoEnable;
            }
        }

        public string ShapeText
        {
            get 
            {
                return _shapeText;
            }
            set 
            {
                _shapeText = value;
            } 
        }

        // 設定點擊模式
        public void SetPointerState()
        {
            _state = new PointerState();            
        }

        // 設定畫圖模式
        public void SetDrawingState()
        {
            _state = new DrawingState();
        }

        // 設定連線模式
        public void SetLinkState()
        {
            _state = new LinkState();
        }
    }
}

