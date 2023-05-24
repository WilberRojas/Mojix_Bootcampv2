using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.test_todoist
{
    [TestClass]
    public class todoist_base
    {
        [TestInitialize]
        public void OpenBrowser()
        {
            session.Session.Instance().GetBrowser().Navigate().GoToUrl("https://todoist.com");
        }

        [TestCleanup]
        public void CloseBrowser()
        {         
            session.Session.Instance().CloseBrowser();
        }
    }
}
