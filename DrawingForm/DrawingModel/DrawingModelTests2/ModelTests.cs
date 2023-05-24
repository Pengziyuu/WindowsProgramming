using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingModel.Tests
{
    [TestClass()]
    public class ModelTests
    {
        Model _model;
        MockIGraphics _mockIGraphics;

        // Test
        [TestInitialize]
        public void Initialize()
        {
            _model = new Model();
            _model._modelChanged += () => { };
            _model.ShapeType = ShapeType.Triangle;
            _model.SetDrawingState();
            _mockIGraphics = new MockIGraphics();
        }

        // Test
        [TestMethod()]
        public void PressedPointerTest()
        {
            _model.SetPointerState();
            _model.PressedPointer(1.0, 1.0);
            _model.Draw(_mockIGraphics);
            _model.MovedPointer(3.0, 3.0);
            _model.ReleasedPointer(3.0, 3.0);
            _model.PressedPointer(2.0, 2.0);

            _model.ShapeType = ShapeType.None;
            _model.PressedPointer(1.0, 1.0);
            _model.Draw(_mockIGraphics);
            _model.MovedPointer(3.0, 3.0);
            _model.ReleasedPointer(3.0, 3.0);
            _model.PressedPointer(2.0, 2.0);

            _model.SetLinkState();
            _model.ShapeType = ShapeType.Line;
            _model.PressedPointer(1.0, 1.0);
            _model.Draw(_mockIGraphics);
            _model.MovedPointer(3.0, 3.0);
            _model.ReleasedPointer(3.0, 3.0);
            _model.PressedPointer(2.0, 2.0);
        }

        // Test
        [TestMethod()]
        public void MovedPointerTest()
        {
            _model.PressedPointer(1.0, 2.0);
            _model.MovedPointer(1.0, 2.0);
        }

        // Test
        [TestMethod()]
        public void ReleasedPointerTest()
        {
            _model.PressedPointer(1.0, 1.0);
            _model.Draw(_mockIGraphics);
            _model.MovedPointer(3.0, 3.0);
            _model.ReleasedPointer(3.0, 3.0);

            _model.PressedPointer(5.0, 5.0);
            _model.Draw(_mockIGraphics);
            _model.MovedPointer(8.0, 8.0);
            _model.ReleasedPointer(8.0, 8.0);

            _model.SetLinkState();
            _model.ShapeType = ShapeType.Line;
            _model.PressedPointer(2.0, 2.0);
            _model.Draw(_mockIGraphics);
            _model.MovedPointer(7.0, 7.0);
            _model.ReleasedPointer(7.0, 7.0);
            _model.Draw(_mockIGraphics);

            _model.SetDrawingState();
            _model.ShapeType = ShapeType.Triangle;
            _model.PressedPointer(7.0, 7.0);
            _model.MovedPointer(2.0, 2.0);
            _model.ReleasedPointer(2.0, 2.0);
        }

        // Test
        [TestMethod()]
        public void ClearTest()
        {
            _model.Clear();
        }

        // Test
        [TestMethod()]
        public void UndoTest()
        {
            _model.PressedPointer(1.0, 2.0);
            _model.Draw(_mockIGraphics);
            _model.MovedPointer(1.0, 2.0);
            _model.ReleasedPointer(1.0, 2.0);
            _model.Undo();
        }

        // Test
        [TestMethod()]
        public void RedoTest()
        {
            _model.PressedPointer(1.0, 2.0);
            _model.Draw(_mockIGraphics);
            _model.MovedPointer(1.0, 2.0);
            _model.ReleasedPointer(1.0, 2.0);
                        _model.Undo();
            _model.Redo();
        }

        // Test
        [TestMethod()]
        public void DrawTest()
        {
            _model.PressedPointer(1.0, 2.0);
            _model.Draw(_mockIGraphics);
            _model.MovedPointer(1.0, 2.0);
            _model.ReleasedPointer(1.0, 2.0);
            _model.Draw(_mockIGraphics);
        }

        // Test
        [TestMethod()]
        public void GetShapeTextTest()
        {
            string test = _model.ShapeText;
        }

        // Test
        [TestMethod()]
        public void EnableTest()
        {
            bool test;
            test = _model.IsLineEnable;
            test = _model.IsRedoEnable;
            test = _model.IsUndoEnable;
        }
    }
}