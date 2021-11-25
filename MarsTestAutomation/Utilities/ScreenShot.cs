using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsTestAutomation.Utilities
{
    class ScreenShot
    {
        public static string SaveScreenshot(IWebDriver driver, string folderLocation, string screenShotFileName) // Definition
        {

            if (!System.IO.Directory.Exists(folderLocation))
            {
                System.IO.Directory.CreateDirectory(folderLocation);
            }

            // taking ScreenShoot
            var screenShot = ((ITakesScreenshot)driver).GetScreenshot();

            // create file path
            var fileName = new StringBuilder(folderLocation);

            fileName.Append(screenShotFileName);
            fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
            fileName.Append(".jpeg");

            screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Png);
            return fileName.ToString();
        }
    }
}
