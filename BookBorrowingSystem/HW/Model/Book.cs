using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class Book
    {
        private const string NUMBERING = "\n編號 : ";
        private const string AUTHOR = "\n作者 : ";
        private const string PUBLISH = "\n出版項 : ";
        private const int TWO = 2;
        private const int THREE = 3;
        private string _name;
        private string _isBookNumber;
        private string _author;
        private string _publish;

        public Book()
        {
        }

        // 設定書籍資料
        public void SetBook(int index, string data)
        {
            if (index == 0)
                _name = data;
            else if (index == 1)
                _isBookNumber = data;
            else if (index == TWO)
                _author = data;
            else if (index == THREE)
                _publish = data;
        }

        // 取得名稱
        public string GetName()
        {
            return _name;
        }

        // 取得ISBN
        public string GetIsBookNumber()
        {
            return _isBookNumber;
        }

        // 取得作者
        public string GetAuthor()
        {
            return _author;
        }

        // 取得出版項
        public string GetPublish()
        {
            return _publish;
        }

        // 取得全資料
        public string GetData()
        {
            return _name + NUMBERING + _isBookNumber + AUTHOR + _author + PUBLISH + _publish;
        }
    }
}
