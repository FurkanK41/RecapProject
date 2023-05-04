using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("çalıştı");

            //CustomerManager customerManager1 = new CustomerManager(new EfCustomerDal());
            //customerManager1.Add(new Customer
            //{
            //    CompanyName = "Deneme müşteri"
            //});
            //Console.WriteLine(" müşteri eklendi ");            



        }
    }
}