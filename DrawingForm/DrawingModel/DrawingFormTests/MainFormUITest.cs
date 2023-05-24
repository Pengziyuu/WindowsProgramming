using MainFormUITest;
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
            var projectName = "DrawingForm";
            string solutionPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
            targetAppPath = Path.Combine(solutionPath, projectName, "bin", "Debug", "DrawingForm.exe");
            _robot = new Robot(targetAppPath, MENU_FORM);
        }

        // test
        [TestCleanup()]
        public void Cleanup()
        {
            _robot.CleanUp();
        }

        // test
        public void DrawRectangle()
        {
            _robot.ClickButton("Rectangle");
            _robot.DragAndDrop("_canvas", 100, 100, 400, 400);
            _robot.DragAndDrop("_canvas", 200, 200, 200, 200);
        }

        // test
        [TestMethod]
        public void TestRectangle()
        {
            DrawRectangle();
            _robot.AssertText("_label", "Selected : Rectangle(67, 67, 267, 267)");
        }

        // test
        public void DrawTriangle()
        {
            _robot.ClickButton("Triangle");
            _robot.DragAndDrop("_canvas", 600, 100, 800, 400);
            _robot.DragAndDrop("_canvas", 700, 250, 700, 250);
        }

        // test
        [TestMethod]
        public void TestTriangle()
        {
            DrawTriangle();
            _robot.AssertText("_label", "Selected : Triangle(400, 67, 533, 267)");
        }

        // test
        public void DrawLine()
        {
            _robot.ClickButton("Line");
            _robot.DragAndDrop("_canvas", 200, 200, 700, 250);
        }

        // test
        [TestMethod]
        public void TestLine()
        {
            DrawRectangle();
            DrawTriangle();
            DrawLine();
            _robot.DragAndDrop("_canvas", 200, 200, 200, 200);
            _robot.AssertText("_label", "Selected : Rectangle(67, 67, 267, 267)");
            _robot.DragAndDrop("_canvas", 700, 250, 700, 250);
            _robot.AssertText("_label", "Selected : Triangle(400, 67, 533, 267)");
        }

        // test
        public void RunClear()
        {
            _robot.ClickButton("Clear");
        }

        // test
        [TestMethod]
        public void TestClear()
        {
            DrawRectangle();
            RunClear();
        }

        // test
        public void RunUndo()
        {
            _robot.ClickButton("Undo");
        }

        // test
        public void RunRedo()
        {
            _robot.ClickButton("Redo");
        }

        // test
        [TestMethod]
        public void TestAll()
        {
            DrawRectangle();
            DrawTriangle();
            DrawLine();
            RunUndo();
            RunUndo();
            RunRedo();
            RunRedo();
            _robot.DragAndDrop("_canvas", 200, 200, 200, 200);
            _robot.AssertText("_label", "Selected : Rectangle(67, 67, 267, 267)");
            _robot.DragAndDrop("_canvas", 700, 250, 700, 250);
            _robot.AssertText("_label", "Selected : Triangle(400, 67, 533, 267)");
            RunClear();
        }
    }
}
