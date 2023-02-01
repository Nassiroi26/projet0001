using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Org.Xmlpull.V1.Sax2;

namespace projet0001;

public partial class MainPage : ContentPage
{

    
// 1-installer le Nuget Selenium
//    * Aller dans Outils
//    * Choisir Gestionnaire de package Nuget
//    * Choisir gerer les packge Nuget
//    * Cliquer sur parcourir
//    * Saisir seleniums
//    * Choisir selenium.WebDriver.ChromeDriver
//    * Installer le navigateur Chrome
//    * Installer ( si absent ) le driver chrome a l'eoplacement :sur c dans Drivers dans Web

public Mainpage()


 {

InitializeComponent();
        this.LancerNavigateur();
 }

    public void LancerNavigateur()
    {
        // Cree un objet chromedriver
        IWebDriver driver = new ChromeDriver(@"c:\Driver");


        // la methode lance le navigateur à l'adresse google .
        driver.Navigate().GoToUrl("https://google.com ");
    Thread.Sleep(10000);
    // la methode dort pendant  10 seconde

    Driver.Quit ();

        // creer un objet chromedrive
        IWebDriver driver = new ChromeDrive (@"c:\Drivers\Web");
        //la methode lance le navigateur à l'adresse google.com
        driver.Navigate().GoToUrl();
        // la methodetrouver sur la page l'élément définit (ici le bouton accepter
        var element = Driver.FindElement(By.XPath("/html/body/div[(21/");
    // la methode simule un click sur le bouton
    element.Click();
        // je positionnne mon curseur dans la zone de
        element = Driver.FindElement("By).XPath(" / html
         element.SandKeys("asus");
        // je lance la recherche du terme saisi
        element.Submit();
        // la methode dort pendant 3 secondes
        Thread.Sleep(3000);
        // je veut recuperer tous les elements qui continu
        var element = driver.FindElements(By.Tagname)();
        // je veut recuperer le texte de chaque Tag h3
        // Etape 01 - créer une boucle
        foreach (var monElement in elements) ;
        {
            // je mets le texte du h3 dans une case
           

