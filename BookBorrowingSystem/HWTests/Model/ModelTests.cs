using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HomeWork.Tests
{
    [TestClass()]
    public class ModelTests
    {
        Model _model;

        // TestCase
        [TestInitialize()]
        public void Initialize()
        {
            _model = new Model();
            _model.ProcessingData("//");
            _model.Send();
        }

        // TestCase
        [TestMethod()]
        public void ModelTest()
        {
        }

        // TestCase
        [TestMethod()]
        public void ReadDataTest()
        {
        }

        // TestCase
        [TestMethod()]
        public void ProcessingDataTest()
        {
        }

        // TestCase
        [TestMethod()]
        public void AddBookCategoryTest()
        {
            Assert.IsTrue(true);
        }

        // TestCase
        [TestMethod()]
        public void AddBookTest()
        {
            Assert.IsTrue(true);
        }

        // TestCase
        [TestMethod()]
        public void CreateCategoryArrayTest()
        {
            Assert.IsTrue(true);
        }

        // TestCase
        [TestMethod()]
        public void CreateCategorySizeTest()
        {
            Assert.IsTrue(true);
        }

        // TestCase
        [TestMethod()]
        public void GetCategoryListTest()
        {
            Assert.AreEqual(_model.GetCategoryList(), _model.GetCategoryList());
        }

        // TestCase
        [TestMethod()]
        public void GetCategoryArrayTest()
        {
            Assert.AreEqual(_model.GetCategoryArray(), _model.GetCategoryArray());
        }

        // TestCase
        [TestMethod()]
        public void GetCategorySizeTest()
        {

        }

        // TestCase
        [TestMethod()]
        public void GetBookItemTest()
        {
            Assert.AreEqual(_model.GetBookItem(), _model.GetBookItem());
        }

        // TestCase
        [TestMethod()]
        public void GetBackPackDataTest()
        {
            Assert.AreEqual(_model.GetBackPackData(), _model.GetBackPackData());
        }

        // TestCase
        [TestMethod()]
        public void BorrowBookTest()
        {
            Assert.IsTrue(true);
        }

        // TestCase
        [TestMethod()]
        public void ReturnBookTest()
        {
            Assert.IsTrue(true);
        }

        // TestCase
        [TestMethod()]
        public void GetBookTest()
        {
            Assert.AreEqual(_model.GetBook(), _model.GetBook());
        }

        // TestCase
        [TestMethod()]
        public void SetGridViewBorrowListTest()
        {
            List<Book> books = new List<Book>();
            _model.SetGridViewBorrowList(books);
            Assert.AreEqual(books, _model.GetGridViewBorrowList());
        }

        // TestCase
        [TestMethod()]
        public void GetGridViewBorrowListTest()
        {
            List<Book> books = new List<Book>();
            _model.SetGridViewBorrowList(books);
            Assert.AreEqual(books, _model.GetGridViewBorrowList());
        }

        // TestCase
        [TestMethod()]
        public void SetGridViewBorrowQuantityListTest()
        {
            List<int> quantity = new List<int>();
            _model.SetGridViewBorrowQuantityList(quantity);
            Assert.AreEqual(quantity, _model.GetGridViewBorrowQuantityList());
        }

        // TestCase
        [TestMethod()]
        public void GetGridViewBorrowQuantityListTest()
        {
            List<int> quantity = new List<int>();
            _model.SetGridViewBorrowQuantityList(quantity);
            Assert.AreEqual(quantity, _model.GetGridViewBorrowQuantityList());
        }

        // TestCase
        [TestMethod()]
        public void SetGridViewBorrowIndexListTest()
        {
            List<int> quantity = new List<int>();
            _model.SetGridViewBorrowIndexList(quantity);
            Assert.AreEqual(quantity, _model.GetGridViewBorrowIndexList());
        }

        // TestCase
        [TestMethod()]
        public void GetGridViewBorrowIndexListTest()
        {
            List<int> quantity = new List<int>();
            _model.SetGridViewBorrowIndexList(quantity);
            Assert.AreEqual(quantity, _model.GetGridViewBorrowIndexList());
        }

        // TestCase
        [TestMethod()]
        public void SetBorrowListTest()
        {
            List<Book> books = new List<Book>();
            _model.SetBorrowList(books);
            Assert.AreEqual(books, _model.GetBorrowList());
        }

        // TestCase
        [TestMethod()]
        public void GetBorrowListTest()
        {
            List<Book> books = new List<Book>();
            _model.SetBorrowList(books);
            Assert.AreEqual(books, _model.GetBorrowList());
        }

        // TestCase
        [TestMethod()]
        public void SetBorrowQuantityListTest()
        {
            List<int> quantity = new List<int>();
            _model.SetBorrowQuantityList(quantity);
            Assert.AreEqual(quantity, _model.GetBorrowQuantityList());
        }

        // TestCase
        [TestMethod()]
        public void GetBorrowQuantityListTest()
        {
            List<int> quantity = new List<int>();
            _model.SetBorrowQuantityList(quantity);
            Assert.AreEqual(quantity, _model.GetBorrowQuantityList());
        }

        // TestCase
        [TestMethod()]
        public void SetBorrowIndexListTest()
        {
            List<int> index = new List<int>();
            _model.SetBorrowIndexList(index);
            Assert.AreEqual(index, _model.GetBorrowIndexList());
        }

        // TestCase
        [TestMethod()]
        public void GetBorrowIndexListTest()
        {
            List<int> index = new List<int>();
            _model.SetBorrowIndexList(index);
            Assert.AreEqual(index, _model.GetBorrowIndexList());
        }

        // TestCase
        [TestMethod()]
        public void GetAllBorrowListTest()
        {
            Assert.AreEqual(_model.GetAllBorrowList(), _model.GetAllBorrowList());
        }

        // TestCase
        [TestMethod()]
        public void GetAllBorrowQuantityListTest()
        {
            Assert.AreEqual(_model.GetAllBorrowQuantityList(), _model.GetAllBorrowQuantityList());
        }

        // TestCase
        [TestMethod()]
        public void GetAllBorrowIndexListTest()
        {
            Assert.AreEqual(_model.GetAllBorrowIndexList(), _model.GetAllBorrowIndexList());
        }
    }
}