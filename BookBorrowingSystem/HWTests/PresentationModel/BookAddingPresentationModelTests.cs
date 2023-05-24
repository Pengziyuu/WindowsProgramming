using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Tests
{
    [TestClass()]
    public class BookAddingPresentationModelTests
    {
        BookAddingPresentationModel _bookAddingPresentationModel;

        // TestCase
        [TestInitialize()]
        public void Initialize()
        {
            _bookAddingPresentationModel = new BookAddingPresentationModel();
        }

        // TestCase
        [TestMethod()]
        public void BookAddingPresentationModelTest()
        {
        }

        // TestCase
        [TestMethod()]
        public void CheckNumberTest()
        {
            Assert.AreEqual(false, _bookAddingPresentationModel.CheckNumber('9'));
            Assert.AreEqual(true, _bookAddingPresentationModel.CheckNumber('j'));
        }
    }
}