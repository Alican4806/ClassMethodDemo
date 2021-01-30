using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public static void AddCustomer (Musteri customer)
        {
            Console.WriteLine("Bilgileri " + customer.CustomerName+ " " + customer.CustomerSurname + " " + customer.CustomerAge+ " olan müşteri eklendi");
        }

        public static void DeleteCustomer(Musteri customer)
        {
            Console.WriteLine("{1} {2}  müşteri silindi", customer.CustomerName, customer.CustomerSurname);
        }

        public static void CustomerList(Musteri[] customers)
        {
            foreach (var aaa in customers)
            {
                Console.WriteLine(aaa.CustomerName + " " + aaa.CustomerSurname + " " + aaa.CustomerAge);

            }
        }
    }
}
