using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    interface ICommand
    {
        // 畫形狀
        void DrawShape();
        // 刪除形狀
        void DeleteShape();
    }
}
