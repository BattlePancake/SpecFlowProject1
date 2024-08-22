using NUnit.Allure.Core;
using NUnit.Framework;
using SpecFlowProject1.Elements;
using SpecFlowProject1.Factory;
using SpecFlowProject1.Pages;

namespace SpecFlowProject1.StepDefinitions
{
    [AllureNUnit]
    [Binding]
    public sealed class Definition
    {
        [Given("Open page (.*)")]
        public void OpenPage(string url)
        {
            Driver.GetDriver().Navigate().GoToUrl("https://app.qase.io/login");

        }

        [When("Fill (.*) into the (.*) field")]
        public void FillTheField(string data, string fieldName)
        {
            Element element = Page.GetElementByName(fieldName);
            element.SendValue(data);
        }

        [When("Click on (.*)")]
        public void ClickButton(string elementName)
        {
            Element element = Page.GetElementByName(elementName);
            element.ClickElement();
        }

        [Then("Check that (.*) is correct")]
        public void CheckName(string profileName)
        {
            Element element = Page.GetElementByName(profileName);
            Assert.That(element.GetElementAttribute("value"), Is.EqualTo(Page.ProfileFirstName3));
        }
    }
}
