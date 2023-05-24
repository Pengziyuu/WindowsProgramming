using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace HomeWork
{
    public class BookItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _quantity;
        private string _category;
        private string _name;
        private string _isBookNumber;
        private string _author;
        private string _publish;
        private string _source;
        private Image _image;
        private int _number = 1;
        private int _returnNumber = 1;
        private int _borrowingNumber = 0;
        private string _borrowingData;
        private string _returnData;      
        private const string NAME = "Name";
        private const string CATEGORY = "Category";
        private const string QUANTITY = "Quantity";
        private const string NUMBER = "IsBookNumber";
        private const string AUTHOR = "Author";
        private const string PUBLISH = "Publish";
        private const string SOURCE = "Source";
        private const string IMAGE = "Image";
        private const string NUMBERS = "Number";
        private const string RETURN = "Return";
        private const string BORROW = "BorrowingNumber";
        private const string SOURCE1 = "../../../image/";
        private const string SOURCE2 = ".jpg";
        private const string DATA1 = "\r編號 : ";
        private const string DATA2 = "\r作者 : ";
        private const string DATA3 = "\r出版項 : ";
        private const string DATA4 = "書籍名稱 : ";
        private const string DATA5 = "\r\r書籍類別 : ";
        private const string DATA6 = "\r庫存數量 : ";

        public BookItem()
        {
        }

        public string Name
        {
            get 
            { 
                return this._name; 
            }
            set
            {
                this._name = value;
                NotifyPropertyChanged(NAME);
            }
        }

        public string Category
        {
            get
            { 
                return this._category;
            }
            set
            {
                this._category = value;
                NotifyPropertyChanged(CATEGORY);
            }
        }

        public int Quantity
        {
            get 
            { 
                return this._quantity; 
            }
            set 
            {
                this._quantity = value;
                NotifyPropertyChanged(QUANTITY);
            }
        }

        public string IsBookNumber
        {
            get
            {
                return this._isBookNumber;
            }
            set
            {
                this._isBookNumber = value;
                NotifyPropertyChanged(NUMBER);
            }
        }

        public string Author
        {
            get
            {
                return this._author;
            }
            set
            {
                this._author = value;
                NotifyPropertyChanged(AUTHOR);
            }
        }

        public string Publish
        {
            get
            {
                return this._publish;
            }
            set
            {
                this._publish = value;
                NotifyPropertyChanged(PUBLISH);
            }
        }

        public string Source
        {
            get
            {
                return this._source;
            }
            set
            {
                this._source = value;
                NotifyPropertyChanged(SOURCE);
            }
        }

        public Image Image
        {
            get
            {
                return this._image;
            }
            set
            {
                this._image = value;
                NotifyPropertyChanged(IMAGE);
            }
        }

        public int Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
                NotifyPropertyChanged(NUMBERS);
            }
        }

        public int ReturnNumber
        {
            get
            {
                return this._returnNumber;
            }
            set
            {
                this._returnNumber = value;
                NotifyPropertyChanged(RETURN);
            }
        }

        public int QuantityBorrowed
        {
            get
            {
                return this._borrowingNumber;
            }
            set
            {
                this._borrowingNumber = value;
                NotifyPropertyChanged(BORROW);
            }
        }

        public string BorrowingDate
        {
            get
            {
                return this._borrowingData;
            }
            set
            {
                this._borrowingData = value;
            }
        }

        public string ReturnDate
        {
            get
            {
                return this._returnData;
            }
            set
            {
                this._returnData = value;
            }
        }

        public string BookData
        {
            get
            {
                return _name + DATA1 + _isBookNumber + DATA2 + _author + DATA3 + _publish;
            }
        }

        public string AddBookData
        {
            get
            {
                return DATA4 + _name + DATA5 + _category + DATA6 + _quantity;
            }
        }

        // 設定_source
        public void Set(string value)
        {
            _source = SOURCE1 + value + SOURCE2;
            _image = Image.FromFile(Source);
        }

        // 借書
        public void BorrowBook()
        {
            _quantity = _quantity - 1;
            NotifyPropertyChanged(QUANTITY);
        }

        // 還書
        public void ReturnBook()
        {
            _quantity = _quantity + 1;
            NotifyPropertyChanged(QUANTITY);
        }

        // 通知改變
        void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
