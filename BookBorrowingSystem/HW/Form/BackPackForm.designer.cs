
namespace HomeWork
{
    partial class BackPackForm
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
            this._bookDataGridView = new System.Windows.Forms.DataGridView();
            this._returnNumberDataGridViewTextBoxColumn = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this._nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantityBorrowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._borrowingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._isBookNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._publishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bookItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._bookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bookItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _bookDataGridView
            // 
            this._bookDataGridView.AutoGenerateColumns = false;
            this._bookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._returnNumberDataGridViewTextBoxColumn,
            this._nameDataGridViewTextBoxColumn,
            this._quantityBorrowedDataGridViewTextBoxColumn,
            this._borrowingDateDataGridViewTextBoxColumn,
            this._returnDateDataGridViewTextBoxColumn,
            this._isBookNumberDataGridViewTextBoxColumn,
            this._authorDataGridViewTextBoxColumn,
            this._publishDataGridViewTextBoxColumn});
            this._bookDataGridView.DataSource = this._bookItemBindingSource;
            this._bookDataGridView.Location = new System.Drawing.Point(9, 11);
            this._bookDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this._bookDataGridView.Name = "_bookDataGridView";
            this._bookDataGridView.RowHeadersWidth = 62;
            this._bookDataGridView.RowTemplate.Height = 32;
            this._bookDataGridView.Size = new System.Drawing.Size(986, 344);
            this._bookDataGridView.TabIndex = 2;
            // 
            // _returnNumberDataGridViewTextBoxColumn
            // 
            this._returnNumberDataGridViewTextBoxColumn.DataPropertyName = "ReturnNumber";
            this._returnNumberDataGridViewTextBoxColumn.HeaderText = "數量";
            this._returnNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._returnNumberDataGridViewTextBoxColumn.Name = "_returnNumberDataGridViewTextBoxColumn";
            this._returnNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._returnNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // _nameDataGridViewTextBoxColumn
            // 
            this._nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this._nameDataGridViewTextBoxColumn.HeaderText = "書籍名稱";
            this._nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._nameDataGridViewTextBoxColumn.Name = "_nameDataGridViewTextBoxColumn";
            // 
            // _quantityBorrowedDataGridViewTextBoxColumn
            // 
            this._quantityBorrowedDataGridViewTextBoxColumn.DataPropertyName = "QuantityBorrowed";
            this._quantityBorrowedDataGridViewTextBoxColumn.HeaderText = "已借數量";
            this._quantityBorrowedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._quantityBorrowedDataGridViewTextBoxColumn.Name = "_quantityBorrowedDataGridViewTextBoxColumn";
            // 
            // _borrowingDateDataGridViewTextBoxColumn
            // 
            this._borrowingDateDataGridViewTextBoxColumn.DataPropertyName = "BorrowingDate";
            this._borrowingDateDataGridViewTextBoxColumn.HeaderText = "借書日期";
            this._borrowingDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._borrowingDateDataGridViewTextBoxColumn.Name = "_borrowingDateDataGridViewTextBoxColumn";
            // 
            // _returnDateDataGridViewTextBoxColumn
            // 
            this._returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this._returnDateDataGridViewTextBoxColumn.HeaderText = "還書日期";
            this._returnDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._returnDateDataGridViewTextBoxColumn.Name = "_returnDateDataGridViewTextBoxColumn";
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
            this._authorDataGridViewTextBoxColumn.HeaderText = "作者";
            this._authorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._authorDataGridViewTextBoxColumn.Name = "_authorDataGridViewTextBoxColumn";
            // 
            // _publishDataGridViewTextBoxColumn
            // 
            this._publishDataGridViewTextBoxColumn.DataPropertyName = "Publish";
            this._publishDataGridViewTextBoxColumn.HeaderText = "出版項";
            this._publishDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._publishDataGridViewTextBoxColumn.Name = "_publishDataGridViewTextBoxColumn";
            // 
            // _bookItemBindingSource
            // 
            this._bookItemBindingSource.DataSource = typeof(HomeWork.BookItem);
            // 
            // BackPackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 488);
            this.Controls.Add(this._bookDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BackPackForm";
            this.Text = "我的書包(還書)";
            ((System.ComponentModel.ISupportInitialize)(this._bookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bookItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _bookDataGridView;
        private System.Windows.Forms.BindingSource _bookItemBindingSource;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn _returnNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _quantityBorrowedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _borrowingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _isBookNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _publishDataGridViewTextBoxColumn;
    }
}