using FirstPass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace PasswordBankTests {
    [TestClass()]
    public class MasterFormTests : FirstPassSession {
        private string TargetFileLocation = Directory.GetCurrentDirectory() + @"\";
        private const string TestFileCSV = "TestFile.csv";
        private const string TestFileGZ = "TestFile.csv.gz";
        private const string BaseGzFile = @"..\..\..\TestResources\CompressorTestResources\BaseGzFile.csv.gz";

        /// <summary>
        /// Goes through the process of creating a new password bank file.
        /// </summary>
        [TestMethod()]
        public void CreateFileTest() {
            // Act

            // Working in the master form
            ApplicationSession.FindElementByName("CreateNewButton").Click();
            ApplicationSession.FindElementByName("Yes").Click();

            // Save current working file if one is opened
            try {
                Thread.Sleep(TimeSpan.FromSeconds(1)); // Wait for 1 second in case save as dialog appears
                ApplicationSession.FindElementByName("Yes").Click();
            }
            catch { }

            Thread.Sleep(TimeSpan.FromSeconds(1));

            // Working in the save dialog
            ApplicationSession.FindElementByAccessibilityId("FileNameControlHost").SendKeys(TargetFileLocation + TestFileCSV);
            ApplicationSession.FindElementByName("Save").Click();

            // Check if the Save As dialog appears when there's a leftover test file from previous test run
            try {
                Thread.Sleep(TimeSpan.FromSeconds(1)); // Wait for 1 second in case save as dialog appears
                ApplicationSession.FindElementByName("Confirm Save As").FindElementByName("Yes").Click();
            }
            catch { }
            Thread.Sleep(TimeSpan.FromSeconds(1));

            // Working in master password gen form
            ApplicationSession.FindElementByName("PassEntry1").SendKeys("password");
            ApplicationSession.FindElementByName("PassEntry2").SendKeys("password");
            ApplicationSession.FindElementByName("Ok").Click();
            Thread.Sleep(TimeSpan.FromSeconds(1));

            // Working in master password print pop up form
            ApplicationSession.FindElementByName("No").Click();
            Thread.Sleep(TimeSpan.FromSeconds(3)); // Wait for 1.5 seconds until the window title is updated

            // Assert
            Assert.IsTrue(File.Exists(TargetFileLocation + TestFileGZ));
        }
        
        /// <summary>
        /// Goes through the process of loading a new password bank file.
        /// </summary>
        [TestMethod()]
        public void LoadFileTest() {
            // Arrange
            LoadFileTestReset();

            // Act

            // Working in the master form
            ApplicationSession.FindElementByName("OpenFileButton").Click();

            // Save current working file if one is opened
            try {
                Thread.Sleep(TimeSpan.FromSeconds(2)); // Wait for 1 second in case save as dialog appears
                ApplicationSession.FindElementByName("Yes").Click();
            }
            catch { }
            Thread.Sleep(TimeSpan.FromSeconds(5));

            // Working in the load dialog
            ApplicationSession.FindElementByClassName("Edit").SendKeys(TargetFileLocation + TestFileGZ);
            ApplicationSession.FindElementByClassName("Button").FindElementByName("Open").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            // Working in enter password for file form
            ApplicationSession.FindElementByName("PasswordEntry").SendKeys("password");
            ApplicationSession.FindElementByName("Ok").Click();

            // Assert
            Assert.AreEqual(FileOP.GetFile(), TestFileCSV);
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context) {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanup() {
            TearDown();
        }

        public static void LoadFileTestReset() {
            if (!File.Exists(TestFileGZ)) {
                DirectoryInfo TestCSVInfo = new DirectoryInfo(BaseGzFile);
                File.Copy(TestCSVInfo.FullName, TestFileGZ);
            }
        }

    }
}
