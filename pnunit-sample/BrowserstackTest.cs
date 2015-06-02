using NUnit.Framework;
using PNUnit.Framework;
using System;
using System.Web;
using System.Text;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace PNunitSample
{
	[TestFixture()]
	public class BrowserstackTest
	{
		private IWebDriver driver;
		private string[] testParams;

		[SetUp]
		public void Init()
		{
			testParams = PNUnitServices.Get().GetTestParams();
			String params1 = String.Join(",", testParams);
			Console.WriteLine(params1);
			String browser = testParams[0];
			String version = testParams[1];
			String os = testParams[2];
			String os_version = testParams[3];
			DesiredCapabilities capability =  new DesiredCapabilities();
			capability.SetCapability("browserName", browser);
			capability.SetCapability(CapabilityType.Version, version);
			capability.SetCapability("os", os);
			capability.SetCapability("os_version", os_version);
			capability.SetCapability("browserstack.user", "<BrowserStack.user>");
			capability.SetCapability("browserstack.key", "<BrowserStack.key>");

			Console.WriteLine("Capabilities" + capability.ToString());

			driver = new RemoteWebDriver(new Uri("http://hub.browserstack.com:80/wd/hub/"), capability);
		}


		[Test]
		public void TestCase()
		{
			driver.Navigate().GoToUrl("http://www.google.com");
			StringAssert.Contains("Google", driver.Title);
			IWebElement query = driver.FindElement(By.Name("q"));
			query.SendKeys("Browserstack");
			query.Submit();
		}

		[TearDown]
		public void Cleanup()
		{
			driver.Quit();
		}
	}
}
