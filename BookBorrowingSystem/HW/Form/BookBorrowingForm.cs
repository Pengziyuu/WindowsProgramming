using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class BookBorrowingForm : Form
    {
        BindingList<BookItem> _bookItem;
        BindingList<BookItem> _dataGridViewData = new BindingList<BookItem>();
        List<Book> _book;
        List<Book> _gridViewBorrowList = new List<Book>();
        List<int> _gridViewBorrowQuantityList = new List<int>();
        List<int> _gridViewBorrowIndexList = new List<int>();
        private const int TWO = 2;
        private const int THREE = 3;
        private const int FIVE = 5;
        private int _nowBook = 0;
        private int _borrowQuantity = 0;
        private int _bookButtonCount = 0;
        private int _totalButton = 0;
        private int _totalPage = 0;
        private int _nowTab = 0;
        private int _nowPage = 1;
        private int _tabFirstBook = 0;
        private int _tabLastBook = 0;
        private int _error = 0;
        private int _buttonData = 0;
        private int[] _categorySize;
        private string[] _category = { };
        private const string BORROW = "借書數量 : ";
        private const string TEXT = "Text";
        private const string SOURCE = "../../../image/trash_can.png";
        private const string ERROR1 = "該書本剩餘數量不足";
        private const string ERROR2 = "同本書一次限借兩本";
        private const string ERROR3 = "每次借書限借五本，您的借書單已滿";
        private const string ERROR4 = "庫存狀態";
        private const string ERROR5 = "借書違規";
        BookBorrowingPresentationModel _bookBorrowingPresentationModel;
        BackPackForm _backPackForm;
        Model _model;

        public BookBorrowingForm(Model model)
        {
            InitializeComponent();
            _model = model;
            _model._modelChanged += Construct;
            _bookItem = _model.GetBookItem();
            _book = _model.GetBook();
            _gridViewBorrowList = _model.GetGridViewBorrowList();
            _gridViewBorrowQuantityList = _model.GetGridViewBorrowQuantityList();
            _gridViewBorrowIndexList = _model.GetGridViewBorrowIndexList();
            _lastLabel.DataBindings.Add(new Binding(TEXT, _bookItem, "Quantity"));
            _bookRichTextBox.DataBindings.Add(TEXT, _bookItem, "BookData");
            _bookDataGridView.DataSource = _dataGridViewData;

            _bookBorrowingPresentationModel = new BookBorrowingPresentationModel(_model);
            _totalPage = _bookBorrowingPresentationModel.GetTotalPage();
            _totalButton = _bookBorrowingPresentationModel.GetTotalButton();
            CreateTagPage();
            SetDataGridView();
            RefreshState();
        }

        private BindingManagerBase BindingManager
        {
            get 
            { 
                return BindingContext[_bookItem]; 
            }
        }

        // 設定DataGridView
        public void SetDataGridView()
        {
            DataGridViewButtonColumn deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            deleteColumn.HeaderText = "刪除";
            deleteColumn.Name = "_deleteColumn";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.FillWeight = 50;
            _bookDataGridView.Columns.Insert(0, deleteColumn);
            _bookDataGridView.CellContentClick += DeleteRow;
            _bookDataGridView.CellValueChanged += ChangeCellValue;
            _bookDataGridView.EditingControlShowing += EditingControlShowing;
            _bookDataGridView.RowHeadersVisible = false;
            _bookDataGridView.AllowUserToAddRows = false;
            _bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _bookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        }

        // 刪除列
        private void DeleteRow(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex >= 0)
                {
                    _borrowQuantity -= int.Parse(_bookDataGridView[2, e.RowIndex].Value.ToString());
                    _dataGridViewData[e.RowIndex].Number = 1;
                    _bookDataGridView.Rows.RemoveAt(e.RowIndex);
                    _gridViewBorrowList.RemoveAt(e.RowIndex);
                    _gridViewBorrowQuantityList.RemoveAt(e.RowIndex);
                    _gridViewBorrowIndexList.RemoveAt(e.RowIndex);
                    RefreshState();
                }
            }
        }

        // Cell值改變事件
        private void ChangeCellValue(object sender, DataGridViewCellEventArgs e)
        {
            int quantity = int.Parse(_bookDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
            _error = _bookBorrowingPresentationModel.CheckQuantity(quantity, e.RowIndex);
            if (_error == 0)
            {
                if (quantity > _gridViewBorrowQuantityList[e.RowIndex])
                    _borrowQuantity++;
                else 
                    _borrowQuantity--;
                _gridViewBorrowQuantityList[e.RowIndex] = quantity;
            }
            else
            {
                ShowError(_error);
                ControlCell(e.ColumnIndex, e.RowIndex);
            }
            _bookDataGridView.RefreshEdit();
            RefreshState();
        }

        // 顯示錯誤訊息
        private void ShowError(int error)
        {
            if (error == 1)
                MessageBox.Show(ERROR1, ERROR4);
            else if (error == TWO)
                MessageBox.Show(ERROR2, ERROR5);
            else if (error == THREE)
                MessageBox.Show(ERROR3, ERROR5);
        }

        // Cell控制
        private void ControlCell(int columnIndex, int rowIndex)
        {
            _gridViewBorrowQuantityList[rowIndex]--;
            _borrowQuantity--;
            _bookDataGridView[columnIndex, rowIndex].Value = (int.Parse(_bookDataGridView[columnIndex, rowIndex].Value.ToString()) - 1).ToString();
        }

        // Cell事件設定
        private void EditTextChanged(object sender, EventArgs e)
        {
            _bookDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        // Cell事件設定
        private void EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.TextChanged -= EditTextChanged;
            e.Control.TextChanged += EditTextChanged;
        }

        // 依照分類數量新增TagPage
        private void CreateTagPage()
        {
            GetCategoryData();
            _bookButtonCount = 0;
            int nowCategory = 0;
            for (int i = 0; i < _category.Length; i++)
            {
                if (_categorySize[i] != 0)
                {
                    var tab = new TabPage(_category[i]);
                    tab.Tag = nowCategory;
                    AddButton(nowCategory, tab);
                    _bookTabControl.TabPages.Add(tab);
                    _bookTabControl.Click += ClickTab;
                    nowCategory = nowCategory + 1;
                }
            }
            ControlBookVisible();
        }

        // 取得分類資料
        private void GetCategoryData()
        {
            _category = _model.GetCategoryArray();
            _categorySize = _model.GetCategorySize();
        }

        // Tab點擊
        private void ClickTab(object sender, EventArgs e)
        {
            var tab = (TabControl)sender;
            _nowTab = (int)tab.SelectedTab.Tag;
            _totalPage = _categorySize[_nowTab] / THREE;
            if (_categorySize[_nowTab] % THREE != 0)
                _totalPage++;
            _nowPage = 1;
            _bookBorrowingPresentationModel.AddButtonDisable();
            _bookBorrowingPresentationModel.DisableUpPageButton();
            _bookBorrowingPresentationModel.EnableDownPageButton();
            ControlBookVisible();
            RefreshState();
        }

        // 在TagPage新增按鈕
        private void AddButton(int nowCategory, TabPage tab)
        {
            _buttonData = 0;
            for (int i = 0; i < _categorySize[nowCategory]; i++)
            {
                int BTN_HEIGHT = _bookRichTextBox.Size.Height - FIVE;
                int BTN_WIDTH = _bookRichTextBox.Size.Width / THREE;
                var button = new Button();
                tab.Controls.Add(button);
                AddButtonData(button, nowCategory);
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.Left = tab.Left + BTN_WIDTH * (i % THREE);
                button.Top = tab.Top;
                button.Height = BTN_HEIGHT;
                button.Width = BTN_WIDTH;
                button.Click += BookButtonClick;
                button.FlatStyle = FlatStyle.Flat;
                _bookButtonCount++;
            }
        }

        // 加入按鈕資料
        private void AddButtonData(Button button, int nowCategory)
        {
            for (int j = _buttonData; j < _bookItem.Count; j++)
            {
                if (_bookItem[j].Category == _category[nowCategory])
                {
                    button.Tag = _bookButtonCount;
                    button.Text = j.ToString();
                    button.ForeColor = button.BackColor;
                    button.DataBindings.Add("BackgroundImage", _bookItem[j], "Image");
                    _buttonData = j + 1;
                    break;
                }
            }
        }

        // 書籤按鈕事件
        private void BookButtonClick(object sender, EventArgs e)
        {
            var tagButton = (Button)sender;
            _nowBook = int.Parse(tagButton.Text);
            BindingManager.Position = int.Parse(tagButton.Text);
            RefreshState();
        }

        // 加入借書單按鈕事件
        private void AddButtonClick(object sender, EventArgs e)
        {
            BorrowBook();
            RefreshState();
        }

        // 檢查借書
        private void BorrowBook()
        {
            _error = _bookBorrowingPresentationModel.CheckQuantity(-1, 0);
            if (_error == THREE)
                MessageBox.Show(ERROR3, ERROR5);
            else
                AddBooks();
        }

        // 加入書本
        private void AddBooks()
        {
            Book newBook = new Book();
            newBook.SetBook(0, _book[_nowBook].GetName());
            newBook.SetBook(1, _book[_nowBook].GetIsBookNumber());
            newBook.SetBook(TWO, _book[_nowBook].GetAuthor());
            newBook.SetBook(THREE, _book[_nowBook].GetPublish());

            _gridViewBorrowList.Add(newBook);
            _gridViewBorrowQuantityList.Add(1);
            _gridViewBorrowIndexList.Add(_nowBook);

            _dataGridViewData.Add(_bookItem[_nowBook]);
            _borrowQuantity += _bookItem[_nowBook].Number;
        }

        // 書包按鈕事件
        private void BackPackButtonClick(object sender, EventArgs e)
        {
            _backPackForm = new BackPackForm(_model);
            _backPackForm.Show();
            _backPackForm.FormClosing += CloseBackFrom;
            _bookBorrowingPresentationModel.DisableBackPackButton();
            RefreshState();
        }

        // 書包視窗關閉
        private void CloseBackFrom(object sender, EventArgs e)
        {
            _bookBorrowingPresentationModel.EnableBackPackButton();
            RefreshState();
        }

        // 刪除按鈕圖案
        private void PatingGridCell(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) 
                return;
            if (e.ColumnIndex == 0)
            {
                Image img = Image.FromFile(SOURCE);
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = img.Width;
                var h = img.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / TWO;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / TWO;
                e.Graphics.DrawImage(img, new Rectangle(e.CellBounds.Left + (e.CellBounds.Width - w) / TWO, y, w, h));
                e.Handled = true;
            }
        }

        // 上一頁
        private void ClickUpPageButton(object sender, EventArgs e)
        {
            _nowPage--;
            _bookBorrowingPresentationModel.ControlUpPageButton(_nowPage);
            ControlBookVisible();
            RefreshState();
        }

        //下一頁
        private void ClickDownPageButton(object sender, EventArgs e)
        {
            _nowPage++;
            _bookBorrowingPresentationModel.ControlDownPageButton(_nowPage, _totalPage);
            ControlBookVisible();
            RefreshState();
        }

        // 確認借書按鈕
        private void ClickBorrowButton(object sender, EventArgs e)
        {
            MessageBox.Show(_bookBorrowingPresentationModel.GetBorrowMessage());
            for (int i = 0; i < _gridViewBorrowIndexList.Count(); i++)
            {
                _dataGridViewData[i].Number = 1;
                for (int j = 0; j < _gridViewBorrowQuantityList[i]; j++)
                {
                    _model.BorrowBook(BindingManager.Position = _gridViewBorrowIndexList[i]);
                }
            }
            _bookBorrowingPresentationModel.SetBookList();

            ClearDataGridView();
            RefreshState();
        }

        // 清空借書單
        private void ClearDataGridView()
        {
            _gridViewBorrowList.Clear();
            _gridViewBorrowQuantityList.Clear();
            _gridViewBorrowIndexList.Clear();
            _bookDataGridView.Rows.Clear();
            _borrowQuantity = 0;
        }

        // 書本可見控制
        private void ControlBookVisible()
        {
            _bookBorrowingPresentationModel.CountNowTabBook(_nowTab);
            _tabFirstBook = _bookBorrowingPresentationModel.GetTabFirstBook();
            _tabLastBook = _bookBorrowingPresentationModel.GetTabLastBook();
            int temp = 0;
            _bookBorrowingPresentationModel.DisableBookButton();
            for (int i = _tabFirstBook + (_nowPage - 1) * THREE; i < _tabLastBook + 1; i++)
            {
                _bookBorrowingPresentationModel.EnableBookButton(i);
                temp++;
                if (temp == THREE)
                    break;
            }
        }

        // 更新狀態
        private void RefreshState()
        {
            _bookBorrowingPresentationModel.Refresh(_nowBook, _bookDataGridView.Rows.Count);
            _bookBorrowingPresentationModel.ControlDownPageButton(_nowPage, _totalPage);
            RefreshButton();
            RefreshText();
        }

        // 更新按鈕
        private void RefreshButton()
        {
            _addButton.Enabled = _bookBorrowingPresentationModel.IsAddButtonEnable();
            _upPageButton.Enabled = _bookBorrowingPresentationModel.IsUpPageButtonEnable();
            _downPageButton.Enabled = _bookBorrowingPresentationModel.IsDownPageButtonEnable();
            _checkBorrowButton.Enabled = _bookBorrowingPresentationModel.IsCheckBookButtonEnable();
            _backPackButton.Enabled = _bookBorrowingPresentationModel.IsBackPackButtonEnable();
            foreach (Object button in this._bookTabControl.SelectedTab.Controls)
                for (int i = 0; i < _totalButton; i++)
                    if ((int)(((Button)button).Tag) == i)
                        ((Button)button).Visible = _bookBorrowingPresentationModel.IsBookButtonEnable(i);
        }

        // 更新文字
        private void RefreshText()
        {
            _nowPageLabel.Text = "Page : " + _nowPage.ToString() + " / " + _totalPage.ToString();
            _borrowLabel.Text = BORROW + (_borrowQuantity).ToString();
        }

        // 重新建構書籍
        private void Construct()
        {
            _bookTabControl.TabPages.Clear();
            _nowTab = 0;
            CreateTagPage();

            _totalPage = _categorySize[_nowTab] / THREE;
            if (_categorySize[_nowTab] % THREE != 0)
                _totalPage++;
            _nowPage = 1;
            _bookBorrowingPresentationModel.AddButtonDisable();
            _bookBorrowingPresentationModel.DisableUpPageButton();
            _bookBorrowingPresentationModel.EnableDownPageButton();
            ControlBookVisible();
            RefreshState();
        }
    }
}
