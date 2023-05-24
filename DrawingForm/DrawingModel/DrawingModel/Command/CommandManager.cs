using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class CommandManager
    {
        const string UNDO = "Cannot Undo exception\n";
        const string REDO = "Cannot Redo exception\n";
        Stack<ICommand> _undo = new Stack<ICommand>();
        Stack<ICommand> _redo = new Stack<ICommand>();

        // 執行
        public void Execute(ICommand command)
        {
            command.DrawShape();
            _undo.Push(command);
            _redo.Clear();
        }

        // 復原
        public void Undo()
        {
            if (_undo.Count <= 0)
                throw new Exception(UNDO);
            ICommand command = _undo.Pop();
            _redo.Push(command);
            command.DeleteShape();
        }

        // 重做
        public void Redo()
        {
            if (_redo.Count <= 0)
                throw new Exception(REDO);
            ICommand command = _redo.Pop();
            _undo.Push(command);
            command.DrawShape();
        }

        // 清空
        public void Clear()
        {
            _undo.Clear();
            _redo.Clear();
        }

        public bool IsUndoEnable
        {
            get
            {
                return _undo.Count != 0;
            }
        }

        public bool IsRedoEnable
        {
            get
            {
                return _redo.Count != 0;
            }
        }
    }
}
