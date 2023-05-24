
namespace HomeWork
{
    partial class MenuForm
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
            this._bookBorrowingButton = new System.Windows.Forms.Button();
            this._bookInventoryButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this._bookManagementButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _bookBorrowingButton
            // 
            this._bookBorrowingButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this._bookBorrowingButton.Location = new System.Drawing.Point(10, 9);
            this._bookBorrowingButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._bookBorrowingButton.Name = "_bookBorrowingButton";
            this._bookBorrowingButton.Size = new System.Drawing.Size(986, 200);
            this._bookBorrowingButton.TabIndex = 0;
            this._bookBorrowingButton.Text = "Book Borrowing System";
            this._bookBorrowingButton.UseVisualStyleBackColor = true;
            this._bookBorrowingButton.Click += new System.EventHandler(this.BookBorrowingButtonClick);
            // 
            // _bookInventoryButton
            // 
            this._bookInventoryButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this._bookInventoryButton.Location = new System.Drawing.Point(10, 214);
            this._bookInventoryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._bookInventoryButton.Name = "_bookInventoryButton";
            this._bookInventoryButton.Size = new System.Drawing.Size(986, 211);
            this._bookInventoryButton.TabIndex = 1;
            this._bookInventoryButton.Text = "Book Inventory System";
            this._bookInventoryButton.UseVisualStyleBackColor = true;
            this._bookInventoryButton.Click += new System.EventHandler(this.BookInventoryButtonClick);
            // 
            // _exitButton
            // 
            this._exitButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this._exitButton.Location = new System.Drawing.Point(896, 644);
            this._exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(98, 49);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // _bookManagementButton
            // 
            this._bookManagementButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this._bookManagementButton.Location = new System.Drawing.Point(8, 429);
            this._bookManagementButton.Margin = new System.Windows.Forms.Padding(2);
            this._bookManagementButton.Name = "_bookManagementButton";
            this._bookManagementButton.Size = new System.Drawing.Size(986, 211);
            this._bookManagementButton.TabIndex = 3;
            this._bookManagementButton.Text = "Book Management System";
            this._bookManagementButton.UseVisualStyleBackColor = true;
            this._bookManagementButton.Click += new System.EventHandler(this.BookManagementButtonClick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 704);
            this.Controls.Add(this._bookManagementButton);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._bookInventoryButton);
            this.Controls.Add(this._bookBorrowingButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _bookBorrowingButton;
        private System.Windows.Forms.Button _bookInventoryButton;
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.Button _bookManagementButton;
    }
}