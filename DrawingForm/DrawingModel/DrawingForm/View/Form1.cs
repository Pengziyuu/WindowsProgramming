using DrawingForm.PresentationModel;
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

namespace DrawingForm
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        DrawingModel.Model _model;
        PresentationModel.FormPresentationModel _presentationModel;
        //DrawingModel.GoogleDriveService _service;

        public Form1()
        {
            InitializeComponent();

            _canvas.MouseDown += HandleCanvasPressed;
            _canvas.MouseUp += HandleCanvasReleased;
            _canvas.MouseMove += HandleCanvasMoved;
            _canvas.Paint += HandleCanvasPaint;
            _clear.Click += HandleClearButtonClick;
            _triangle.Click += HandleTriangleButtonClick;
            _rectangle.Click += HandleRectangleButtonClick;
            _line.Click += HandleLineButtonClick;

            _model = new DrawingModel.Model();
            _presentationModel = new PresentationModel.FormPresentationModel(_model, _canvas);
            _model._modelChanged += HandleModelChanged;
        }

        // ClickSave
        private void ClickSaveButton(object sender, EventArgs e)
        {
            //const string CONTENT_TYPE = "image/jpeg";
            //string path = @"Sample.jpeg";
            //_service.UploadFile(Path.GetFullPath(path), CONTENT_TYPE);
        }

        // ClickLoad
        private void ClickLoadButton(object sender, EventArgs e)
        {
            // Google.Apis.Drive.v2.Data.File selectedFile = _fileListBox.SelectedItem as Google.Apis.Drive.v2.Data.File;
            // _service.DownloadFile(selectedFile, _downloadPath);
        }

        // 復原
        public void UndoHandler(object sender, EventArgs e)
        {
            _model.Undo();
            RefreshView();
        }

        // 重做
        private void RedoHandler(object sender, EventArgs e)
        {
            _model.Redo();
            RefreshView();
        }

        // LineButtonClick事件
        public void HandleLineButtonClick(object sender, System.EventArgs e)
        {
            _presentationModel.ClickLine();
            RefreshView();
        }

        // RectanglButtonClick事件
        public void HandleRectangleButtonClick(object sender, System.EventArgs e)
        {
            _presentationModel.ClickRectangle();
            RefreshView();
        }

        // TriangleButtonClick事件
        public void HandleTriangleButtonClick(object sender, System.EventArgs e)
        {
            _presentationModel.ClickTriangle();
            RefreshView();
        }

        // ClearButtonClick事件
        public void HandleClearButtonClick(object sender, System.EventArgs e)
        {
            _model.Clear();
            _presentationModel.EnableAll();
            RefreshView();
        }

        // CanvasPressed事件
        public void HandleCanvasPressed(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _model.PressedPointer(e.X, e.Y);
        }

        // CanvasReleased事件
        public void HandleCanvasReleased(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _model.ReleasedPointer(e.X, e.Y);
            _presentationModel.EnableReleased();
            RefreshView();
        }

        // CanvasMoved事件
        public void HandleCanvasMoved(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _model.MovedPointer(e.X, e.Y);
        }

        // CanvasPaint事件
        public void HandleCanvasPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            _presentationModel.Draw(new FormGraphicsAdaptor(e.Graphics));
        }

        // ModelChanged事件
        public void HandleModelChanged()
        {
            Invalidate(true);
        }

        // 更新畫面
        public void RefreshView()
        {
            _line.Enabled = _presentationModel.IsLineEnable;
            _triangle.Enabled = _presentationModel.IsTriangleEnable;
            _rectangle.Enabled = _presentationModel.IsRectangleEnabled;
            _undo.Enabled = _model.IsUndoEnable;
            _redo.Enabled = _model.IsRedoEnable;
            _label.Text = _model.ShapeText;
        }
    }
}