using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace PasswordBankTests {
    public class FirstPassSession {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";

        protected static WindowsDriver<WindowsElement> ApplicationSession;
        protected static WindowsDriver<WindowsElement> DesktopSession;

        public static void Setup(TestContext context) {
            // Create a desktop session
            AppiumOptions DesktopOptions = new AppiumOptions();
            DesktopOptions.AddAdditionalCapability("app", "Root");
            DesktopSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), DesktopOptions);

            // Launch First Pass by using the debug shortkey in Visual Studios
            DesktopSession.Keyboard.SendKeys(Keys.F5);

            Thread.Sleep(TimeSpan.FromSeconds(3));

            var FirstPassWindow = DesktopSession.FindElementByName("PasswordKeeper");
            var FirstPassTopLevelWindowHandle = FirstPassWindow.GetAttribute("NativeWindowHandle");
            FirstPassTopLevelWindowHandle = (int.Parse(FirstPassTopLevelWindowHandle)).ToString("x"); // Convert to Hex

            // Create session by attaching to Cortana top level window
            AppiumOptions appOptions = new AppiumOptions();
            appOptions.AddAdditionalCapability("appTopLevelWindow", FirstPassTopLevelWindowHandle);
            ApplicationSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appOptions);
        }

        public static void TearDown() {

            if (ApplicationSession != null) {
                ApplicationSession.FindElementByName("Close").Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                ApplicationSession.FindElementByName("Yes").Click();
                ApplicationSession.Quit();
                ApplicationSession = null;
            }

            if (DesktopSession != null) {
                DesktopSession.Quit();
                DesktopSession = null;
            }
        }

        protected static string SanitizeBackslashes(string input) => input.Replace("\\", Keys.Alt + Keys.NumberPad9 + Keys.NumberPad2 + Keys.Alt);
    }
}
