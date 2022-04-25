using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Deel
{
	[TestClass]
	[TestCategory("Dashboard")]
	public class Dashboard
	{
		private IWebDriver Driver { get; set; }
		public CreateContactPage CreateContactPage { get; private set; }
		public HomePage HomePage { get; private set; }
		public Contract Contract { get; private set; }
		public IWebElement CreateContactButton => Driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div/div/div/div[2]/div/div/div[2]/div[1]/a[2]/div"));

		[TestMethod]
		[Description("Required test")]
		[TestProperty("Author", "Lucas Ruben")]
		public void TestMethod1()
		{
			HomePage.GoToCreateContact();
		}

		private IWebDriver GetChromeDriver()
		{
			var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			return new ChromeDriver(path);
		}

		[TestInitialize]
		public void SetupForEveryTest()
		{
			Driver = GetChromeDriver();
			
			Contract = new Contract();
			Contract.StartDate = DateTime.Now.AddDays(-1);
			Contract.TaxResidence = "United States / Colorado";
			Contract.Rate.Amount = 1000;
			Contract.Rate.Currency = "GBP";
			Contract.Rate.Periodicity = "Week";
		}

		[TestCleanup]
		public void CleanUpAfterEveryTest()
		{
			Driver.Close();
			Driver.Quit();
		}

	}
}
