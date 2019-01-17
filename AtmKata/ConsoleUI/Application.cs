using AtmKata.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmKata.ConsoleUI
{
    public class Application:IApplication
    {
        private IBusinessLogic _business;
        public Application(IBusinessLogic business)
        {
            _business = business;
        }

        public void Run()
        {
            Console.Write("Alice retire 150 : ");           
            Console.WriteLine(Resultat.ListOfBill(_business.WithDraw("Alice", 150),_business.GetDab()));
            Console.WriteLine("Stock du DAB : "+Resultat.DabStock(_business.GetDab()));
            Console.WriteLine("Nouveau Solde de Alice : "+_business.GetBalanceByName("Alice"));
           

            Console.Write("Jean retire 220 : ");
            Console.WriteLine(Resultat.ListOfBill(_business.WithDraw("Jean", 220), _business.GetDab()));
            Console.WriteLine("Stock du DAB : " + Resultat.DabStock(_business.GetDab()));
            Console.WriteLine("Nouveau Solde de Jean : " + _business.GetBalanceByName("Jean"));

            Console.Write("Paul retire 100 : ");
            Console.WriteLine(Resultat.ListOfBill(_business.WithDraw("Paul", 100), _business.GetDab()));
            Console.WriteLine("Stock du DAB : " + Resultat.DabStock(_business.GetDab()));
            Console.WriteLine("Nouveau Solde de Paul : " + _business.GetBalanceByName("Paul"));

            Console.Write("Alice retire 30 : ");
            Console.WriteLine(Resultat.ListOfBill(_business.WithDraw("Alice", 30), _business.GetDab()));
            Console.WriteLine("Stock du DAB : " + Resultat.DabStock(_business.GetDab()));
            Console.WriteLine("Nouveau Solde de Alice : " + _business.GetBalanceByName("Alice"));

            Console.Write("Jean retire 50 : ");
            Console.WriteLine(Resultat.ListOfBill(_business.WithDraw("Jean", 50), _business.GetDab()));
            Console.WriteLine("Stock du DAB : " + Resultat.DabStock(_business.GetDab()));
            Console.WriteLine("Nouveau Solde de Jean : " + _business.GetBalanceByName("Jean"));

            Console.Write("Paul retire 40 : ");
            Console.WriteLine(Resultat.ListOfBill(_business.WithDraw("Paul", 40), _business.GetDab()));
            Console.WriteLine("Stock du DAB : " + Resultat.DabStock(_business.GetDab()));
            Console.WriteLine("Nouveau Solde de Paul : " + _business.GetBalanceByName("Paul"));
            Console.ReadLine();
        }
    }
}
