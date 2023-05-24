
namespace DrawingForm
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._load = new System.Windows.Forms.Button();
            this._save = new System.Windows.Forms.Button();
            this._clear = new System.Windows.Forms.Button();
            this._triangle = new System.Windows.Forms.Button();
            this._line = new System.Windows.Forms.Button();
            this._rectangle = new System.Windows.Forms.Button();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._undo = new System.Windows.Forms.ToolStripButton();
            this._redo = new System.Windows.Forms.ToolStripButton();
            this._canvas = new DrawingForm.DoubleBufferedPanel();
            this._label = new System.Windows.Forms.Label();
            this._tableLayoutPanel1.SuspendLayout();
            this._toolStrip.SuspendLayout();
            this._canvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel1
            // 
            this._tableLayoutPanel1.AutoSize = true;
            this._tableLayoutPanel1.ColumnCount = 6;
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanel1.Controls.Add(this._load, 5, 0);
            this._tableLayoutPanel1.Controls.Add(this._save, 4, 0);
            this._tableLayoutPanel1.Controls.Add(this._clear, 3, 0);
            this._tableLayoutPanel1.Controls.Add(this._triangle, 2, 0);
            this._tableLayoutPanel1.Controls.Add(this._line, 1, 0);
            this._tableLayoutPanel1.Controls.Add(this._rectangle, 0, 0);
            this._tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this._tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this._tableLayoutPanel1.Name = "_tableLayoutPanel1";
            this._tableLayoutPanel1.RowCount = 1;
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel1.Size = new System.Drawing.Size(1344, 56);
            this._tableLayoutPanel1.TabIndex = 0;
            // 
            // _load
            // 
            this._load.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._load.AutoSize = true;
            this._load.Location = new System.Drawing.Point(1154, 3);
            this._load.Name = "_load";
            this._load.Size = new System.Drawing.Size(150, 50);
            this._load.TabIndex = 7;
            this._load.Text = "Load";
            this._load.UseVisualStyleBackColor = true;
            // 
            // _save
            // 
            this._save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._save.AutoSize = true;
            this._save.Location = new System.Drawing.Point(928, 3);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(150, 50);
            this._save.TabIndex = 6;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = true;
            // 
            // _clear
            // 
            this._clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._clear.AutoSize = true;
            this._clear.Location = new System.Drawing.Point(705, 3);
            this._clear.Name = "_clear";
            this._clear.Size = new System.Drawing.Size(150, 50);
            this._clear.TabIndex = 2;
            this._clear.Text = "Clear";
            this._clear.UseVisualStyleBackColor = true;
            // 
            // _triangle
            // 
            this._triangle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._triangle.AutoSize = true;
            this._triangle.Location = new System.Drawing.Point(482, 3);
            this._triangle.Name = "_triangle";
            this._triangle.Size = new System.Drawing.Size(150, 50);
            this._triangle.TabIndex = 1;
            this._triangle.Text = "Triangle";
            this._triangle.UseVisualStyleBackColor = true;
            // 
            // _line
            // 
            this._line.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._line.AutoSize = true;
            this._line.Location = new System.Drawing.Point(259, 3);
            this._line.Name = "_line";
            this._line.Size = new System.Drawing.Size(150, 50);
            this._line.TabIndex = 3;
            this._line.Text = "Line";
            this._line.UseVisualStyleBackColor = true;
            // 
            // _rectangle
            // 
            this._rectangle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._rectangle.AutoSize = true;
            this._rectangle.Location = new System.Drawing.Point(44, 3);
            this._rectangle.Name = "_rectangle";
            this._rectangle.Size = new System.Drawing.Size(135, 50);
            this._rectangle.TabIndex = 0;
            this._rectangle.Text = "Rectangle";
            this._rectangle.UseVisualStyleBackColor = true;
            // 
            // _toolStrip
            // 
            this._toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._undo,
            this._redo});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(1344, 32);
            this._toolStrip.TabIndex = 1;
            this._toolStrip.Text = "toolStrip1";
            // 
            // _undo
            // 
            this._undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._undo.Enabled = false;
            this._undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._undo.Name = "_undo";
            this._undo.Size = new System.Drawing.Size(60, 27);
            this._undo.Text = "Undo";
            this._undo.Click += new System.EventHandler(this.UndoHandler);
            // 
            // _redo
            // 
            this._redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._redo.Enabled = false;
            this._redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._redo.Name = "_redo";
            this._redo.Size = new System.Drawing.Size(58, 27);
            this._redo.Text = "Redo";
            this._redo.Click += new System.EventHandler(this.RedoHandler);
            // 
            // _canvas
            // 
            this._canvas.BackColor = System.Drawing.Color.LightYellow;
            this._canvas.Controls.Add(this._label);
            this._canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this._canvas.Location = new System.Drawing.Point(0, 0);
            this._canvas.Name = "_canvas";
            this._canvas.Size = new System.Drawing.Size(1344, 712);
            this._canvas.TabIndex = 0;
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._label.Location = new System.Drawing.Point(0, 694);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(0, 18);
            this._label.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this._tableLayoutPanel1);
            this.Controls.Add(this._toolStrip);
            this.Controls.Add(this._canvas);
            this.Name = "Form1";
            this.Text = "DrawingForm";
            this._tableLayoutPanel1.ResumeLayout(false);
            this._tableLayoutPanel1.PerformLayout();
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this._canvas.ResumeLayout(false);
            this._canvas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBufferedPanel _canvas;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
        private System.Windows.Forms.Button _rectangle;
        private System.Windows.Forms.Button _triangle;
        private System.Windows.Forms.Button _clear;
        private System.Windows.Forms.Button _line;
        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripButton _undo;
        private System.Windows.Forms.ToolStripButton _redo;
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.Button _load;
        private System.Windows.Forms.Button _save;
    }
}

