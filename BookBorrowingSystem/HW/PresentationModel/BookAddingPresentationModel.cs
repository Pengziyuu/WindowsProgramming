using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HomeWork
{
    public class BookAddingPresentationModel
    {
        const Char CHECK1 = '\b';
        const Char CHECK2 = '0';
        const Char CHECK3 = '9';

        public BookAddingPresentationModel()
        {
        }

        // 檢查輸入
        public bool CheckNumber(char input)
        {
            if (!(input == CHECK1 || (input >= CHECK2 && input <= CHECK3)))
                return true;
            else
                return false;
        }
    }
}
