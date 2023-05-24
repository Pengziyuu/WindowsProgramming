using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork.Tests
{
    [TestClass()]
    public class MainFormUITest
    {
        private Robot _robot;
        private string targetAppPath;
        private const string MENU_FORM = "MenuForm";

        // init
        [TestInitialize]
        public void Initialize()
        {
            var projectName = "HW";
            string solutionPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
            targetAppPath = Path.Combine(solutionPath, projectName, "bin", "Debug", "HW.exe");
            _robot = new Robot(targetAppPath, MENU_FORM);
        }

        // test
        [TestCleanup()]
        public void Cleanup()
        {
            _robot.CleanUp();
        }

        // test
        private void RunAddBook()
        {
            _robot.ClickButton("Book Borrowing System");
            _robot.SwitchTo("BookBorrowingForm");
            _robot.ClickButton("加入借書單");
        }

        // test
        private void RunAddQuantity()
        {
            _robot.ClickDataGridViewCellBy("_bookDataGridView", 0, "數量");
            _robot.ClickDataGridViewCellBy("_bookDataGridView", 0, "數量");
            _robot.ClickButton("Up");
            _robot.ClickButton("Up");
        }

        // test
        private void RunBorrow()
        {
            _robot.CloseMessageBox();
            _robot.ClickButton("確認借書");
        }

        // test
        [TestMethod]
        public void TestBorrow1()
        {
            RunAddBook();
            _robot.AssertEnable("加入借書單", false);
            RunAddQuantity();
            _robot.AssertText("65535", "同本書一次限借兩本");
            RunBorrow();
            _robot.AssertText("65535", "【微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書】2本\r \r以成功借出");
            _robot.CloseMessageBox();
        }

        // test
        private void RunReturnBook()
        {
            _robot.ClickDataGridViewCellBy("_bookDataGridView", 0, "還書");
            _robot.CloseMessageBox();
        }

        // test
        private void RunCheckBorrow()
        {
            _robot.ClickButton("Book Borrowing System");
            _robot.SwitchTo("BookBorrowingForm");
            _robot.ClickButton("查看我的書包");
            _robot.ClickButton("加入借書單");
            _robot.ClickButton("確認借書");
            _robot.CloseMessageBox();
        }

        // test
        [TestMethod]
        public void TestBorrow2()
        {
            RunCheckBorrow();
            _robot.AssertText("_lastLabel", "4");
            _robot.SwitchTo("BackPackForm");
            _robot.AssertDataGridViewRowCountBy("_bookDataGridView", 1);
            RunReturnBook();
            _robot.AssertDataGridViewRowCountBy("_bookDataGridView", 0);
            _robot.SwitchTo("BookBorrowingForm");
            _robot.AssertText("_lastLabel", "5");
        }

        // test
        private void RunInventoryReturn()
        {
            _robot.ClickDataGridViewCellBy("_bookDataGridView", 0, "還書");
            _robot.CloseMessageBox();
        }

        // test
        private void RunInventoryBorrow()
        {
            _robot.ClickButton("Book Inventory System");
            _robot.ClickButton("Book Borrowing System");
            _robot.SwitchTo("BookBorrowingForm");
            _robot.ClickButton("查看我的書包");
            _robot.ClickButton("加入借書單");
            _robot.ClickButton("確認借書");
            _robot.CloseMessageBox();
        }

        // test
        [TestMethod]
        public void TestBorrow3()
        {
            RunInventoryBorrow();
            _robot.SwitchTo("BookInventoryForm");
            _robot.AssertDataGridViewRowDataBy("_inventoryDataGridView", 0, new string[] { "微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", "6月暢銷書", "4", "", "", ""});
            _robot.SwitchTo("BackPackForm");
            RunInventoryReturn();
            _robot.SwitchTo("BookInventoryForm");
            _robot.AssertDataGridViewRowDataBy("_inventoryDataGridView", 0, new string[] { "微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", "6月暢銷書", "5", "", "", "" });
        }

        // test
        private void RunAddingData1()
        {
            _robot.ClickButton("Book Inventory System");
            _robot.SwitchTo("BookInventoryForm");
        }

        // test
        private void RunAddingData2()
        {
            _robot.ClickDataGridViewCellBy("_inventoryDataGridView", 0, "補貨");
            _robot.SwitchTo("BookAddingForm");
        }

        // test
        [TestMethod]
        public void TestInventory1()
        {
            RunAddingData1();
            _robot.AssertText("_richTextBox", "微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書\r編號 : 964 8394:2-5 2021\r作者 : ingectar-e\r出版項 : 原點出版 : 大雁發行, 2021[民110]");
            RunAddingData2();
            _robot.AssertText("_richTextBox1", "書籍名稱 : 微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書\r\r書籍類別 : 6月暢銷書\r庫存數量 : 5");
            _robot.ClickButton("取消");
            _robot.AssertDataGridViewRowDataBy("_inventoryDataGridView", 0, new string[] { "微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", "6月暢銷書", "5", "", "", "" });
        }

        // test
        private void RunAdding()
        {
            _robot.ClickButton("Book Borrowing System");
            _robot.ClickButton("Book Inventory System");
            _robot.SwitchTo("BookInventoryForm");
            _robot.ClickDataGridViewCellBy("_inventoryDataGridView", 0, "補貨");
            _robot.SwitchTo("BookAddingForm");
            _robot.ClickButtonById("_textBox");
            _robot.Send("2");
            _robot.ClickButton("確認");

        }

        // test
        [TestMethod]
        public void TestInventory2()
        {
            RunAdding();
            _robot.AssertDataGridViewRowDataBy("_inventoryDataGridView", 0, new string[] { "微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書", "6月暢銷書", "7", "", "", "" });
        }

        // test
        private void RunManagement()
        {
            _robot.ClickButton("Book Management System");
            _robot.SwitchTo("BookManagementForm");
            _robot.ClickButton("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書");
            _robot.ClickButtonById("_nameTextBox");
            _robot.Send("aaaa");
        }

        // test
        [TestMethod]
        public void TestManagement1()
        {
            RunManagement();
            _robot.AssertEnable("儲存", true);
            _robot.ClickButtonById("_nameTextBox");
            SendKeys.Send("^A");
            SendKeys.Send("{DELETE}");
            _robot.AssertEnable("儲存", false);
        }

        // test
        private void RunManagementChange1()
        {
            _robot.ClickButton("Book Borrowing System");
            _robot.ClickButton("Book Management System");
            _robot.SwitchTo("BookManagementForm");
            _robot.ClickButton("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書");

            _robot.ClickButtonById("_numberTextBox");
            SendKeys.Send("^A");
            SendKeys.Send("{DELETE}");
            _robot.Send("1234567");

            _robot.ClickButtonById("_nameTextBox");
            SendKeys.Send("^A");
            SendKeys.Send("{DELETE}");
            _robot.Send("原子習慣");

            _robot.ClickButtonById("_peopleTextBox");
            SendKeys.Send("^A");
            SendKeys.Send("{DELETE}");
            _robot.Send("James Clear");

            _robot.ClickButtonById("_comboBox");
            _robot.ClickButton("職場必讀");
            _robot.ClickButton("儲存");
        }

        // test
        private void RunCheckChange1()
        {
            _robot.SwitchTo("BookBorrowingForm");
            _robot.ClickButtonById("LessButton");
            _robot.ClickTabControl("職場必讀");
            _robot.ClickButton("0");
        }

        // test
        [TestMethod]
        public void TestManagement2()
        {
            RunManagementChange1();
            _robot.AssertTextName("原子習慣", "原子習慣");
            RunCheckChange1();
            _robot.AssertText("_bookRichTextBox", "原子習慣\r編號 : 1234567\r作者 : James Clear\r出版項 : 原點出版 : 大雁發行, 2021[民110]");
        }

        // test
        private void RunManagementChange2()
        {
            _robot.ClickButton("Book Inventory System");
            _robot.ClickButton("Book Management System");
            _robot.SwitchTo("BookManagementForm");
            _robot.ClickButton("微調有差の日系新版面設計 : 一本前所未有、聚焦於「微調細節差很大」的設計參考書");

            _robot.ClickButtonById("_numberTextBox");
            SendKeys.Send("^A");
            SendKeys.Send("{DELETE}");
            _robot.Send("1234567");

            _robot.ClickButtonById("_nameTextBox");
            SendKeys.Send("^A");
            SendKeys.Send("{DELETE}");
            _robot.Send("原子習慣");

            _robot.ClickButtonById("_peopleTextBox");
            SendKeys.Send("^A");
            SendKeys.Send("{DELETE}");
            _robot.Send("James Clear");

            _robot.ClickButtonById("_comboBox");
            _robot.ClickButton("職場必讀");
            _robot.ClickButton("儲存");
        }

        // test
        private void RunCheckChange2()
        {
            _robot.SwitchTo("BookInventoryForm");
        }

        // test
        [TestMethod]
        public void TestManagement3()
        {
            RunManagementChange2();
            _robot.AssertTextName("原子習慣", "原子習慣");
            RunCheckChange2();
            _robot.AssertDataGridViewRowDataBy("_inventoryDataGridView", 0, new string[] { "原子習慣", "職場必讀", "5", "", "", "" });
        }
    }
}
                      