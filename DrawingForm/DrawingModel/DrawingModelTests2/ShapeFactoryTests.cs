using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrawingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel.Tests
{
    [TestClass()]
    public class ShapeFactoryTests
    {
        ShapeFactory _shapeFactory;

        // Test
        [TestInitialize]
        public void Initialize()
        {
            _shapeFactory = new ShapeFactory();
        }

        // Test
        [TestMethod()]
        public void CreateShapeTest()
        {
            _shapeFactory.CreateShape(ShapeType.None);
            _shapeFactory.CreateShape(ShapeType.Line);
            _shapeFactory.CreateShape(ShapeType.Triangle);
            _shapeFactory.CreateShape(ShapeType.Rectangle);
        }
    }
}