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
        private const string TestFileName = @"\SaveTestFile";
        private string TargetSaveLocation = Directory.GetCurrentDirectory();

        /// <summary>
        /// Goes through the process of creating a new password bank file.
        /// </summary>
        [TestMethod()]
        public void CreateFileTest() {
            // Act

            // Working in the master form
            ApplicationSession.FindElementByName("CreateNewButton").Click();
            ApplicationSession.FindElementByName("Yes").Click();
            Thread.Sleep(TimeSpan.FromSeconds(1)); // Wait for next dialog box to pop up

            // Working in the save dialog
            ApplicationSession.FindElementByAccessibilityId("FileNameControlHost").SendKeys(SanitizeBackslashes(TargetSaveLocation + TestFileName));
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
            Assert.IsTrue(File.Exists(TargetSaveLocation + TestFileName + ".csv.gz"));
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context) {
            Setup(context);
        }
    }
}
