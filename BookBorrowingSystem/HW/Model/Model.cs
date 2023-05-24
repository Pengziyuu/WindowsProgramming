using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace HomeWork
{
    public class Model
    {
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();

        BindingList<BookItem> _bookItemsList = new BindingList<BookItem>();
        BindingList<BookItem> _backPackData = new BindingList<BookItem>();
        List<BookCategory> _bookCategoryList = new List<BookCategory>();
        List<Book> _bookList = new List<Book>();
        Book _book;
        BookItem _bookItem;

        List<int> _borrowIndexList = new List<int>();
        List<int> _borrowedQuantityList = new List<int>();
        List<Book> _borrowedList = new List<Book>();

        List<int> _gridViewBorrowIndexList = new List<int>();
        List<int> _gridViewBorrowQuantityList = new List<int>();
        List<Book> _gridViewBorrowedList = new List<Book>();

        List<int> _allBorrowIndexList = new List<int>();
        List<int> _allBorrowQuantityList = new List<int>();
        List<Book> _allBorrowList = new List<Book>();

        const string SOURCE = "../../../hw4_books_source.txt";
        const string SLASH = "//";
        const string SPACE = " ";
        const string BOOK = "BOOK";
        const int TWO = 2;
        const int THREE = 3;
        const int FOUR = 4;
        int _dataIndex = 0;
        int _bookIndex = 0;
        string[] _category = { };
        int[] _categorySize = { };
        int _categoryIndex = 0;

        public Model() 
        { 
        }

        // 處理資料
        public void ReadData()
        {
            StreamReader file = new StreamReader(@SOURCE);
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                ProcessingData(line);
            }
            CreateCategoryArray();
            CreateCategorySize();
        }

        // 分別處理資料
        public void ProcessingData(string line)
        {
            if (line.Contains(SLASH) || line == SPACE)
                return;
            else if (line == BOOK)
            {
                SetBook();
            }
            else
                AddData(line, _categoryIndex);
        }

        // 設定書初始
        private void SetBook()
        {
            _book = new Book();
            _bookItem = new BookItem();
            _dataIndex = 0;
            _categoryIndex = 0;
            _bookIndex++;
            _bookItem.Set(_bookIndex.ToString());
        }

        // 加入書資訊
        private void AddData(string line, int categoryIndex)
        {
            if (categoryIndex == 0)
            {
                _bookItem.Quantity = int.Parse(line);
                _categoryIndex++;
            }
            else if (categoryIndex == 1)
            {
                _bookItem.Category = line;
                AddBookCategory(line);
            }
            else
            {
                AddBook(line);
            }
        }

        // 書分類加到物件陣列
        public void AddBookCategory(string line)
        {
            _bookCategoryList.Add(new BookCategory(line));
            _categoryIndex++;
        }

        // 書資料加到物件陣列中
        public void AddBook(string line)
        {
            if (_dataIndex == 0)
                _bookItem.Name = line;
            else if (_dataIndex == 1)
                _bookItem.IsBookNumber = line;
            else if (_dataIndex == TWO)
                _bookItem.Author = line;
            else if (_dataIndex == THREE)
                _bookItem.Publish = line;
            _book.SetBook(_dataIndex, line);
            _dataIndex = _dataIndex + 1;
            if (_dataIndex == FOUR)
            {
                _bookList.Add(_book);
                _bookItemsList.Add(_bookItem);
            }
        }

        // 將書的分類不重複加入陣列
        public void CreateCategoryArray()
        {
            for (int i = 0; i < _bookItemsList.Count; i++)
            {
                if (Array.IndexOf(_category, _bookItemsList[i].Category) == -1)
                {
                    System.Array.Resize(ref _category, _category.Length + 1);
                    _category[_category.Length - 1] = _bookItemsList[i].Category;
                }
            }
        }

        // 將每個分類裡書的數量加入陣列
        public void CreateCategorySize()
        {
            int temp = 0;
            int[] number = new int[_category.Length];
            foreach (string newTabPage in _category)
            {
                for (int i = 0; i < _bookItemsList.Count; i++)
                {
                    if (_bookItemsList[i].Category == newTabPage)
                    {
                        number[temp] = number[temp] + 1;
                    }
                }
                temp = temp + 1;
            }
            _categorySize = number;
        }

        // 取得書的分類陣列
        public List<BookCategory> GetCategoryList()
        {
            return _bookCategoryList;
        }

        // 取得書的不重複分類陣列
        public string[] GetCategoryArray()
        {
            CreateCategoryArray();
            return _category;
        }

        // 取得書的分類數量陣列
        public int[] GetCategorySize()
        {
            CreateCategorySize();
            return _categorySize;
        }

        // 取得書籍數量陣列
        public BindingList<BookItem> GetBookItem()
        {
            return _bookItemsList;
        }

        // 取得書包資料陣列
        public BindingList<BookItem> GetBackPackData()
        {
            return _backPackData;
        }

        // 借書
        public void BorrowBook(int position)
        {
            if (_bookItemsList.Count > 0)
                _bookItemsList[position].BorrowBook();
        }

        // 還書
        public void ReturnBook(int position)
        {
            _bookItemsList[position].ReturnBook();
        }

        // 取得書籍資料陣列
        public List<Book> GetBook()
        {
            return _bookList;
        }

        // (暫時)設定借書單陣列
        public void SetGridViewBorrowList(List<Book> books)
        {
            _gridViewBorrowedList = books;
        }

        // (暫時)取得借書單陣列
        public List<Book> GetGridViewBorrowList()
        {
            return _gridViewBorrowedList;
        }

        // (暫時)設定借書單數量陣列
        public void SetGridViewBorrowQuantityList(List<int> quantity)
        {
            _gridViewBorrowQuantityList = quantity;
        }

        // (暫時)取得借書單數量陣列
        public List<int> GetGridViewBorrowQuantityList()
        {
            return _gridViewBorrowQuantityList;
        }

        // (暫時)設定借書單index陣列
        public void SetGridViewBorrowIndexList(List<int> quantity)
        {
            _gridViewBorrowIndexList = quantity;
        }

        // (暫時)取得借書單index陣列
        public List<int> GetGridViewBorrowIndexList()
        {
            return _gridViewBorrowIndexList;
        }

        // (最終)設定借書陣列
        public void SetBorrowList(List<Book> books)
        {
            _borrowedList = books;
        }

        // (最終)取得借書陣列
        public List<Book> GetBorrowList()
        {
            return _borrowedList;
        }

        // (最終)設定借書數量陣列
        public void SetBorrowQuantityList(List<int> quantity)
        {
            _borrowedQuantityList = quantity;
        }

        // (最終)取得借書數量陣列
        public List<int> GetBorrowQuantityList()
        {
            return _borrowedQuantityList;
        }

        // (最終)設定借書index陣列
        public void SetBorrowIndexList(List<int> index)
        {
            _borrowIndexList = index;
        }

        // (最終)取得借書index陣列
        public List<int> GetBorrowIndexList()
        {
            return _borrowIndexList;
        }

        // (最終)取得全部借書陣列
        public List<Book> GetAllBorrowList()
        {
            return _allBorrowList;
        }

        // (最終)取得借書數量陣列
        public List<int> GetAllBorrowQuantityList()
        {
            return _allBorrowQuantityList;
        }

        // (最終)取得借書index陣列
        public List<int> GetAllBorrowIndexList()
        {
            return _allBorrowIndexList;
        }

        // 傳送通知
        public void Send()
        {
            NotifyObserver();
        }

        // 提醒
        void NotifyObserver()
        {
            if (_modelChanged != null)
                _modelChanged();
        }
    }
}
