using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
     class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " Kişisi eklendi.");
        }

        public void List(Customer customer1, Customer customer2)
        {
            Customer[] customerList = new Customer[]
            {
                customer1,
                customer2
            };

            foreach (var customer in customerList)
            {
                Console.WriteLine("Adı : " + customer.Name);
                Console.WriteLine("Soyadı : " + customer.Surname);
                Console.WriteLine("Şehir : " + customer.City);
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(" Kişisi silindi" + customer.Name);
        }
    }
}
