
namespace HomeWork
{
    partial class BookAddingForm
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
            this._titleLabel = new System.Windows.Forms.Label();
            this._richTextBox1 = new System.Windows.Forms.RichTextBox();
            this._label = new System.Windows.Forms.Label();
            this._textBox = new System.Windows.Forms.TextBox();
            this._okButton = new System.Windows.Forms.Button();
            this._button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _titleLabel
            // 
            this._titleLabel.AutoSize = true;
            this._titleLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F);
            this._titleLabel.Location = new System.Drawing.Point(182, 9);
            this._titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(107, 38);
            this._titleLabel.TabIndex = 0;
            this._titleLabel.Text = "補貨單";
            // 
            // _richTextBox1
            // 
            this._richTextBox1.Location = new System.Drawing.Point(10, 49);
            this._richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this._richTextBox1.Name = "_richTextBox1";
            this._richTextBox1.Size = new System.Drawing.Size(454, 260);
            this._richTextBox1.TabIndex = 1;
            this._richTextBox1.Text = "";
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this._label.Location = new System.Drawing.Point(10, 319);
            this._label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(107, 25);
            this._label.TabIndex = 2;
            this._label.Text = "補貨數量 : ";
            // 
            // _textBox
            // 
            this._textBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this._textBox.Location = new System.Drawing.Point(121, 316);
            this._textBox.Margin = new System.Windows.Forms.Padding(2);
            this._textBox.Name = "_textBox";
            this._textBox.Size = new System.Drawing.Size(123, 33);
            this._textBox.TabIndex = 3;
            this._textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitInput);
            // 
            // _okButton
            // 
            this._okButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this._okButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this._okButton.Location = new System.Drawing.Point(10, 369);
            this._okButton.Margin = new System.Windows.Forms.Padding(2);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(221, 47);
            this._okButton.TabIndex = 4;
            this._okButton.Text = "確認";
            this._okButton.UseVisualStyleBackColor = false;
            this._okButton.Click += new System.EventHandler(this.ClickOkButton);
            // 
            // _button
            // 
            this._button.BackColor = System.Drawing.Color.Red;
            this._button.Location = new System.Drawing.Point(242, 369);
            this._button.Margin = new System.Windows.Forms.Padding(2);
            this._button.Name = "_button";
            this._button.Size = new System.Drawing.Size(221, 47);
            this._button.TabIndex = 5;
            this._button.Text = "取消";
            this._button.UseVisualStyleBackColor = false;
            this._button.Click += new System.EventHandler(this.ClickCancelButton);
            // 
            // BookAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 426);
            this.Controls.Add(this._button);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._textBox);
            this.Controls.Add(this._label);
            this.Controls.Add(this._richTextBox1);
            this.Controls.Add(this._titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookAddingForm";
            this.Text = "Book Adding Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.RichTextBox _richTextBox1;
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.TextBox _textBox;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _button;
    }
}