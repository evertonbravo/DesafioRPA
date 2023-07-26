using Cursos.Domain.Interface;
using Cursos.Domain.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioRPA
{
    public class AutomacaoWeb
    {
        public IWebDriver driver;
        public AutomacaoWeb()
        {
            driver = new ChromeDriver();
        }

        public void TestWeb()
        {
            string titulo; string professor; string carga; string descricao;
            driver.Navigate().GoToUrl("https://www.alura.com.br");
            driver.FindElement(By.Name("query")).SendKeys("RPA");
            driver.FindElement(By.XPath("/html/body/main/section[1]/header/div/nav/div[1]/form/button")).Click();
            IList<IWebElement> elements = driver.FindElements(By.ClassName("busca-resultado-link"));
            foreach (IWebElement e in elements)
            {
                string endereco = e.GetAttribute("href").ToString() ;
                driver.Navigate().GoToUrl(endereco);

                titulo = driver.FindElement(By.ClassName("curso-banner-course-title")).Text;
                titulo = titulo + driver.FindElement(By.ClassName("course--banner-text-category")).Text;
                carga = driver.FindElement(By.ClassName("courseInfo-card-wrapper-infos")).Text;
                descricao = driver.FindElement(By.ClassName("courseInfo-card-wrapper-infos")).Text;


                
            }
            

            
        }
    }
}
