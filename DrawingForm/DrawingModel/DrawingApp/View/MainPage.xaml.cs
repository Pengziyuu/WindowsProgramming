using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DrawingApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DrawingModel.Model _model;
        PresentationModel.AppPresentationModel _presentationModel;

        public MainPage()
        {
            this.InitializeComponent();
            _model = new DrawingModel.Model();
            _presentationModel = new PresentationModel.AppPresentationModel(_model, _canvas);
            _canvas.PointerPressed += HandleCanvasPressed;
            _canvas.PointerReleased += HandleCanvasReleased;
            _canvas.PointerMoved += HandleCanvasMoved;
            _clear.Click += HandleClearButtonClick;
            _triangle.Click += HandleTriangleButtonClick;
            _rectangle.Click += HandleRectangleButtonClick;
            _line.Click += HandleLineButtonClick;

            _model._modelChanged += HandleModelChanged;
            RefreshView();
        }

        // pass
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        // 復原
        public void UndoHandler(object sender, RoutedEventArgs e)
        {
            _model.Undo();
            RefreshView();
        }

        // 重做
        private void RedoHandler(object sender, RoutedEventArgs e)
        {
            _model.Redo();
            RefreshView();
        }

        // LineButtonClick事件
        public void HandleLineButtonClick(object sender, RoutedEventArgs e)
        {
            _presentationModel.ClickLine();
            RefreshView();
        }

        // RectanglButtonClick事件
        public void HandleRectangleButtonClick(object sender, RoutedEventArgs e)
        {
            _presentationModel.ClickRectangle();
            RefreshView();
        }

        // TriangleButtonClick事件
        public void HandleTriangleButtonClick(object sender, RoutedEventArgs e)
        {
            _presentationModel.ClickTriangle();
            RefreshView();
        }

        // ClearButtonClick事件
        private void HandleClearButtonClick(object sender, RoutedEventArgs e)
        {
            _model.Clear();
            _presentationModel.EnableAll();
            RefreshView();
        }

        // CanvasPressed事件
        public void HandleCanvasPressed(object sender, PointerRoutedEventArgs e)
        {
            _model.PressedPointer(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
        }

        // CanvasReleased事件
        public void HandleCanvasReleased(object sender, PointerRoutedEventArgs e)
        {
            _model.ReleasedPointer(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
            _presentationModel.EnableReleased();
            RefreshView();
        }

        // CanvasMoved事件
        public void HandleCanvasMoved(object sender, PointerRoutedEventArgs e)
        {
            _model.MovedPointer(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
        }

        // ModelChanged事件
        public void HandleModelChanged()
        {
            _presentationModel.Draw();
        }

        // 更新畫面
        public void RefreshView()
        {
            _line.IsEnabled = _presentationModel.IsLineEnable;
            _triangle.IsEnabled = _presentationModel.IsTriangleEnable;
            _rectangle.IsEnabled = _presentationModel.IsRectangleEnabled;
            _undo.IsEnabled = _model.IsUndoEnable;
            _redo.IsEnabled = _model.IsRedoEnable;
            _label.Text = _model.ShapeText;
        }
    }
}
