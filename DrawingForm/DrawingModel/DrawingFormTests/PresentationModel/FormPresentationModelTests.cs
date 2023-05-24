using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrawingForm.PresentationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moq;
using DrawingModel;

namespace DrawingForm.PresentationModel.Tests
{
    [TestClass()]
    public class FormPresentationModelTests
    {
        DrawingModel.Model _model;
        PresentationModel.FormPresentationModel _presentationModel;
        Panel _canvas = new DoubleBufferedPanel();
        MockIGraphics _mockIGraphics;

        // Test
        [TestInitialize]
        public void Initialize()
        {
            _model = new DrawingModel.Model();
            _presentationModel = new PresentationModel.FormPresentationModel(_model, _canvas);
            _mockIGraphics = new MockIGraphics();

        }

        // Test
        [TestMethod()]
        public void FormPresentationModelTest()
        {
        }

        // Test
        [TestMethod()]
        public void ClickLineTest()
        {
            _presentationModel.ClickLine();
            Assert.AreEqual(_presentationModel.IsLineEnable, false);
            Assert.AreEqual(_presentationModel.IsRectangleEnabled, true);
            Assert.AreEqual(_presentationModel.IsTriangleEnable, true);
        }

        // Test
        [TestMethod()]
        public void ClickTriangleTest()
        {
            _presentationModel.ClickTriangle();
            Assert.AreEqual(_presentationModel.IsRectangleEnabled, true);
            Assert.AreEqual(_presentationModel.IsTriangleEnable, false);
        }

        // Test
        [TestMethod()]
        public void ClickRectangleTest()
        {
            _presentationModel.ClickRectangle();
            Assert.AreEqual(_presentationModel.IsRectangleEnabled, false);
            Assert.AreEqual(_presentationModel.IsTriangleEnable, true);
        }

        // Test
        [TestMethod()]
        public void EnableAllTest()
        {
            _presentationModel.EnableAll();
            Assert.AreEqual(_presentationModel.IsRectangleEnabled, true);
            Assert.AreEqual(_presentationModel.IsTriangleEnable, true);
        }

        // Test
        [TestMethod()]
        public void EnableReleasedTest()
        {
            _presentationModel.EnableReleased();
            Assert.AreEqual(_presentationModel.IsRectangleEnabled, true);
            Assert.AreEqual(_presentationModel.IsTriangleEnable, true);
        }

        // Test
        [TestMethod()]
        public void IsTriangleEnableTest()
        {
            Assert.AreEqual(_presentationModel.IsTriangleEnable, true);
        }

        // Test
        [TestMethod()]
        public void IsRectangleEnabledTest()
        {
            Assert.AreEqual(_presentationModel.IsRectangleEnabled, true);
        }

        // Test
        [TestMethod()]
        public void DrawTest()
        {
            _presentationModel.Draw(_mockIGraphics);
        }
    }
}