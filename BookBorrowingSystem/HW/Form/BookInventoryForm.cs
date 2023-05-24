using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class BookInventoryForm : Form
    {
        BindingList<BookItem> _bookItem;
        List<Book> _book;
        private int[] _categorySize;
        private string[] _category = { };
        private const int TWO = 2;
        private const int SIX = 6;
        private const string SOURCE = "../../../image/replenishment.png";
        private const string NAME1 = "書籍名稱";
        private const string NAME2 = "書籍類別";
        private const string NAME3 = "數量";
        private const string IMAGE = "Image";
        Model _model;

        public BookInventoryForm(Model model)
        {
            InitializeComponent();
            _model = model;
            _bookItem = _model.GetBookItem();
            _book = _model.GetBook();
            _category = _model.GetCategoryArray();
            _categorySize = _model.GetCategorySize();
            _inventoryDataGridView.DataSource = _model.GetBookItem();
            _inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _inventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            _richTextBox.DataBindings.Add("Text", _bookItem, "BookData");
            _pictureBox.DataBindings.Add(IMAGE, _bookItem, IMAGE);

            SetDataGridView();
        }

        private BindingManagerBase BindingManager
        {
            get 
            { 
                return BindingContext[_model.GetBookItem()]; 
            }
        }

        // 設定DataGridView
        public void SetDataGridView()
        {
            DataGridViewButtonColumn inventoryColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            inventoryColumn.HeaderText = "補貨";
            inventoryColumn.Name = "_inventoryColumn";
            inventoryColumn.UseColumnTextForButtonValue = true;
            inventoryColumn.FillWeight = 50;
            _inventoryDataGridView.Columns.Add(inventoryColumn);
            _inventoryDataGridView.CellContentClick += OpenBookAddingForm;
            _inventoryDataGridView.RowHeadersVisible = false;
            _inventoryDataGridView.AllowUserToAddRows = false;
            _inventoryDataGridView.Columns[0].HeaderText = NAME1;
            _inventoryDataGridView.Columns[1].HeaderText = NAME2;
            _inventoryDataGridView.Columns[TWO].HeaderText = NAME3;
            _inventoryDataGridView.Columns[0].FillWeight = 180;
            _inventoryDataGridView.Columns[1].FillWeight = 100;
            _inventoryDataGridView.Columns[TWO].FillWeight = 70;
        }

        // 補貨視窗
        public void OpenBookAddingForm(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == SIX)
                {
                    BookAddingForm replenishmentForm = new BookAddingForm(_model, e.RowIndex);
                    replenishmentForm.ShowDialog();
                }
            }
        }

        // 補貨按鈕圖案
        private void PatingGridCell(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == SIX)
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
    }
}
