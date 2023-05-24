
namespace HomeWork
{
    partial class BookInventoryForm
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
            this._titleText = new System.Windows.Forms.Label();
            this._inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this._bookPictureLabel = new System.Windows.Forms.Label();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._bookDataLabel = new System.Windows.Forms.Label();
            this._richTextBox = new System.Windows.Forms.RichTextBox();
            this._nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._isBookNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._publishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bookItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._inventoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bookItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _titleText
            // 
            this._titleText.AutoSize = true;
            this._titleText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F);
            this._titleText.Location = new System.Drawing.Point(211, 7);
            this._titleText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._titleText.Name = "_titleText";
            this._titleText.Size = new System.Drawing.Size(411, 61);
            this._titleText.TabIndex = 0;
            this._titleText.Text = "書籍庫存管理系統";
            // 
            // _inventoryDataGridView
            // 
            this._inventoryDataGridView.AutoGenerateColumns = false;
            this._inventoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._nameDataGridViewTextBoxColumn,
            this._categoryDataGridViewTextBoxColumn,
            this._quantityDataGridViewTextBoxColumn,
            this._isBookNumberDataGridViewTextBoxColumn,
            this._authorDataGridViewTextBoxColumn,
            this._publishDataGridViewTextBoxColumn});
            this._inventoryDataGridView.DataSource = this._bookItemBindingSource;
            this._inventoryDataGridView.Location = new System.Drawing.Point(0, 70);
            this._inventoryDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this._inventoryDataGridView.Name = "_inventoryDataGridView";
            this._inventoryDataGridView.RowHeadersWidth = 62;
            this._inventoryDataGridView.RowTemplate.Height = 32;
            this._inventoryDataGridView.Size = new System.Drawing.Size(528, 473);
            this._inventoryDataGridView.TabIndex = 1;
            this._inventoryDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.PatingGridCell);
            // 
            // _bookPictureLabel
            // 
            this._bookPictureLabel.AutoSize = true;
            this._bookPictureLabel.Location = new System.Drawing.Point(542, 70);
            this._bookPictureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._bookPictureLabel.Name = "_bookPictureLabel";
            this._bookPictureLabel.Size = new System.Drawing.Size(80, 18);
            this._bookPictureLabel.TabIndex = 2;
            this._bookPictureLabel.Text = "書籍圖片";
            // 
            // _pictureBox
            // 
            this._pictureBox.Location = new System.Drawing.Point(542, 90);
            this._pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(123, 145);
            this._pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pictureBox.TabIndex = 3;
            this._pictureBox.TabStop = false;
            // 
            // _bookDataLabel
            // 
            this._bookDataLabel.AutoSize = true;
            this._bookDataLabel.Location = new System.Drawing.Point(542, 257);
            this._bookDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._bookDataLabel.Name = "_bookDataLabel";
            this._bookDataLabel.Size = new System.Drawing.Size(80, 18);
            this._bookDataLabel.TabIndex = 4;
            this._bookDataLabel.Text = "書籍資訊";
            // 
            // _richTextBox
            // 
            this._richTextBox.Location = new System.Drawing.Point(533, 278);
            this._richTextBox.Margin = new System.Windows.Forms.Padding(2);
            this._richTextBox.Name = "_richTextBox";
            this._richTextBox.Size = new System.Drawing.Size(258, 257);
            this._richTextBox.TabIndex = 5;
            this._richTextBox.Text = "";
            // 
            // _nameDataGridViewTextBoxColumn
            // 
            this._nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this._nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this._nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._nameDataGridViewTextBoxColumn.Name = "_nameDataGridViewTextBoxColumn";
            // 
            // _categoryDataGridViewTextBoxColumn
            // 
            this._categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this._categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this._categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._categoryDataGridViewTextBoxColumn.Name = "_categoryDataGridViewTextBoxColumn";
            // 
            // _quantityDataGridViewTextBoxColumn
            // 
            this._quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this._quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this._quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._quantityDataGridViewTextBoxColumn.Name = "_quantityDataGridViewTextBoxColumn";
            // 
            // _isBookNumberDataGridViewTextBoxColumn
            // 
            this._isBookNumberDataGridViewTextBoxColumn.DataPropertyName = "IsBookNumber";
            this._isBookNumberDataGridViewTextBoxColumn.HeaderText = "IsBookNumber";
            this._isBookNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._isBookNumberDataGridViewTextBoxColumn.Name = "_isBookNumberDataGridViewTextBoxColumn";
            this._isBookNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // _authorDataGridViewTextBoxColumn
            // 
            this._authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this._authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this._authorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._authorDataGridViewTextBoxColumn.Name = "_authorDataGridViewTextBoxColumn";
            this._authorDataGridViewTextBoxColumn.Visible = false;
            // 
            // _publishDataGridViewTextBoxColumn
            // 
            this._publishDataGridViewTextBoxColumn.DataPropertyName = "Publish";
            this._publishDataGridViewTextBoxColumn.HeaderText = "Publish";
            this._publishDataGridViewTextBoxColumn.MinimumWidth = 8;
            this._publishDataGridViewTextBoxColumn.Name = "_publishDataGridViewTextBoxColumn";
            this._publishDataGridViewTextBoxColumn.Visible = false;
            // 
            // _bookItemBindingSource
            // 
            this._bookItemBindingSource.DataSource = typeof(HomeWork.BookItem);
            // 
            // BookInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this._richTextBox);
            this.Controls.Add(this._bookDataLabel);
            this.Controls.Add(this._pictureBox);
            this.Controls.Add(this._bookPictureLabel);
            this.Controls.Add(this._inventoryDataGridView);
            this.Controls.Add(this._titleText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookInventoryForm";
            this.Text = "書本庫存";
            ((System.ComponentModel.ISupportInitialize)(this._inventoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bookItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _titleText;
        private System.Windows.Forms.DataGridView _inventoryDataGridView;
        private System.Windows.Forms.Label _bookPictureLabel;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.Label _bookDataLabel;
        private System.Windows.Forms.RichTextBox _richTextBox;
        private System.Windows.Forms.BindingSource _bookItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _isBookNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _publishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _categoryDataGridViewTextBoxColumn;
    }
}