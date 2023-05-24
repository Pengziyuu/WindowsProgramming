using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class DrawCommand : ICommand
    {
        Model _model;
        Shape _shape;

        public DrawCommand(Model model, Shape shape)
        {
            _model = model;
            _shape = shape;
        }

        // 畫形狀
        public void DrawShape()
        {
            _model.DrawShape(_shape);
        }

        // 刪除形狀
        public void DeleteShape()
        {
            _model.DeleteShape();
        }
    }

}
