using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class BackPackForm : Form
    {
        private const string DATE = "yyyy/MM/dd";
        List<Book> _book = new List<Book>();
        Model _model;
        BackPackPresentationModel _backPackPresentationModel = new BackPackPresentationModel();
        List<Book> _borrowBook = new List<Book>();
        List<int> _borrowQuantityList = new List<int>();
        List<int> _borrowIndexList = new List<int>();
        BindingList<BookItem> _backPackData;
        BindingList<BookItem> _bookItemsList;
        private const string ERROR = "還書錯誤";

        public BackPackForm(Model model)
        {
            InitializeComponent();

            _model = model;
            _book = _model.GetBook();
            _backPackData = _model.GetBackPackData();
            _bookItemsList = _model.GetBookItem();
            _bookDataGridView.DataSource = _backPackData;
            SetDataGridView();
        }

        private BindingManagerBase BindingManager
        {
            get
            { 
                return BindingContext[_model.GetBookItem()]; 
            }
        }

        // 設定DataGridView1
        public void SetDataGridView()
        {
            DataGridViewButtonColumn deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            deleteColumn.HeaderText = "還書";
            deleteColumn.Name = "_deleteColumn";
            deleteColumn.Text = "歸還";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.FillWeight = 50;
            _bookDataGridView.Columns.Insert(0, deleteColumn);
            _bookDataGridView.CellContentClick += ReturnColumn;
            _bookDataGridView.RowHeadersVisible = false;
            _bookDataGridView.AllowUserToAddRows = false;
            _bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _bookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        }

        // 還書判斷
        private void ReturnColumn(object sender, DataGridViewCellEventArgs e)
        {
            GetData();
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                int quantity = int.Parse(_bookDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                int max = _borrowQuantityList[e.RowIndex];
                if (quantity < 1)
                    MessageBox.Show("您至少要歸還1本書", ERROR);
                else if (quantity > max)
                    MessageBox.Show("還書數量不能超過已借數量", ERROR);
                else
                {
                    MessageBox.Show("【" + _bookDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() + "】已成功歸還" + quantity + "本", "歸還結果");
                    ReturnBook(quantity, max, e.RowIndex);
                }
            }
        }

        // 讀資料
        private void GetData()
        {
            _borrowQuantityList = _model.GetBorrowQuantityList();
            _borrowIndexList = _model.GetBorrowIndexList();
            _borrowBook = _model.GetBorrowList();
        }

        // 還書
        private void ReturnBook(int quantity, int max, int index)
        {
            for (int i = 0; i < quantity; i++)
            {
                BindingManager.Position = _borrowIndexList[index];
                _model.ReturnBook(BindingManager.Position);
                _borrowQuantityList[index]--;
                _bookItemsList[BindingManager.Position].QuantityBorrowed--;
            }
            if (quantity == max)
            {
                _bookItemsList[BindingManager.Position].ReturnNumber = 1;
                _bookDataGridView.Rows.RemoveAt(index);
                _borrowQuantityList.RemoveAt(index);
                _borrowBook.RemoveAt(index);
                _borrowIndexList.RemoveAt(index);
            }
        }
    }
}
