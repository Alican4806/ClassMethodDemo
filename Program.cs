using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri customer1 = new Musteri();
            customer1.Id = 10;
            customer1.CustomerName = "Alican";
            customer1.CustomerSurname = " Kaplancı";
            customer1.CustomerAge = 19;

            Musteri customer2 = new Musteri();
            customer2.Id = 9;
            customer2.CustomerName = "Ali";
            customer2.CustomerSurname = " Kaplancı";
            customer2.CustomerAge = 51;

            Musteri[] customers = new Musteri[] { customer1, customer2 };

            MusteriManager CustomerManager = new MusteriManager();

            Console.WriteLine("Ekle");
            MusteriManager.AddCustomer(customer1);
            
            Console.WriteLine("Sil");
            MusteriManager.DeleteCustomer(customer2);

            Console.WriteLine("Listele");
            MusteriManager.CustomerList(customers);
        }
    }
}
