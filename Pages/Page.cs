using OpenQA.Selenium;
using SpecFlowProject1.Elements;

namespace SpecFlowProject1.Pages
{
    internal class Page
    {
        public const string ProfileFirstName3 = "1TestName1";

        public static Element _emailField = new Element(By.XPath("//*[@name='email']"));
        public static Element _passwordField = new(By.XPath("//*[@name='password']"));
        public static Element _signInButton = new(By.XPath("//*[@type='submit']"));

        private static Element _profileIcon = new(By.XPath("//*[@class='CmRKGs']//img"));
        private static Element _profileLink = new(By.XPath("//*[@class='SynGa1']//div//div//ul[2]//li[2]"));
        private static Element _firstNameField = new(By.XPath("//*[@id='firstName']"));

        public static Element _notificationsButton = new(By.XPath("//*[@aria-label='Notifications']//div"));

        public static void ClickOnElement(Element element) => element.ClickElement();
        public static string GetTheElementText(Element element) => element.GetElementText();

        public static Element GetElementByName(string name)
        {
            return name switch
            {
                "Email" => _emailField,
                "Password" => _passwordField,
                "Sign In Button" => _signInButton,
                "Profile Icon" => _profileIcon,
                "Profile Link" => _profileLink,
                "Your First Name" => _firstNameField,
                _ => throw new ArgumentException($"Element with name '{name}' not found")
            };
        }
    }
}