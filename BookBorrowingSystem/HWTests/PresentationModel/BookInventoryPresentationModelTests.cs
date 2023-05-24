using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Tests
{
    [TestClass()]
    public class BookInventoryPresentationModelTests
    {
        BookInventoryPresentationModel _bookInventoryPresentationModel;

        // TestCase
        [TestInitialize()]
        public void Initialize()
        {
            _bookInventoryPresentationModel = new BookInventoryPresentationModel();
        }

        // TestCase
        [TestMethod()]
        public void BookInventoryPresentationModelTest()
        {
        }
    }
}