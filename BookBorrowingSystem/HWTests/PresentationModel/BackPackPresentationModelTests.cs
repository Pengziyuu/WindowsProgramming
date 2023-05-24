using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Tests
{
    [TestClass()]
    public class BackPackPresentationModelTests
    {
        BackPackPresentationModel _backPackPresentationModel;

        // TestCase
        [TestInitialize()]
        public void Initialize()
        {
            _backPackPresentationModel = new BackPackPresentationModel();
        }

        // TestCase
        [TestMethod()]
        public void BackPackPresentationModelTest()
        {
        }
    }
}