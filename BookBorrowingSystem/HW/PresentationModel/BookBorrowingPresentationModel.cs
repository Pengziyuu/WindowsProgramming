using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace HomeWork
{
    public class BookBorrowingPresentationModel
    {
        private const int TWO = 2;
        private const int THREE = 3;
        private const int FOUR = 4;
        private const int FIVE = 5;
        const string MESSAGE1 = "【";
        const string MESSAGE2 = "】";
        const string MESSAGE3 = "本";
        const string MESSAGE4 = "、";
        const string MESSAGE5 = "\r \r";
        const string MESSAGE6 = "以成功借出";
        private const string DATE = "yyyy/MM/dd";
        private bool _isAddButtonEnable = true;
        private bool _isDownPageButtonEnable = true;
        private bool _isBackPackButtonEnable = true;
        private bool _isUpPageButtonEnable = false;
        private bool _isCheckBookButtonEnable = false;
        private bool[] _bookButton ;
        private int _totalButton = 0;
        private int _tabFirstBook = 0;
        private int _tabLastBook = 0;
        private int[] _categorySize;
        Model _model;
        List<Book> _book;
        BindingList<BookItem> _bookItemsList = new BindingList<BookItem>();
        BindingList<BookItem> _backPackData;
        List<Book> _gridViewBorrowList = new List<Book>();
        List<int> _gridViewBorrowQuantityList = new List<int>();
        List<int> _gridViewBorrowIndexList = new List<int>();
        List<int> _allBorrowIndexList = new List<int>();
        List<int> _allBorrowQuantityList = new List<int>();
        List<Book> _allBorrowList = new List<Book>();
        List<Book> _unionBookList = new List<Book>();
        List<int> _unionQuantityList = new List<int>();
        List<int> _unionIndexList = new List<int>();

        public BookBorrowingPresentationModel(Model model)
        {
            _model = model;
            _book = _model.GetBook();
            _categorySize = _model.GetCategorySize();
            _bookItemsList = _model.GetBookItem();
            _allBorrowIndexList = _model.GetAllBorrowIndexList();
            _allBorrowQuantityList = _model.GetAllBorrowQuantityList();
            _allBorrowList = _model.GetAllBorrowList();
            _gridViewBorrowList = _model.GetGridViewBorrowList();
            _gridViewBorrowQuantityList = _model.GetGridViewBorrowQuantityList();
            _gridViewBorrowIndexList = _model.GetGridViewBorrowIndexList();
            _backPackData = _model.GetBackPackData();
            SetButton();
        }

        // 設定按鈕資料
        public void SetButton()
        {
            for (int i = 0; i < _categorySize.Length; i++)
                _totalButton += _categorySize[i];
            _bookButton = new bool[_totalButton];
            for (int i = 0; i < _totalButton; i++)
                _bookButton[i] = false;
        }

        // 取得借書訊息
        public string GetBorrowMessage()
        {
            string borrowMessage = "";
            int total = _gridViewBorrowQuantityList.Count;
            for (int i = 0; i < total; i++)
            {
                borrowMessage += MESSAGE1 + _gridViewBorrowList[i].GetName() + MESSAGE2 + _gridViewBorrowQuantityList[i] + MESSAGE3;
                if (i != total - 1)
                    borrowMessage += MESSAGE4;
            }
            borrowMessage += MESSAGE5 + MESSAGE6;
            return borrowMessage;
        }
        
        // 取得按鈕數量
        public int GetTotalButton()
        {
            return _totalButton;
        }

        // 取得第一Tab頁數
        public int GetTotalPage()
        {
            int totalPage = 0;
            totalPage = _categorySize[0] / THREE;
            if (_categorySize[0] % THREE != 0)
                totalPage++;
            return totalPage;
        }

        // 更新狀態
        public void Refresh(int nowBook, int count)
        {
            bool canBorrow = true;
            foreach (int index in _gridViewBorrowIndexList)
                if (index == nowBook)
                    canBorrow = false;
            if (nowBook == -1 || canBorrow == false || _bookItemsList[nowBook].Quantity == 0)
                AddButtonDisable();
            else
                AddButtonEnable();
            if (count == 0)
                DisableCheckBookButton();
            else
                EnableCheckBookButton();
        }

        // 設定借書的List
        public void SetBookList()
        {
            GetList();
            AddBackPackData();
            _allBorrowIndexList.AddRange(_gridViewBorrowIndexList);
            _allBorrowQuantityList.AddRange(_gridViewBorrowQuantityList);
            _allBorrowList.AddRange(_gridViewBorrowList);
            _unionIndexList = _allBorrowIndexList.Union(_gridViewBorrowIndexList).ToList();
            _unionQuantityList = MergeBorrowQuantityList();
            _unionBookList = MergeBorrowBookList();
            _allBorrowIndexList = _unionIndexList;
            _allBorrowQuantityList = _unionQuantityList;
            _allBorrowList = _unionBookList;
            _model.SetBorrowIndexList(_allBorrowIndexList);
            _model.SetBorrowQuantityList(_allBorrowQuantityList);
            _model.SetBorrowList(_allBorrowList);
        }

        // 書包加入資料
        public void AddBackPackData()
        {
            for (int i = 0; i < _gridViewBorrowIndexList.Count; i++)
            {
                int index = _gridViewBorrowIndexList[i];
                if (_allBorrowIndexList.Contains(index))
                {
                    _bookItemsList[index].QuantityBorrowed += _gridViewBorrowQuantityList[i];
                }
                else
                {
                    _bookItemsList[index].QuantityBorrowed += _gridViewBorrowQuantityList[i];
                    _bookItemsList[index].BorrowingDate = DateTime.Now.ToString(DATE);
                    _bookItemsList[index].ReturnDate = DateTime.Now.AddDays(30).ToString(DATE);
                    _backPackData.Add(_bookItemsList[index]);
                }
            }
        }

        // 合併書本數量List
        private List<int> MergeBorrowQuantityList()
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < _unionIndexList.Count; i++)
            {
                for (int j = 0; j < _allBorrowIndexList.Count; j++)
                {
                    if (_unionIndexList[i] == _allBorrowIndexList[j])
                    {
                        if (temp.Count <= i)
                            temp.Add(_allBorrowQuantityList[j]);
                        else
                            temp[i] += _allBorrowQuantityList[j];
                    }
                }
            }
            return temp;
        }

        // 合併書本List
        private List<Book> MergeBorrowBookList()
        {
            List<Book> temp = new List<Book>();
            foreach (int index in _unionIndexList)
                temp.Add(_book[index]);
            return temp;
        }

        // 檢查數量
        public int CheckQuantity(int quantity, int rowIndex)
        {
            GetList();
            if (quantity != -1)
            {
                if (quantity > _bookItemsList[_gridViewBorrowIndexList[rowIndex]].Quantity)
                    return 1;
                else if (quantity > TWO)
                    return TWO;
            }
            int total = 0;
            foreach (int i in _gridViewBorrowQuantityList)
                total += i;
            if (total > FOUR && (quantity > _gridViewBorrowQuantityList[rowIndex] || quantity == -1))
                return THREE;
            else
                return 0;
        }

        // 取得當前借奢單List
        private void GetList()
        {
            _gridViewBorrowIndexList = _model.GetGridViewBorrowIndexList();
            _gridViewBorrowQuantityList = _model.GetGridViewBorrowQuantityList();
        }

        // 控制上一頁
        public void ControlUpPageButton(int nowPage)
        {
            if (nowPage == 1)
                DisableUpPageButton();
            EnableDownPageButton();
        }

        // 控制下一頁
        public void ControlDownPageButton(int nowPage, int totalPage)
        {
            if (nowPage == totalPage)
                DisableDownPageButton();
            if (nowPage != 1)
                EnableUpPageButton();
        }

        // 檢查借書
        public bool CheckBorrow(int total)
        {
            if (total < FIVE)
                return true;
            else
                return false;
        }

        // 書本計算
        public void CountNowTabBook(int nowTabTotal)
        {
            _categorySize = _model.GetCategorySize();
            _tabFirstBook = 0;
            _tabLastBook = 0;
            for (int i = 0; i < nowTabTotal; i++)
                _tabFirstBook += _categorySize[i];
            for (int i = 0; i < nowTabTotal + 1; i++)
                _tabLastBook += _categorySize[i];
            _tabLastBook--;
        }

        // 取得Tab裡最後一本書編號
        public int GetTabFirstBook()
        {
            return _tabFirstBook;
        }

        // 取得Tab裡第一本書編號
        public int GetTabLastBook()
        {
            return _tabLastBook;
        }

        // AddButton啟用
        public void AddButtonEnable()
        {
            _isAddButtonEnable = true;
        }

        // AddButton停用
        public void AddButtonDisable()
        {
            _isAddButtonEnable = false;
        }

        // 回傳AddButton狀態
        public bool IsAddButtonEnable()
        {
            return _isAddButtonEnable;
        }

        // UpPageButton啟用
        public void EnableUpPageButton()
        {
            _isUpPageButtonEnable = true;
        }

        // UpPageButton停用
        public void DisableUpPageButton()
        {
            _isUpPageButtonEnable = false;
        }

        // 回傳UpPageButton狀態
        public bool IsUpPageButtonEnable()
        {
            return _isUpPageButtonEnable;
        }

        // DownPageButton啟用
        public void EnableDownPageButton()
        {
            _isDownPageButtonEnable = true;
        }

        // DownPageButton停用
        public void DisableDownPageButton()
        {
            _isDownPageButtonEnable = false;
        }

        // 回傳DownPageButton狀態
        public bool IsDownPageButtonEnable()
        {
            return _isDownPageButtonEnable;
        }

        // BookButton全部停用
        public void DisableBookButton()
        {
            for (int i = 0; i < _totalButton; i++)
                _bookButton[i] = false;
        }

        // BookButton啟用
        public void EnableBookButton(int button)
        {
            _bookButton[button] = true;
        }

        // 回傳BookButton狀態
        public bool IsBookButtonEnable(int tag)
        {
            return _bookButton[tag];
        }

        // CheckBookButton全部停用
        public void DisableCheckBookButton()
        {
            _isCheckBookButtonEnable = false;
        }

        // CheckBookButton啟用
        public void EnableCheckBookButton()
        {
            _isCheckBookButtonEnable = true;
        }

        // 回傳CheckBookButton狀態
        public bool IsCheckBookButtonEnable()
        {
            return _isCheckBookButtonEnable;
        }

        // BackPackButton全部停用
        public void DisableBackPackButton()
        {
            _isBackPackButtonEnable = false;
        }

        // BackPackBookButton啟用
        public void EnableBackPackButton()
        {
            _isBackPackButtonEnable = true;
        }

        // 回傳BackPackButton狀態
        public bool IsBackPackButtonEnable()
        {
            return _isBackPackButtonEnable;
        }
    }
}
