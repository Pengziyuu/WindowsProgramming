using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class BookCategory
    {
        private string _category;

        public BookCategory(string category)
        {
            _category = category;
        }

        // 取得全資料
        public string GetData()
        {
            return _category;
        }
    }
}
