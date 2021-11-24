using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsTestAutomation.Utilities
{
    [Binding]
    class Hooks
    {
        static AventStack.ExtentReports.ExtentReports extent;
        static AventStack.ExtentReports.ExtentTest feature;
        static AventStack.ExtentReports.ExtentTest scenario;

        static string reportPath = System.IO.Directory.GetParent(@"../../../").FullName
            + Path.DirectorySeparatorChar + "Result"
            + Path.DirectorySeparatorChar + "Result_" + DateTime.Now.ToString("ddMMyyyy HHmmss")
            + Path.DirectorySeparatorChar;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtentHtmlReporter extentHtmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(extentHtmlReporter);
        }


        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            feature = extent.CreateTest(context.FeatureInfo.Title);
        }


        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext context)
        {
            scenario = feature.CreateNode(context.ScenarioInfo.Title);
        }

        [AfterScenario]
        public static void AfterScenario(ScenarioContext context)
        {
            // Screenshot
            string imgPath = ScreenShot.SaveScreenshot(CommonDriver.driver, reportPath, context.ScenarioInfo.Title);
            scenario.Log(Status.Info, "Snapshot below: " + scenario.AddScreenCaptureFromPath(imgPath));
        }

        [AfterStep]
        public static void AfterStep(ScenarioContext context)
        {
            if (context.TestError == null)
            {
                scenario.Log(Status.Pass, context.StepContext.StepInfo.Text);
            }
            else if (context.TestError != null)
            {
                scenario.Log(Status.Fail, context.StepContext.StepInfo.Text);
            }
        }

        [AfterFeature]
        public static void AfterFeature(FeatureContext context)
        {
            extent.Flush();
        }

    }
}
