using OpenQA.Selenium;

namespace SampleFramework
{
	public class BaseSampleApplicationPage
	{
		protected IWebDriver Driver { get; set; }

		public BaseSampleApplicationPage(IWebDriver driver)
		{
			Driver = driver;
		}
	}
}