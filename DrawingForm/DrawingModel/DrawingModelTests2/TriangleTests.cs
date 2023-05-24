using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingModel.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        Shape _shape;
        MockIGraphics _mockIGraphics;

        // Test
        [TestInitialize]
        public void Initialize()
        {
            _shape = new Triangle();
            _mockIGraphics = new MockIGraphics();
            _shape.X1 = 100;
            _shape.X2 = 100;
            _shape.Y1 = 100;
            _shape.Y1 = 100;
        }

        // Test
        [TestMethod()]
        public void DrawTest()
        {
            _shape.Draw(_mockIGraphics);
        }

        // Test
        [TestMethod()]
        public void DottedLineTest()
        {
            _shape.DottedLine(_mockIGraphics);
        }

        // Test
        [TestMethod()]
        public void IsInTest()
        {
            _shape.IsIn(100, 100);
        }

        // Test
        [TestMethod()]
        public void GetShapeTextTest()
        {
            _shape.GetShapeText();
        }
    }
}