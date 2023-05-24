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
    public class MenuPresentationModelTests
    {
        MenuPresentationModel _menuPresentationModel;

        // TestCase
        [TestInitialize()]
        public void Initialize()
        {
            _menuPresentationModel = new MenuPresentationModel();
        }

        // TestCase
        [TestMethod()]
        public void MenuPresentationModelTest()
        {
        }

        // TestCase
        [TestMethod()]
        public void ChangeBorrowingButtonStateTest()
        {
            _menuPresentationModel.ChangeBorrowingButtonState();
            Assert.AreEqual(false, _menuPresentationModel.IsBorrowingButtonEnable());

        }

        // TestCase
        [TestMethod()]
        public void ChangeInventoryButtonStateTest()
        {
            _menuPresentationModel.ChangeInventoryButtonState();
            Assert.AreEqual(false, _menuPresentationModel.IsInventoryButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void ChangeManagementButtonStateTest()
        {
            _menuPresentationModel.ChangeManagementButtonState();
            Assert.AreEqual(false, _menuPresentationModel.IsManagementButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsBorrowingButtonEnableTest()
        {
            Assert.AreEqual(true, _menuPresentationModel.IsBorrowingButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsInventoryButtonEnableTest()
        {
            Assert.AreEqual(true, _menuPresentationModel.IsInventoryButtonEnable());
        }

        // TestCase
        [TestMethod()]
        public void IsManagementButtonEnableTest()
        {
            Assert.AreEqual(true, _menuPresentationModel.IsManagementButtonEnable());
        }
    }
}