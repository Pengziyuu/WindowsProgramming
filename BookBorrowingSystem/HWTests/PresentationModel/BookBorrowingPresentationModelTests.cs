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
    public class BookBorrowingPresentationModelTests
    {
        Model _model;
        BookBorrowingPresentationModel _bookBorrowingPresentationModel;


        // TestCase
        [TestInitialize()]
        public void Initialize()
        {
            _model = new Model();
            _bookBorrowingPresentationModel = new BookBorrowingPresentationModel(_model);
        }

        // TestCase
        [TestMethod()]
        public void BookBorrowingPresentationModelTest()
        {
        }

        // TestCase
        [TestMethod()]
        public void SetButtonTest()
        {
        }

        // TestCase
        [TestMethod()]
        public void GetBorrowMessageTest()
        {
            _bookBorrowingPresentationModel.GetBorrowMessage();
        }

        // TestCase
        [TestMethod()]
        public void GetTotalButtonTest()
        {
            _bookBorrowingPresentationModel.GetTotalButton();
        }

        // TestCase
        [TestMethod()]
        public void GetTotalPageTest()
        {
            //_bookBorrowingPresentationModel.GetTotalPage();
        }

        // TestCase
        [TestMethod()]
        public void RefreshTest()
        {
            //_bookBorrowingPresentationModel.Refresh(0, 0);
        }

        // TestCase
        [TestMethod()]
        public void SetBookListTest()
        {
            _bookBorrowingPresentationModel.SetBookList();
        }

        // TestCase
        [TestMethod()]
        public void AddBackPackDataTest()
        {
            _bookBorrowingPresentationModel.AddBackPackData();
        }

        // TestCase
        [TestMethod()]
        public void CheckQuantityTest()
        {
            //_bookBorrowingPresentationModel.CheckQuantity(0, 0);
        }

        // TestCase
        [TestMethod()]
        public void ControlUpPageButtonTest()
        {
            _bookBorrowingPresentationModel.ControlUpPageButton(1);
        }

        // TestCase
        [TestMethod()]
        public void ControlDownPageButtonTest()
        {
            _bookBorrowingPresentationModel.ControlDownPageButton(1, 3);
        }

        // TestCase
        [TestMethod()]
        public void CheckBorrowTest()
        {
            _bookBorrowingPresentationModel.CheckBorrow(3);
        }

        // TestCase
        [TestMethod()]
        public void CountNowTabBookTest()
        {
            //_bookBorrowingPresentationModel.CountNowTabBook(3);
        }

        // TestCase
        [TestMethod()]
        public void GetTabFirstBookTest()
        {
            _bookBorrowingPresentationModel.GetTabFirstBook();
        }

        // TestCase
        [TestMethod()]
        public void GetTabLastBookTest()
        {
            _bookBorrowingPresentationModel.GetTabLastBook();
        }

        // TestCase
        [TestMethod()]
        public void AddButtonEnableTest()
        {
            _bookBorrowingPresentationModel.AddButtonEnable();
            Assert.AreEqual(true ,_bookBorrowingPresentationModel.IsAddButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void AddButtonDisableTest()
        {
            _bookBorrowingPresentationModel.AddButtonDisable();
            Assert.AreEqual(false, _bookBorrowingPresentationModel.IsAddButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsAddButtonEnableTest()
        {
            Assert.AreEqual(true, _bookBorrowingPresentationModel.IsAddButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void EnableUpPageButtonTest()
        {
            _bookBorrowingPresentationModel.EnableUpPageButton();
            Assert.AreEqual(true, _bookBorrowingPresentationModel.IsUpPageButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void DisableUpPageButtonTest()
        {
            _bookBorrowingPresentationModel.DisableUpPageButton();
            Assert.AreEqual(false, _bookBorrowingPresentationModel.IsUpPageButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsUpPageButtonEnableTest()
        {
            Assert.AreEqual(false, _bookBorrowingPresentationModel.IsUpPageButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void EnableDownPageButtonTest()
        {
            _bookBorrowingPresentationModel.EnableDownPageButton();
            Assert.AreEqual(true, _bookBorrowingPresentationModel.IsDownPageButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void DisableDownPageButtonTest()
        {
            _bookBorrowingPresentationModel.DisableDownPageButton();
            Assert.AreEqual(false, _bookBorrowingPresentationModel.IsDownPageButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsDownPageButtonEnableTest()
        {
            Assert.AreEqual(true, _bookBorrowingPresentationModel.IsDownPageButtonEnable());  
        }

        // TestCase
        [TestMethod()]
        public void DisableBookButtonTest()
        {
            _bookBorrowingPresentationModel.DisableBookButton();
        }

        // TestCase
        [TestMethod()]
        public void EnableBookButtonTest()
        {
            //_bookBorrowingPresentationModel.EnableBookButton(0);
        }

        // TestCase
        [TestMethod()]
        public void IsBookButtonEnableTest()
        {
            //_bookBorrowingPresentationModel.IsBookButtonEnable(0);
        }

        // TestCase
        [TestMethod()]
        public void DisableCheckBookButtonTest()
        {
            _bookBorrowingPresentationModel.DisableCheckBookButton();
            Assert.AreEqual(false, _bookBorrowingPresentationModel.IsCheckBookButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void EnableCheckBookButtonTest()
        {
            _bookBorrowingPresentationModel.EnableCheckBookButton();
            Assert.AreEqual(true, _bookBorrowingPresentationModel.IsCheckBookButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsCheckBookButtonEnableTest()
        {
            Assert.AreEqual(false, _bookBorrowingPresentationModel.IsCheckBookButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void DisableBackPackButtonTest()
        {
            _bookBorrowingPresentationModel.DisableBackPackButton();
            Assert.AreEqual(false, _bookBorrowingPresentationModel.IsBackPackButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void EnableBackPackButtonTest()
        {
            _bookBorrowingPresentationModel.EnableBackPackButton();
            Assert.AreEqual(true, _bookBorrowingPresentationModel.IsBackPackButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsBackPackButtonEnableTest()
        {
            Assert.AreEqual(true, _bookBorrowingPresentationModel.IsBackPackButtonEnable());
        }
    }
}