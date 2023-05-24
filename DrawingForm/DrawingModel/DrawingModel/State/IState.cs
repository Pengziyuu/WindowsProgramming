using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    interface IState
    {
        // 滑鼠點擊
        void MouseDown(Model model, double pointX, double pointY);
        // 滑鼠移動
        void MouseMove(Model model, double pointX, double pointY);
        // 滑鼠放開
        void MouseUp(Model model, CommandManager commandManager, double pointX, double pointY);
        // 畫
        void Draw(Model model, IGraphics graphics);
    }
}
