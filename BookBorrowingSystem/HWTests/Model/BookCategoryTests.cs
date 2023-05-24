using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Tests
{
    [TestClass()]
    public class BookCategoryTests
    {
        BookCategory _bookCategory;
        // TestCase
        [TestInitialize()]
        public void Initialize()
        {
            _bookCategory = new BookCategory("6月暢銷書");
        }

        // TestCase
        [TestMethod()]
        public void BookCategoryTest()
        {

        }

        // TestCase
        [TestMethod()]
        public void GetDataTest()
        {
            Assert.AreEqual("6月暢銷書", _bookCategory.GetData());
        }
    }
}