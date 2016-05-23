using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SeleniumTest
{
  public class CustomRemoteWebDriver : RemoteWebDriver
  {
    public CustomRemoteWebDriver(Uri remoteAddress, ICapabilities desiredCapabilities) : base(remoteAddress, desiredCapabilities)
    {
    }

    public string getSessionID()
    {
      return base.SessionId.ToString();
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      CustomRemoteWebDriver driver;
      DesiredCapabilities capability = DesiredCapabilities.InternetExplorer();
      capability.SetCapability("browserstack.user", "BROWSERSTACK_USERNAME");
      capability.SetCapability("browserstack.key", "BROWSERSTACK_ACCESS_KEY");
      capability.SetCapability("browserName", "internet explorer");

      driver = new CustomRemoteWebDriver(
        new Uri("http://hub.browserstack.com/wd/hub/"), capability
      );
      driver.Navigate().GoToUrl("http://www.google.com");
      Console.WriteLine(driver.Title);

      IWebElement query = driver.FindElement(By.Name("q"));
      query.SendKeys("Browserstack");
      query.Submit();
      Console.WriteLine(driver.Title);

      //Works without using the subclass for client-side bindings <= 2.48.2
      //var sessionIdProperty = typeof(RemoteWebDriver).GetProperty("SessionId", BindingFlags.Instance | BindingFlags.NonPublic);
      //SessionId sessionId = sessionIdProperty.GetValue(driver, null) as SessionId;
      string sessionId = driver.getSessionID();
      Console.WriteLine(sessionId.ToString());
      
      driver.Quit();
    }
  }
}
