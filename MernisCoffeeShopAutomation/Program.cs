using MernisCoffeeShopAutomation.Abstract;
using MernisCoffeeShopAutomation.Adapters;
using MernisCoffeeShopAutomation.Concrete;
using MernisCoffeeShopAutomation.Entities;
using System;

namespace MernisCoffeeShopAutomation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseCustomerManager customerManager = new NeroCustomerManager();
            //customerManager.Save(new Customer { FirstName = "Engin", LastName = "Demiroğ", DateYear = 1985, NationalityId = 28861499108 });

            BaseCustomerManager customerManager1 = new StarbucksCustomerManager(new MernisServiceAdapter(), new CustomerCheckManager());
            customerManager1.Save(new Customer { FirstName = "Gökhan", LastName = "Gök", DateYear = 1999, NationalityId = 1234567890 });

            Customer customer = new Customer();
            customer.FirstName = "Gokhan";
            customerManager1.Buy(customer, new Product() { ProductName = "Coffee" });
        }
    }
}
