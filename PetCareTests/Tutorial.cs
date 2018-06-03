using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System;

namespace PetCareTests
{

    //NUnit attribute (means it is a test)
    [TestFixture]
    public class FirstClass
    {
        //NUnit attribute (means it is a test)
        [Test]
        public void FirstTest()
        {
            // create object ChromeDriver and assign its value to variable "driver"
            var driver = new ChromeDriver();
            
            // driver opens url www.google.com 
            driver.Navigate().GoToUrl("https://www.google.com");
            
            //driver searches for field by.name "q" and assign value to variable "searchbox"
            var searchBox = driver.FindElement(By.Name("q"));
            
            // enter 'spring' in the text field 
            searchBox.SendKeys("Spring" + Keys.Enter);
            
            // verify title is "Spring"
            driver.Title.ShouldBe("Spring - Google Search", "Page Title");
            
            //driver closes the browser
            driver.Quit();
        }
    }
}




[TestFixture]
class DemoQa
{
    [Test]
    public void DemoTest()
    {
        var driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://demoqa.com/contact/");

        var yourName = driver.FindElement(By.Name("your-name"));
        yourName.SendKeys("Inna");

        var yourEmail = driver.FindElement(By.Name("your-email"));
        yourEmail.SendKeys("test11@test.com");

        var subject = driver.FindElement(By.Name("your-subject"));
        subject.SendKeys("test subject");

        var yourMessage = driver.FindElement(By.Name("your-message"));
        yourMessage.SendKeys("test message");

        var sendButton = driver.FindElement(By.ClassName("wpcf7-submit"));
        sendButton.Click();

        var resultMessage = driver.FindElementByClassName("wpcf7-mail-sent-ok");
        Assert.That(resultMessage.Text, Is.EqualTo("Your message was sent successfully. Thanks."));
        // coment test
        driver.Quit();
    }
}
