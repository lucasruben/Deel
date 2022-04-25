using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SampleFramework;

namespace Deel
{
	[TestClass]
	public class HomePage : BaseSampleApplicationPage
	{
		public HomePage(IWebDriver driver) : base(driver) { }

		public bool IsVisible
		{
			get { return Driver.Title.Contains(PageTitle); }

			internal set { }
		}

		private string PageTitle => "Good Morning, Lucas!";
		public IWebElement Greeting => Driver.FindElement(By.XPath("//*[@id='root']/div[2]/div[2]/div/div[1]/div/div/div/div[1]/h1"));
		public IWebElement CreateContactButton => Driver.FindElement(By.XPath("//*[@id='root']/div[2]/div[1]/div/div/div/div[2]/div/div/div[2]/div[1]/a[2]"));

		internal void GoToCreateContact()
		{
			Driver.Navigate().GoToUrl("https://app.deel.training/");
			CreateContactButton.Click();
		}
	}
}
