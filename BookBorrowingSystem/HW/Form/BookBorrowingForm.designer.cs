
namespace HomeWork
{
    partial class BookBorrowingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._bookGroupBox1 = new System.Windows.Forms.GroupBox();
            this._downPageButton = new System.Windows.Forms.Button();
            this._upPageButton = new System.Windows.Forms.Button();
            this._nowPageLabel = new System.Windows.Forms.Label();
            this._bookGroupBox2 = new System.Windows.Forms.GroupBox();
            this._label = new System.Windows.Forms.Label();
            this._lastLabel = new System.Windows.Forms.Label();
            this._bookRichTextBox = new System.Windows.Forms.RichTextBox();
            this._addButton = new System.Windows.Forms.Button();
            this._bookTabControl = new System.Windows.Forms.TabControl();
            this._bookDataGridView = new System.Windows.Forms.DataGridView();
            this._nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._numberDataGridViewTextBoxColumn = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this._isBookNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._publishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bookItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._checkBorrowButton = new System.Windows.Forms.Button();
            this._titleLabel = new System.Windows.Forms.Label();
            this._borrowLabel = new System.Windows.Forms.Label();
            this._backPackButton = new System.Windows.Forms.Button();
            this._bookGroupBox1.SuspendLayout();
            this._bookGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bookItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _bookGroupBox1
            // 
            this._bookGroupBox1.Controls.Add(this._downPageButton);
            this._bookGroupBox1.Controls.Add(this._upPageButton);
            this._bookGroupBox1.Controls.Add(this._nowPageLabel);
            this._bookGroupBox1.Controls.Add(this._bookGroupBox2);
            this._bookGroupBox1.Controls.Add(this._addButton);
            this._bookGroupBox1.Controls.Add(this._bookTabControl);
            this._bookGroupBox1.Location = new System.Drawing.Point(10, 9);
            this._bookGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this._bookGroupBox1.Name = "_bookGroupBox1";
            this._bookGroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this._bookGroupBox1.Size = new System.Drawing.Size(389, 469);
            this._bookGroupBox1.TabIndex = 0;
            this._bookGroupBox1.TabStop = false;
            this._bookGroupBox1.Text = "書籍";
            // 
            // _downPageButton
            // 
            this._downPageButton.Font = new System.Drawing.Font("新細明體", 8F);
            this._downPageButton.Location = new System.Drawing.Point(197, 437);
            this._downPageButton.Margin = new System.Windows.Forms.Padding(2);
            this._downPageButton.Name = "_downPageButton";
            this._downPageButton.Size = new System.Drawing.Size(92, 27);
            this._downPageButton.TabIndex = 9;
            this._downPageButton.Text = "下一頁";
            this._downPageButton.UseVisualStyleBackColor = true;
            this._downPageButton.Click += new System.EventHandler(this.ClickDownPageButton);
            // 
            // _upPageButton
            // 
            this._upPageButton.Enabled = false;
            this._upPageButton.Font = new System.Drawing.Font("新細明體", 8F);
            this._upPageButton.Location = new System.Drawing.Point(101, 437);
            this._upPageButton.Margin = new System.Windows.Forms.Padding(2);
            this._upPageButton.Name = "_upPageButton";
            this._upPageButton.Size = new System.Drawing.Size(92, 27);
            this._upPageButton.TabIndex = 8;
            this._upPageButton.Text = "上一頁";
            this._upPageButton.UseVisualStyleBackColor = true;
            this._upPageButton.Click += new System.EventHandler(this.ClickUpPageButton);
            // 
            // _nowPageLabel
            // 
            this._nowPageLabel.AutoSize = true;
            this._nowPageLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F);
            this._nowPageLabel.Location = new System.Drawing.Point(5, 441);
            this._nowPageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._nowPageLabel.Name = "_nowPageLabel";
            this._nowPageLabel.Size = new System.Drawing.Size(92, 20);
            this._nowPageLabel.TabIndex = 7;
            this._nowPageLabel.Text = "Page : 0 / 0";
            // 
            // _bookGroupBox2
            // 
            this._bookGroupBox2.Controls.Add(this._label);
            this._bookGroupBox2.Controls.Add(this._lastLabel);
            this._bookGroupBox2.Controls.Add(this._bookRichTextBox);
            this._bookGroupBox2.Location = new System.Drawing.Point(5, 212);
            this._bookGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this._bookGroupBox2.Name = "_bookGroupBox2";
            this._bookGroupBox2.Padding = new System.Windows.Forms.Padding(2);
            this._bookGroupBox2.Size = new System.Drawing.Size(385, 221);
            this._bookGroupBox2.TabIndex = 3;
            this._bookGroupBox2.TabStop = false;
            this._bookGroupBox2.Text = "書籍介紹";
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Location = new System.Drawing.Point(5, 184);
            this._label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(90, 18);
            this._label.TabIndex = 8;
            this._label.Text = "剩餘數量 :";
            // 
            // _lastLabel
            // 
            this._lastLabel.AutoSize = true;
            this._lastLabel.Location = new System.Drawing.Point(93, 185);
            this._lastLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lastLabel.Name = "_lastLabel";
            this._lastLabel.Size = new System.Drawing.Size(16, 18);
            this._lastLabel.TabIndex = 7;
            this._lastLabel.Text = "0";
            // 
            // _bookRichTextBox
            // 
            this._bookRichTextBox.Location = new System.Drawing.Point(5, 23);
            this._bookRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this._bookRichTextBox.Name = "_bookRichTextBox";
            this._bookRichTextBox.ReadOnly = true;
            this._bookRichTextBox.Size = new System.Drawing.Size(375, 160);
            this._bookRichTextBox.TabIndex = 1;
            this._bookRichTextBox.Text = "";
            // 
            // _addButton
            // 
            this._addButton.Enabled = false;
            this._addButton.Font = new System.Drawing.Font("新細明體", 8F);
            this._addButton.Location = new System.Drawing.Point(293, 437);
            this._addButton.Margin = new System.Windows.Forms.Padding(2);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(92, 27);
            this._addButton.TabIndex = 2;
            this._addButton.Text = "加入借書單";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // _bookTabControl
            // 
            this._bookTabControl.Location = new System.Drawing.Point(5, 23);
            this._bookTabControl.Margin = new System.Windows.Forms.Padding(2);
            this._bookTabControl.Name = "_bookTabControl";
            this._bookTabControl.SelectedIndex = 0;
            this._bookTabControl.Size = new System.Drawing.Size(380, 185);
            this._bookTabControl.TabIndex = 0;
            // 
            // _bookDataGridView
            // 
            this._bookDataGridView.AutoGenerateColumns = false;
            this._bookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._nameDataGridViewTextBoxColumn,
            this._numberDataGridViewTextBoxColumn,
            this._isBookNumberDataGridViewTextBoxColumn,
            this._authorDataGridViewTextBoxColumn,
            this._publishDataGridViewTextBoxColumn});
            this._bookDataGridView.DataSource = this._bookItemBindingSource;
            this._bookDataGridView.Location = new System.Drawing.Point(404, 55);
            this._bookDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this._bookDataGridView.Name = "_bookDataGridView";
            this._bookDataGridView.RowHeadersWidth = 62;
            this._bookDataGridView.RowTemplate.Height = 32;
            this._bookDataGridView.Size = new System.Drawing.Size(592, 376);
            this._bookDataGridView.TabIndex = 1;
            this._bookDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.PatingGridCell);
            // 
            // _nameDataGridViewTextBoxColumn
            // 
            this._nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this._nameDataGridViewTextBoxColumn.FillWeight = 150F;
            this._nameDataGridViewTextBoxColumn.HeaderText = "書籍名稱";
            this._nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._nameDataGridViewTextBoxColumn.Name = "_nameDataGridViewTextBoxColumn";
            // 
            // _numberDataGridViewTextBoxColumn
            // 
            this._numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this._numberDataGridViewTextBoxColumn.FillWeight = 70F;
            this._numberDataGridViewTextBoxColumn.HeaderText = "數量";
            this._numberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._numberDataGridViewTextBoxColumn.Name = "_numberDataGridViewTextBoxColumn";
            this._numberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._numberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // _isBookNumberDataGridViewTextBoxColumn
            // 
            this._isBookNumberDataGridViewTextBoxColumn.DataPropertyName = "IsBookNumber";
            this._isBookNumberDataGridViewTextBoxColumn.HeaderText = "書籍編號";
            this._isBookNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._isBookNumberDataGridViewTextBoxColumn.Name = "_isBookNumberDataGridViewTextBoxColumn";
            // 
            // _authorDataGridViewTextBoxColumn
            // 
            this._authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this._authorDataGridViewTextBoxColumn.FillWeight = 80F;
            this._authorDataGridViewTextBoxColumn.HeaderText = "作者";
            this._authorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._authorDataGridViewTextBoxColumn.Name = "_authorDataGridViewTextBoxColumn";
            // 
            // _publishDataGridViewTextBoxColumn
            // 
            this._publishDataGridViewTextBoxColumn.DataPropertyName = "Publish";
            this._publishDataGridViewTextBoxColumn.FillWeight = 90F;
            this._publishDataGridViewTextBoxColumn.HeaderText = "出版項";
            this._publishDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._publishDataGridViewTextBoxColumn.Name = "_publishDataGridViewTextBoxColumn";
            // 
            // _bookItemBindingSource
            // 
            this._bookItemBindingSource.DataSource = typeof(HomeWork.BookItem);
            // 
            // _checkBorrowButton
            // 
            this._checkBorrowButton.Font = new System.Drawing.Font("新細明體", 8F);
            this._checkBorrowButton.Location = new System.Drawing.Point(885, 438);
            this._checkBorrowButton.Margin = new System.Windows.Forms.Padding(2);
            this._checkBorrowButton.Name = "_checkBorrowButton";
            this._checkBorrowButton.Size = new System.Drawing.Size(110, 43);
            this._checkBorrowButton.TabIndex = 3;
            this._checkBorrowButton.Text = "確認借書";
            this._checkBorrowButton.UseVisualStyleBackColor = true;
            this._checkBorrowButton.Click += new System.EventHandler(this.ClickBorrowButton);
            // 
            // _titleLabel
            // 
            this._titleLabel.AutoSize = true;
            this._titleLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this._titleLabel.Location = new System.Drawing.Point(656, 7);
            this._titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(128, 46);
            this._titleLabel.TabIndex = 4;
            this._titleLabel.Text = "借書單";
            // 
            // _borrowLabel
            // 
            this._borrowLabel.AutoSize = true;
            this._borrowLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this._borrowLabel.Location = new System.Drawing.Point(404, 446);
            this._borrowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._borrowLabel.Name = "_borrowLabel";
            this._borrowLabel.Size = new System.Drawing.Size(119, 25);
            this._borrowLabel.TabIndex = 6;
            this._borrowLabel.Text = "借書數量 : 0";
            // 
            // _backPackButton
            // 
            this._backPackButton.Font = new System.Drawing.Font("新細明體", 8F);
            this._backPackButton.Location = new System.Drawing.Point(757, 438);
            this._backPackButton.Margin = new System.Windows.Forms.Padding(2);
            this._backPackButton.Name = "_backPackButton";
            this._backPackButton.Size = new System.Drawing.Size(124, 43);
            this._backPackButton.TabIndex = 7;
            this._backPackButton.Text = "查看我的書包";
            this._backPackButton.UseVisualStyleBackColor = true;
            this._backPackButton.Click += new System.EventHandler(this.BackPackButtonClick);
            // 
            // BookBorrowingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 488);
            this.Controls.Add(this._backPackButton);
            this.Controls.Add(this._borrowLabel);
            this.Controls.Add(this._titleLabel);
            this.Controls.Add(this._checkBorrowButton);
            this.Controls.Add(this._bookDataGridView);
            this.Controls.Add(this._bookGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookBorrowingForm";
            this.Text = "借書";
            this._bookGroupBox1.ResumeLayout(false);
            this._bookGroupBox1.PerformLayout();
            this._bookGroupBox2.ResumeLayout(false);
            this._bookGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bookItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _bookGroupBox1;
        private System.Windows.Forms.RichTextBox _bookRichTextBox;
        private System.Windows.Forms.GroupBox _bookGroupBox2;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.DataGridView _bookDataGridView;
        private System.Windows.Forms.Button _checkBorrowButton;
        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.Label _borrowLabel;
        private System.Windows.Forms.Label _lastLabel;
        private System.Windows.Forms.TabControl _bookTabControl;
        private System.Windows.Forms.Button _backPackButton;
        private System.Windows.Forms.Label _nowPageLabel;
        private System.Windows.Forms.Button _downPageButton;
        private System.Windows.Forms.Button _upPageButton;
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.BindingSource _bookItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nameDataGridViewTextBoxColumn;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn _numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _isBookNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _publishDataGridViewTextBoxColumn;
    }
}

