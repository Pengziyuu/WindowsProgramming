using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media;
using DrawingModel;

namespace DrawingApp.PresentationModel
{
    class AppGraphicsAdaptor : IGraphics
    {
        const int TWO = 2;
        const int THICKNESS = 5;
        const int RADIUS = 14;
        const int OFFSET = 7;

        Canvas _canvas;
         
        public AppGraphicsAdaptor(Canvas canvas)
        {
            this._canvas = canvas;
        }

        // 清除
        public void ClearAll()
        {
            _canvas.Children.Clear();
        }

        // 畫三角形
        public void DrawTriangle(double x1, double y1, double x2, double y2)
        {
            double temp;
            if (x1 > x2)
            {
                temp = x1;
                x1 = x2;
                x2 = temp;
            }
            if (y1 > y2)
            {
                temp = y1;
                y1 = y2;
                y2 = temp;
            }
            CreateTriangle(x1, y1, x2, y2);
        }

        // 建三角形
        public void CreateTriangle(double x1, double y1, double x2, double y2)
        {
            Windows.UI.Xaml.Shapes.Polygon polygon = new Windows.UI.Xaml.Shapes.Polygon();
            polygon.Fill = new SolidColorBrush(Windows.UI.Colors.Orange);
            polygon.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            polygon.StrokeThickness = THICKNESS;
            var points = new PointCollection();
            points.Add(new Windows.Foundation.Point(x1, y2));
            points.Add(new Windows.Foundation.Point(x2, y2));
            points.Add(new Windows.Foundation.Point((x1 + x2) / TWO, y1));
            polygon.Points = points;
            _canvas.Children.Add(polygon);
        }

        // 畫矩形
        public void DrawRectangle(double x1, double y1, double x2, double y2)
        {
            Windows.UI.Xaml.Shapes.Polygon polygon = new Windows.UI.Xaml.Shapes.Polygon();
            polygon.Fill = new SolidColorBrush(Windows.UI.Colors.Yellow);
            polygon.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            polygon.StrokeThickness = THICKNESS;
            var points = new PointCollection();
            points.Add(new Windows.Foundation.Point(x1, y1));
            points.Add(new Windows.Foundation.Point(x2, y1));
            points.Add(new Windows.Foundation.Point(x2, y2));
            points.Add(new Windows.Foundation.Point(x1, y2));
            polygon.Points = points;
            _canvas.Children.Add(polygon);
        }

        // 畫虛線
        public void DottedLine(double x1, double y1, double x2, double y2)
        {
            CreateDottedLine(x1, y1, x2, y2);
            CreateEllipse(x1, y1);
            CreateEllipse(x1, y2);
            CreateEllipse(x2, y1);
            CreateEllipse(x2, y2);
        }

        // 建虛線
        public void CreateDottedLine(double x1, double y1, double x2, double y2)
        {
            Windows.UI.Xaml.Shapes.Polygon polygon = new Windows.UI.Xaml.Shapes.Polygon();
            polygon.Stroke = new SolidColorBrush(Windows.UI.Colors.Red);
            polygon.StrokeThickness = THICKNESS;
            var dottedLine = new double[] { THICKNESS, THICKNESS };
            var bar = new DoubleCollection();
            foreach (double d in dottedLine)
                bar.Add(d);
            polygon.StrokeDashArray = bar;
            var points = new PointCollection();
            points.Add(new Windows.Foundation.Point(x1, y1));
            points.Add(new Windows.Foundation.Point(x2, y1));
            points.Add(new Windows.Foundation.Point(x2, y2));
            points.Add(new Windows.Foundation.Point(x1, y2));
            polygon.Points = points;
            _canvas.Children.Add(polygon);
        }

        // 建圓形
        public void CreateEllipse(double x1, double y1)
        {
            Windows.UI.Xaml.Shapes.Ellipse ellipse = new Windows.UI.Xaml.Shapes.Ellipse();
            ellipse.Fill = new SolidColorBrush(Windows.UI.Colors.White);
            ellipse.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            ellipse.StrokeThickness = 1;
            ellipse.Width = RADIUS;
            ellipse.Height = RADIUS;
            Canvas.SetLeft(ellipse, x1 - OFFSET);
            Canvas.SetTop(ellipse, y1 - OFFSET);
            _canvas.Children.Add(ellipse);
        }

        // 畫線
        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            Windows.UI.Xaml.Shapes.Polyline line = new Polyline();
            line.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            line.StrokeThickness = THICKNESS;
            var points = new PointCollection();
            points.Add(new Windows.Foundation.Point(x1, y1));
            points.Add(new Windows.Foundation.Point((x1 + x2) / TWO, y1));
            points.Add(new Windows.Foundation.Point((x1 + x2) / TWO, y2));
            points.Add(new Windows.Foundation.Point(x2, y2));
            line.Points = points;
            _canvas.Children.Add(line);
        }
    }
}
