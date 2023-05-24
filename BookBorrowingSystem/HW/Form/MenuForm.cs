using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class MenuForm : Form
    {
        MenuPresentationModel _menuPresentationModel = new MenuPresentationModel();
        Model _model;

        public MenuForm()
        {
            InitializeComponent();
            _model = new Model();
            _model.ReadData();
        }

        // 借書按鈕事件
        private void BookBorrowingButtonClick(object sender, EventArgs e)
        {
            BookBorrowingForm bookBorrowingForm = new BookBorrowingForm(_model);
            _menuPresentationModel.ChangeBorrowingButtonState();
            RefreshState();
            bookBorrowingForm.Show();
            bookBorrowingForm.FormClosing += new FormClosingEventHandler(ClosingBookBorrowingForm);
        }

        // 借書視窗關閉事件
        private void ClosingBookBorrowingForm(object sender, CancelEventArgs e)
        {
            _menuPresentationModel.ChangeBorrowingButtonState();
            RefreshState();
        }

        // 書庫存按鈕事件
        private void BookInventoryButtonClick(object sender, EventArgs e)
        {
            BookInventoryForm bookInventoryForm = new BookInventoryForm(_model);
            _menuPresentationModel.ChangeInventoryButtonState();
            RefreshState();
            bookInventoryForm.Show();
            bookInventoryForm.FormClosing += new FormClosingEventHandler(ClosingBookInventoryForm);
        }

        // 書庫視窗關閉事件
        private void ClosingBookInventoryForm(object sender, CancelEventArgs e)
        {
            _menuPresentationModel.ChangeInventoryButtonState();
            RefreshState();
        }
 
        // 離開按鈕事件
        private void ExitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        // 館藏按鈕事件
        private void BookManagementButtonClick(object sender, EventArgs e)
        {
            BookManagementForm bookManagementForm = new BookManagementForm(_model);
            _menuPresentationModel.ChangeManagementButtonState();
            RefreshState();
            bookManagementForm.Show();
            bookManagementForm.FormClosing += new FormClosingEventHandler(ClosingBookManagementForm);
        }

        // 館藏視窗關閉事件
        private void ClosingBookManagementForm(object sender, CancelEventArgs e)
        {
            _menuPresentationModel.ChangeManagementButtonState();
            RefreshState();
        }

        // 更新狀態
        public void RefreshState()
        {
            _bookBorrowingButton.Enabled = _menuPresentationModel.IsBorrowingButtonEnable();
            _bookInventoryButton.Enabled = _menuPresentationModel.IsInventoryButtonEnable();
            _bookManagementButton.Enabled = _menuPresentationModel.IsManagementButtonEnable();
        }
    }
}
