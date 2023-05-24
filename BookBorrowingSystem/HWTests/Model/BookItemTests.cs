using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Tests
{
    [TestClass()]
    public class BookItemTests
    {
        BookItem _bookItem;

        // TestCase
        [TestInitialize()]
        public void Initialize()
        {
            _bookItem = new BookItem();
            _bookItem.Quantity = 5;
            _bookItem.Category = "6月暢銷書";
            _bookItem.Name = "微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書";
            _bookItem.IsBookNumber = "964 8394:2-5 2021";
            _bookItem.Author = "ingectar-e";
            _bookItem.Publish = "原點出版 : 大雁發行, 2021[民110]";
            _bookItem.Source = "../../../image/1.jpg";
            _bookItem.Number = 1;
            _bookItem.ReturnNumber = 1;
            _bookItem.QuantityBorrowed = 1;
            _bookItem.BorrowingDate = "2022/11/08";
            _bookItem.ReturnDate = "2022/12/08";
        }

        // TestCase
        [TestMethod()]
        public void BookItemTest()
        {
            Assert.AreEqual("6月暢銷書", _bookItem.Category);
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", _bookItem.Name);
            Assert.AreEqual(5, _bookItem.Quantity);
            Assert.AreEqual("964 8394:2-5 2021", _bookItem.IsBookNumber);
            Assert.AreEqual("ingectar-e", _bookItem.Author);
            Assert.AreEqual("原點出版 : 大雁發行, 2021[民110]", _bookItem.Publish);
            Assert.AreEqual("../../../image/1.jpg", _bookItem.Source);
            Assert.AreEqual(1, _bookItem.Number);
            Assert.AreEqual(1, _bookItem.ReturnNumber);
            Assert.AreEqual(1, _bookItem.QuantityBorrowed);
            Assert.AreEqual("2022/11/08", _bookItem.BorrowingDate);
            Assert.AreEqual("2022/12/08", _bookItem.ReturnDate);
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書\n編號 : 964 8394:2-5 2021\n作者 : ingectar-e\n出版項 : 原點出版 : 大雁發行, 2021[民110]", _bookItem.BookData);
            Assert.AreEqual("書籍名稱 : 微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書\n\n書籍類別 : 6月暢銷書\n庫存數量 : 5", _bookItem.AddBookData);
        }

        // TestCase
        [TestMethod()]
        public void BorrowBookTest()
        {
            _bookItem.BorrowBook();
            Assert.AreEqual(4, _bookItem.Quantity);
        }

        // TestCase
        [TestMethod()]
        public void ReturnBookTest()
        {
            _bookItem.ReturnBook();
            Assert.AreEqual(6, _bookItem.Quantity);
        }

        // TestCase
        [TestMethod()]
        public void SetTest()
        {
            _bookItem.Set("1");
            Assert.AreEqual("../../../image/1.jpg", _bookItem.Source);
        }
    }
}