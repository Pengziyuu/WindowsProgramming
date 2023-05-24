
namespace HomeWork
{
    partial class BookManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._titleLabel = new System.Windows.Forms.Label();
            this._listBox = new System.Windows.Forms.ListBox();
            this._bookItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._addButton = new System.Windows.Forms.Button();
            this._groupBox = new System.Windows.Forms.GroupBox();
            this._sourceTextBox = new System.Windows.Forms.TextBox();
            this._publishTextBox = new System.Windows.Forms.TextBox();
            this._numberTextBox = new System.Windows.Forms.TextBox();
            this._peopleTextBox = new System.Windows.Forms.TextBox();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._sourceLabel = new System.Windows.Forms.Label();
            this._publishLabel = new System.Windows.Forms.Label();
            this._categoryLabel = new System.Windows.Forms.Label();
            this._peopleLabel = new System.Windows.Forms.Label();
            this._numberLabel = new System.Windows.Forms.Label();
            this._nameLabel = new System.Windows.Forms.Label();
            this._comboBox = new System.Windows.Forms.ComboBox();
            this._browseButton = new System.Windows.Forms.Button();
            this._saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._bookItemBindingSource)).BeginInit();
            this._groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _titleLabel
            // 
            this._titleLabel.AutoSize = true;
            this._titleLabel.Font = new System.Drawing.Font("新細明體", 18F);
            this._titleLabel.Location = new System.Drawing.Point(284, 9);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(231, 36);
            this._titleLabel.TabIndex = 1;
            this._titleLabel.Text = "館藏管理系統";
            // 
            // _listBox
            // 
            this._listBox.DataSource = this._listBox.CustomTabOffsets;
            this._listBox.DisplayMember = "Name";
            this._listBox.FormattingEnabled = true;
            this._listBox.ItemHeight = 18;
            this._listBox.Location = new System.Drawing.Point(12, 58);
            this._listBox.Name = "_listBox";
            this._listBox.Size = new System.Drawing.Size(250, 310);
            this._listBox.TabIndex = 2;
            this._listBox.ValueMember = "IsBookNumber";
            this._listBox.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
            // 
            // _bookItemBindingSource
            // 
            this._bookItemBindingSource.DataSource = typeof(HomeWork.BookItem);
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(12, 404);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(250, 34);
            this._addButton.TabIndex = 3;
            this._addButton.Text = "新增書籍";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // _groupBox
            // 
            this._groupBox.Controls.Add(this._sourceTextBox);
            this._groupBox.Controls.Add(this._publishTextBox);
            this._groupBox.Controls.Add(this._numberTextBox);
            this._groupBox.Controls.Add(this._peopleTextBox);
            this._groupBox.Controls.Add(this._nameTextBox);
            this._groupBox.Controls.Add(this._sourceLabel);
            this._groupBox.Controls.Add(this._publishLabel);
            this._groupBox.Controls.Add(this._categoryLabel);
            this._groupBox.Controls.Add(this._peopleLabel);
            this._groupBox.Controls.Add(this._numberLabel);
            this._groupBox.Controls.Add(this._nameLabel);
            this._groupBox.Controls.Add(this._comboBox);
            this._groupBox.Controls.Add(this._browseButton);
            this._groupBox.Location = new System.Drawing.Point(290, 58);
            this._groupBox.Name = "_groupBox";
            this._groupBox.Size = new System.Drawing.Size(498, 340);
            this._groupBox.TabIndex = 4;
            this._groupBox.TabStop = false;
            this._groupBox.Text = "編輯書籍";
            // 
            // _sourceTextBox
            // 
            this._sourceTextBox.Location = new System.Drawing.Point(112, 289);
            this._sourceTextBox.Name = "_sourceTextBox";
            this._sourceTextBox.Size = new System.Drawing.Size(270, 29);
            this._sourceTextBox.TabIndex = 16;
            this._sourceTextBox.TextChanged += new System.EventHandler(this.ChangedSourceTextBoxText);
            // 
            // _publishTextBox
            // 
            this._publishTextBox.Location = new System.Drawing.Point(112, 235);
            this._publishTextBox.Name = "_publishTextBox";
            this._publishTextBox.Size = new System.Drawing.Size(359, 29);
            this._publishTextBox.TabIndex = 15;
            this._publishTextBox.TextChanged += new System.EventHandler(this.PublishTextBoxTextChanged);
            // 
            // _numberTextBox
            // 
            this._numberTextBox.Location = new System.Drawing.Point(112, 88);
            this._numberTextBox.Name = "_numberTextBox";
            this._numberTextBox.Size = new System.Drawing.Size(175, 29);
            this._numberTextBox.TabIndex = 14;
            this._numberTextBox.TextChanged += new System.EventHandler(this.NumberTextBoxTextChanged);
            // 
            // _peopleTextBox
            // 
            this._peopleTextBox.Location = new System.Drawing.Point(112, 133);
            this._peopleTextBox.Name = "_peopleTextBox";
            this._peopleTextBox.Size = new System.Drawing.Size(175, 29);
            this._peopleTextBox.TabIndex = 13;
            this._peopleTextBox.TextChanged += new System.EventHandler(this.PeopleTextBoxTextChanged);
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(112, 39);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(359, 29);
            this._nameTextBox.TabIndex = 12;
            this._nameTextBox.TextChanged += new System.EventHandler(this.NameTextBoxTextChanged);
            // 
            // _sourceLabel
            // 
            this._sourceLabel.AutoSize = true;
            this._sourceLabel.Location = new System.Drawing.Point(6, 292);
            this._sourceLabel.Name = "_sourceLabel";
            this._sourceLabel.Size = new System.Drawing.Size(100, 18);
            this._sourceLabel.TabIndex = 11;
            this._sourceLabel.Text = "圖片路徑(*)";
            // 
            // _publishLabel
            // 
            this._publishLabel.AutoSize = true;
            this._publishLabel.Location = new System.Drawing.Point(6, 240);
            this._publishLabel.Name = "_publishLabel";
            this._publishLabel.Size = new System.Drawing.Size(82, 18);
            this._publishLabel.TabIndex = 10;
            this._publishLabel.Text = "出版項(*)";
            // 
            // _categoryLabel
            // 
            this._categoryLabel.AutoSize = true;
            this._categoryLabel.Location = new System.Drawing.Point(6, 190);
            this._categoryLabel.Name = "_categoryLabel";
            this._categoryLabel.Size = new System.Drawing.Size(100, 18);
            this._categoryLabel.TabIndex = 9;
            this._categoryLabel.Text = "書籍類別(*)";
            // 
            // _peopleLabel
            // 
            this._peopleLabel.AutoSize = true;
            this._peopleLabel.Location = new System.Drawing.Point(6, 136);
            this._peopleLabel.Name = "_peopleLabel";
            this._peopleLabel.Size = new System.Drawing.Size(100, 18);
            this._peopleLabel.TabIndex = 8;
            this._peopleLabel.Text = "書籍作者(*)";
            // 
            // _numberLabel
            // 
            this._numberLabel.AutoSize = true;
            this._numberLabel.Location = new System.Drawing.Point(6, 88);
            this._numberLabel.Name = "_numberLabel";
            this._numberLabel.Size = new System.Drawing.Size(100, 18);
            this._numberLabel.TabIndex = 7;
            this._numberLabel.Text = "書籍編號(*)";
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(6, 42);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(100, 18);
            this._nameLabel.TabIndex = 6;
            this._nameLabel.Text = "書籍名稱(*)";
            // 
            // _comboBox
            // 
            this._comboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this._bookItemBindingSource, "Category", true));
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Location = new System.Drawing.Point(112, 187);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(175, 26);
            this._comboBox.TabIndex = 0;
            // 
            // _browseButton
            // 
            this._browseButton.Location = new System.Drawing.Point(388, 281);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(104, 40);
            this._browseButton.TabIndex = 5;
            this._browseButton.Text = "瀏覽";
            this._browseButton.UseVisualStyleBackColor = true;
            this._browseButton.Click += new System.EventHandler(this.ClickBrowseButton);
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(538, 404);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(250, 34);
            this._saveButton.TabIndex = 6;
            this._saveButton.Text = "儲存";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.ClickSaveButton);
            // 
            // BookManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this._groupBox);
            this.Controls.Add(this._addButton);
            this.Controls.Add(this._listBox);
            this.Controls.Add(this._titleLabel);
            this.Name = "BookManagementForm";
            this.Text = "BookManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this._bookItemBindingSource)).EndInit();
            this._groupBox.ResumeLayout(false);
            this._groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.ListBox _listBox;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.GroupBox _groupBox;
        private System.Windows.Forms.ComboBox _comboBox;
        private System.Windows.Forms.Button _browseButton;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Label _sourceLabel;
        private System.Windows.Forms.Label _publishLabel;
        private System.Windows.Forms.Label _categoryLabel;
        private System.Windows.Forms.Label _peopleLabel;
        private System.Windows.Forms.Label _numberLabel;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.TextBox _sourceTextBox;
        private System.Windows.Forms.TextBox _publishTextBox;
        private System.Windows.Forms.TextBox _numberTextBox;
        private System.Windows.Forms.TextBox _peopleTextBox;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.BindingSource _bookItemBindingSource;
    }
}