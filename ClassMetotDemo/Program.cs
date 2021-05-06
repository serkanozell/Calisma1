using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.Id = 1;
            customer1.Name = "Serkan";
            customer1.Surname = "ÖZEL";
            customer1.City = "İstanbul";


            Customer customer2 = new Customer();

            customer2.Id = 2;
            customer2.Name = "Ahmet";
            customer2.Surname = "Ali";
            customer2.City = "Ankara";


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


            customerManager.List(customer1, customer2);


            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
        }
    }
}
