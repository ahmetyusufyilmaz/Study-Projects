using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            foreach (var car in carManager.GetByDailyPrice(30,60))
            {
                Console.WriteLine($"Car ID: {car.Id} - Brand:{car.BrandName} - Color:{car.ColorName} => {car.DailyPrice} $\n");
             
            }

            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.ContactName);
            }

           
           
        }
    }
}
