using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class BookManagementForm : Form
    {
        int _index;
        private const string SOURCE = "../../../image/";
        BookManagementPresentationModel _bookManagementPresentationModel;
        BindingList<BookItem> _bookItem;
        Model _model;

        public BookManagementForm(Model model)
        {
            InitializeComponent();
            _bookManagementPresentationModel = new BookManagementPresentationModel();
            _model = model;
            _bookItem = _model.GetBookItem();

            _listBox.DataSource = _bookItem;
            _comboBox.DataSource = _model.GetCategoryArray();
            _comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBox.SelectedIndexChanged += new EventHandler(SelectedIndexChanged);

            _listBox.ClearSelected();
            RefreshState();
        }

        private BindingManagerBase BindingManager
        {
            get
            {
                return BindingContext[_bookItem];
            }
        }

        // 瀏覽按鈕事件
        private void ClickBrowseButton(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Files|*.jpg;*.jpeg;*.png;";
            dialog.Title = "請選擇書籍圖片";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _sourceTextBox.Text = SOURCE + dialog.FileName.Substring(dialog.FileName.IndexOf("image\\") + 6);
            }
        }

        // 書籍名稱改變事件
        private void NameTextBoxTextChanged(object sender, EventArgs e)
        {
            _bookManagementPresentationModel.EnableSaveButtonEnable();
            RefreshState();
        }

        // 書籍編號改變事件
        private void NumberTextBoxTextChanged(object sender, EventArgs e)
        {
            _bookManagementPresentationModel.EnableSaveButtonEnable();
            RefreshState();
        }

        // 書籍作者改變事件
        private void PeopleTextBoxTextChanged(object sender, EventArgs e)
        {
            _bookManagementPresentationModel.EnableSaveButtonEnable();
            RefreshState();
        }

        // 出版項改變事件
        private void PublishTextBoxTextChanged(object sender, EventArgs e)
        {
            _bookManagementPresentationModel.EnableSaveButtonEnable();
            RefreshState();
        }

        // 圖片路徑改變事件
        private void ChangedSourceTextBoxText(object sender, EventArgs e)
        {
            _bookManagementPresentationModel.EnableSaveButtonEnable();
            RefreshState();
        }

        // 書籍類別選擇Index改變
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            _bookManagementPresentationModel.EnableSaveButtonEnable();
            RefreshState();
        }

        // 儲存按鈕事件
        private void ClickSaveButton(object sender, EventArgs e)
        {
            string newName = _nameTextBox.Text;
            string newIsBookNumber = _numberTextBox.Text;
            string newAuthor = _peopleTextBox.Text;
            string newCategory = _comboBox.Text;
            string newPublish = _publishTextBox.Text;
            string newSource = _sourceTextBox.Text;

            _bookItem[_index].Name = newName;
            _bookItem[_index].IsBookNumber = newIsBookNumber;
            _bookItem[_index].Author = newAuthor;
            _bookItem[_index].Category = newCategory;
            _bookItem[_index].Publish = newPublish;
            _bookItem[_index].Source = newSource;
            _bookItem[_index].Image = Image.FromFile(newSource);
            _model.Send();
            _bookManagementPresentationModel.DisableSaveButtonEnable();
            RefreshState();
        }

        // ListBox Index改變事件
        private void ListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _index = _listBox.SelectedIndex;
            Console.WriteLine(_index);
            if (_index == -1)
            {
                _nameTextBox.Text = "";
                _numberTextBox.Text = "";
                _peopleTextBox.Text = "";
                _comboBox.Text = "";
                _publishTextBox.Text = "";
                _sourceTextBox.Text = "";
                _bookManagementPresentationModel.DisableAll();
            }
            else
            {
                SetTextBox();
            }
            RefreshState();
        }

        // 設定TextBox資料
        public void SetTextBox()
        {
            _nameTextBox.Text = _bookItem[_index].Name;
            _numberTextBox.Text = _bookItem[_index].IsBookNumber;
            _peopleTextBox.Text = _bookItem[_index].Author;
            _comboBox.Text = _bookItem[_index].Category;
            _publishTextBox.Text = _bookItem[_index].Publish;
            _sourceTextBox.Text = _bookItem[_index].Source;
            _bookManagementPresentationModel.EnableAll();
            _bookManagementPresentationModel.DisableSaveButtonEnable();
        }

        // 檢查為空事件
        private void CheckNull()
        {
            if (_nameTextBox.Text == "")
                _bookManagementPresentationModel.DisableSaveButtonEnable();
            if (_numberTextBox.Text == "")
                _bookManagementPresentationModel.DisableSaveButtonEnable();
            if (_peopleTextBox.Text == "")
                _bookManagementPresentationModel.DisableSaveButtonEnable();
            if (_publishTextBox.Text == "")
                _bookManagementPresentationModel.DisableSaveButtonEnable();
            if (_sourceTextBox.Text == "")
                _bookManagementPresentationModel.DisableSaveButtonEnable();
        }

        // 更新狀態
        private void RefreshState()
        {
            CheckNull();
            _addButton.Enabled = _bookManagementPresentationModel.IsAddButtonEnable();
            _browseButton.Enabled = _bookManagementPresentationModel.IsBrowseButtonEnable();
            _saveButton.Enabled = _bookManagementPresentationModel.IsSaveButtonEnable();
            _nameTextBox.Enabled = _bookManagementPresentationModel.IsNameEnable();
            _numberTextBox.Enabled = _bookManagementPresentationModel.IsNumberEnable();
            _peopleTextBox.Enabled = _bookManagementPresentationModel.IsPeopleEnable();
            _comboBox.Enabled = _bookManagementPresentationModel.IsCategoryEnable();
            _publishTextBox.Enabled = _bookManagementPresentationModel.IsPublishEnable();
            _sourceTextBox.Enabled = _bookManagementPresentationModel.IsSourceEnable();
        }
    }
}
