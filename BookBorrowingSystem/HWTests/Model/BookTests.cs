using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Tests
{
    [TestClass()]
    public class BookTests
    {
        Book _book;

        // TestCase
        [TestInitialize()]
        public void Initialize()
        {
            _book = new Book();
            _book.SetBook(0, "微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書");
            _book.SetBook(1, "964 8394:2-5 2021");
            _book.SetBook(2, "ingectar-e");
            _book.SetBook(3, "原點出版 : 大雁發行, 2021[民110]");
        }

        // TestCase
        [TestMethod()]
        public void BookTest()
        {
        }

        // TestCase
        [TestMethod()]
        public void SetBookTest()
        {
        }

        // TestCase
        [TestMethod()]
        public void GetNameTest()
        {
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", _book.GetName());
        }

        // TestCase
        [TestMethod()]
        public void GetIsBookNumberTest()
        {
            Assert.AreEqual("964 8394:2-5 2021", _book.GetIsBookNumber());
        }

        // TestCase
        [TestMethod()]
        public void GetAuthorTest()
        {
            Assert.AreEqual("ingectar-e", _book.GetAuthor());
        }

        // TestCase
        [TestMethod()]
        public void GetPublishTest()
        {
            Assert.AreEqual("原點出版 : 大雁發行, 2021[民110]", _book.GetPublish());
        }

        // TestCase
        [TestMethod()]
        public void GetDataTest()
        {
            Assert.AreEqual("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書\n編號 : 964 8394:2-5 2021\n作者 : ingectar-e\n出版項 : 原點出版 : 大雁發行, 2021[民110]", _book.GetData());
        }
    }
}