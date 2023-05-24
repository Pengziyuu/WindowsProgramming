using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    public class MockIGraphics : IGraphics
    {
        // 假的
        public void ClearAll()
        {
        }

        // 假的
        public void DottedLine(double x1, double y1, double x2, double y2)
        {
        }

        // 假的
        public void DrawLine(double x1, double y1, double x2, double y2)
        {
        }

        // 假的
        public void DrawRectangle(double x1, double y1, double x2, double y2)
        {
        }

        // 假的
        public void DrawTriangle(double x1, double y1, double x2, double y2)
        {
        }
    }
}
