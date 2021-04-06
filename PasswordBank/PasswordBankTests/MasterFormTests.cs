using FirstPass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace PasswordBankTests {
    [TestClass()]
    public class MasterFormTests : FirstPassSession {
        private string TargetFileLocation = Directory.GetCurrentDirectory() + @"\";
        private const string TestFileCSV = "TestFile.csv";
        private const string TestFileGZ = "TestFile.csv.gz";
        private const string BaseGzFile = @"..\..\..\TestResources\MasterFormTestResources\BaseGzFile.csv.gz";
        private const string BaseGzFileWithKey = @"..\..\..\TestResources\MasterFormTestResources\BaseGzFileWithKey.csv.gz";
        private const string TestKeyFile = @"..\..\..\TestResources\MasterFormTestResources\TestKeyFile.png";

        /// <summary>
        /// Goes through the process of creating a new password bank file.
        /// </summary>
        [TestMethod()]
        public void CreateFileTest() {
            // Arrange
            DirectoryInfo keyFileInfo = new DirectoryInfo(TestKeyFile);
            string keyFilePath = keyFileInfo.FullName;

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

            // Working in the windows save dialog
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

            Thread.Sleep(TimeSpan.FromSeconds(3));

            // Assert
            Assert.IsTrue(File.Exists(TargetFileLocation + TestFileGZ));
        }

        /// <summary>
        /// Goes through the process of creating a new password bank file that uses a key file.
        /// </summary>
        [TestMethod()]
        public void CreateFileWithKeyTest() {
            // Arrange
            DirectoryInfo keyFileInfo = new DirectoryInfo(TestKeyFile);
            string keyFilePath = keyFileInfo.FullName;

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

            // Working in the windows save dialog
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
            ApplicationSession.FindElementByName("KeyFileCheckBox").Click();
            ApplicationSession.FindElementByName("FindKeyFile").Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            // Working in the windows open dialog
            ApplicationSession.FindElementByClassName("Edit").SendKeys(keyFilePath);
            ApplicationSession.FindElementByClassName("Button").FindElementByName("Open").Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            // Working in the master password gen form
            ApplicationSession.FindElementByName("Ok").Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            // Working in master password print pop up form
            ApplicationSession.FindElementByName("No").Click();

            Thread.Sleep(TimeSpan.FromSeconds(3));

            // Assert
            Assert.IsTrue(File.Exists(TargetFileLocation + TestFileGZ));
        }

        /// <summary>
        /// Goes through the process of loading a password bank file.
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
                ApplicationSession.FindElementByName("No").Click();
            }
            catch { }
            Thread.Sleep(TimeSpan.FromSeconds(5));

            // Working in the load dialog
            ApplicationSession.FindElementByClassName("Edit").SendKeys(TargetFileLocation + TestFileGZ);
            ApplicationSession.FindElementByClassName("Button").FindElementByName("Open").Click();

            Thread.Sleep(TimeSpan.FromSeconds(5));

            // Working in enter password for file form
            ApplicationSession.FindElementByName("PasswordEntry").SendKeys("password");
            ApplicationSession.FindElementByName("Ok").Click();

            Thread.Sleep(TimeSpan.FromSeconds(5));

            // Assert
            Assert.AreEqual(TestFileCSV, FileOP.GetFile());

            ApplicationSession.FindElementByName("LockButton").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            ApplicationSession.FindElementByName("Yes").Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        /// <summary>
        /// Goes through the process of loading a password bank file.
        /// </summary>
        [TestMethod()]
        public void LoadFileWithKeyTest() {
            // Arrange
            LoadFileWithKeyTestReset();
            DirectoryInfo keyFileInfo = new DirectoryInfo(TestKeyFile);
            string keyFilePath = keyFileInfo.FullName;

            // Act

            // Working in the master form
            ApplicationSession.FindElementByName("OpenFileButton").Click();

            // Save current working file if one is opened
            try {
                Thread.Sleep(TimeSpan.FromSeconds(2)); // Wait for 1 second in case save as dialog appears
                ApplicationSession.FindElementByName("No").Click();
            }
            catch { }

            Thread.Sleep(TimeSpan.FromSeconds(5));

            // Working in the load dialog
            ApplicationSession.FindElementByClassName("Edit").SendKeys(TargetFileLocation + TestFileGZ);
            ApplicationSession.FindElementByClassName("Button").FindElementByName("Open").Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));

            // Working in enter password for file form
            ApplicationSession.FindElementByName("PasswordEntry").SendKeys("password");
            ApplicationSession.FindElementByName("FindKeyFile").Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));

            // Working in Windows' open file dialog
            ApplicationSession.FindElementByClassName("Edit").SendKeys(keyFilePath);
            ApplicationSession.FindElementByClassName("Button").FindElementByName("Open").Click();

            Thread.Sleep(TimeSpan.FromSeconds(5));

            // Working in enter password for file form
            ApplicationSession.FindElementByName("Ok").Click();

            Thread.Sleep(TimeSpan.FromSeconds(5));

            // Assert
            Assert.AreEqual(FileOP.GetFile(), TestFileCSV);

            ApplicationSession.FindElementByName("LockButton").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            ApplicationSession.FindElementByName("Yes").Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        /// <summary>
        /// Goes through the process of editing and then saving a file.
        /// </summary>
        [TestMethod()]
        public void EditTest() {
            // Arrange
            OpenTestFile();

            // Act

            // Working in master form
            ApplicationSession.FindElementByName("AddNewEntry").Click();
            ApplicationSession.FindElementByName("EntryVariablesExpirationTextBox").SendKeys("expdate1");
            ApplicationSession.FindElementByName("EntryVariablesTitleTextBox").SendKeys("title1");
            ApplicationSession.FindElementByName("EntryVariablesUsernameTextBox").SendKeys("user1");
            ApplicationSession.FindElementByName("EntryVariablesUrlTextBox").SendKeys("url1");
            ApplicationSession.FindElementByName("EntryVariablesPasswordTextBox").Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));

            // Working in entry password form
            ApplicationSession.FindElementByName("entryPasswordTextBox").SendKeys("pass1");
            ApplicationSession.FindElementByName("confirmEntryPasswordTextBox").SendKeys("pass1");
            ApplicationSession.FindElementByName("entryPasswordOkButton").Click();

            // Working in master form
            ApplicationSession.FindElementByName("EntryVariablesConfirmButton").Click();
            ApplicationSession.FindElementByName("SaveFileButton").Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));

            // Assert
            Assert.IsTrue(File.Exists(TargetFileLocation + TestFileGZ));

            ApplicationSession.FindElementByName("LockButton").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            ApplicationSession.FindElementByName("Yes").Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        /// <summary>
        /// Goes through the process of editing and then saving a file.
        /// </summary>
        [TestMethod()]
        public void EditWithRandomPasswordTest() {
            // Arrange
            OpenTestFile();

            // Act

            // Working in master form
            ApplicationSession.FindElementByName("AddNewEntry").Click();
            ApplicationSession.FindElementByName("EntryVariablesExpirationTextBox").SendKeys("expdate1");
            ApplicationSession.FindElementByName("EntryVariablesTitleTextBox").SendKeys("title1");
            ApplicationSession.FindElementByName("EntryVariablesUsernameTextBox").SendKeys("user1");
            ApplicationSession.FindElementByName("EntryVariablesUrlTextBox").SendKeys("url1");
            ApplicationSession.FindElementByName("EntryVariablesPasswordTextBox").Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));

            // Working in entry password form
            ApplicationSession.FindElementByName("EntryPasswordRandomizeButton").Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));

            // Working in random password generator form
            ApplicationSession.FindElementByName("Special").Click();
            ApplicationSession.FindElementByName("UpperCase").Click();
            ApplicationSession.FindElementByName("Brackets").Click();
            ApplicationSession.FindElementByName("Digits").Click();
            ApplicationSession.FindElementByName("CloseButton").Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));

            // Working in entry password form
            ApplicationSession.FindElementByName("entryPasswordOkButton").Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));

            // Working in master form
            ApplicationSession.FindElementByName("EntryVariablesConfirmButton").Click();
            ApplicationSession.FindElementByName("SaveFileButton").Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));

            // Assert
            Assert.IsTrue(File.Exists(TargetFileLocation + TestFileGZ));

            ApplicationSession.FindElementByName("LockButton").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            ApplicationSession.FindElementByName("Yes").Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context) {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanup() {
            TearDown();
        }

        /// <summary>
        /// Loads a file into the GUI.
        /// </summary>
        private void OpenTestFile() {
            LoadFileTestReset();

            // Working in the master form
            ApplicationSession.FindElementByName("OpenFileButton").Click();

            // Save current working file if one is opened
            try {
                Thread.Sleep(TimeSpan.FromSeconds(2)); // Wait for 1 second in case save as dialog appears
                ApplicationSession.FindElementByName("No").Click();
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

            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        /// <summary>
        /// Makes sure there is a file to be loaded by the load file test.
        /// </summary>
        private static void LoadFileTestReset() {
            if (File.Exists(TestFileGZ)) {
                File.Delete(TestFileGZ);
            }

            DirectoryInfo TestCSVInfo = new DirectoryInfo(BaseGzFile);
            File.Copy(TestCSVInfo.FullName, TestFileGZ);
        }

        /// <summary>
        /// Makes sure there is a file to be loaded by the load file test.
        /// </summary>
        private static void LoadFileWithKeyTestReset() {
            if (File.Exists(TestFileGZ)) {
                File.Delete(TestFileGZ);
            }

            DirectoryInfo TestCSVInfo = new DirectoryInfo(BaseGzFileWithKey);
            File.Copy(TestCSVInfo.FullName, TestFileGZ);
        }
    }
}
