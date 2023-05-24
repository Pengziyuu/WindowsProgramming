using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class BookAddingForm : Form
    {
        BookAddingPresentationModel _bookAddingPresentationModel;
        BindingList<BookItem> _bookItem;
        Model _model;

        public BookAddingForm(Model model, int index)
        {
            _bookAddingPresentationModel = new BookAddingPresentationModel();
            _model = model;
            _bookItem = _model.GetBookItem();
            BindingManager.Position = index;

            InitializeComponent();
            _richTextBox1.DataBindings.Add("Text", _bookItem, "AddBookData");
        }

        private BindingManagerBase BindingManager
        {
            get 
            { 
                return BindingContext[_model.GetBookItem()]; 
            }
        }

        // TextBox只能輸入數字
        public void LimitInput(object sender, KeyPressEventArgs e)
        {
            if (_bookAddingPresentationModel.CheckNumber(e.KeyChar))
                e.Handled = true;
        }

        // 確認按鈕
        private void ClickOkButton(object sender, EventArgs e)
        {
            int quantity = 0;
            if (_textBox.Text != "")
                quantity = int.Parse(_textBox.Text);
            if (_textBox.Text != "")
                for (int i = 0; i < quantity; i++)
                    _model.ReturnBook(BindingManager.Position);
            _textBox.Clear();
        }

        // 取消按鈕
        private void ClickCancelButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
