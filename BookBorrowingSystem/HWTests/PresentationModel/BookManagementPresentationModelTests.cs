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
    public class BookManagementPresentationModelTests
    {
        BookManagementPresentationModel _bookManagementPresentationModel;

        // TestCase
        [TestInitialize()]
        public void Initialize()
        {
            _bookManagementPresentationModel = new BookManagementPresentationModel();
        }

        // TestCase
        [TestMethod()]
        public void BookManagementPresentationModelTest()
        {
        }

        // TestCase
        [TestMethod()]
        public void DisableAllTest()
        {
            _bookManagementPresentationModel.DisableAll();
            Assert.AreEqual(false, _bookManagementPresentationModel.IsNameEnable());
            Assert.AreEqual(false, _bookManagementPresentationModel.IsNumberEnable());
            Assert.AreEqual(false, _bookManagementPresentationModel.IsPeopleEnable());
            Assert.AreEqual(false, _bookManagementPresentationModel.IsCategoryEnable());
            Assert.AreEqual(false, _bookManagementPresentationModel.IsPublishEnable());
            Assert.AreEqual(false, _bookManagementPresentationModel.IsSourceEnable());
            Assert.AreEqual(false, _bookManagementPresentationModel.IsBrowseButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void EnableAllTest()
        {
            _bookManagementPresentationModel.EnableAll();
            Assert.AreEqual(true, _bookManagementPresentationModel.IsNameEnable());
            Assert.AreEqual(true, _bookManagementPresentationModel.IsNumberEnable());
            Assert.AreEqual(true, _bookManagementPresentationModel.IsPeopleEnable());
            Assert.AreEqual(true, _bookManagementPresentationModel.IsCategoryEnable());
            Assert.AreEqual(true, _bookManagementPresentationModel.IsPublishEnable());
            Assert.AreEqual(true, _bookManagementPresentationModel.IsSourceEnable());
            Assert.AreEqual(true, _bookManagementPresentationModel.IsBrowseButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void EnableSaveButtonEnableTest()
        {
            _bookManagementPresentationModel.EnableSaveButtonEnable();
            Assert.AreEqual(true, _bookManagementPresentationModel.IsSaveButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void DisableSaveButtonEnableTest()
        {
            _bookManagementPresentationModel.DisableSaveButtonEnable();
            Assert.AreEqual(false, _bookManagementPresentationModel.IsSaveButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsAddButtonEnableTest()
        {
            Assert.AreEqual(false, _bookManagementPresentationModel.IsAddButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsBrowseButtonEnableTest()
        {
            Assert.AreEqual(false, _bookManagementPresentationModel.IsBrowseButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsSaveButtonEnableTest()
        {
            Assert.AreEqual(false, _bookManagementPresentationModel.IsSaveButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsNameEnableTest()
        {
            Assert.AreEqual(false, _bookManagementPresentationModel.IsNameEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsNumberEnableTest()
        {
            Assert.AreEqual(false, _bookManagementPresentationModel.IsNumberEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsPeopleEnableTest()
        {
            Assert.AreEqual(false, _bookManagementPresentationModel.IsPeopleEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsCategoryEnableTest()
        {
            Assert.AreEqual(false, _bookManagementPresentationModel.IsCategoryEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsPublishEnableTest()
        {
            Assert.AreEqual(false, _bookManagementPresentationModel.IsPublishEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsSourceEnableTest()
        {
            Assert.AreEqual(false, _bookManagementPresentationModel.IsSourceEnable());
        }
    }
}