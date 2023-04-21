using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            //burada hata alıyorum nedenini anlayamadım.
            

            CustomerManager customerManager = new CustomerManager ();
            customerManager.Add(new Customer { CompanyName = "Furkan Holding" });
            customerManager.Add(new Customer { CompanyName = "Burak Holding" });
        }
    }
}