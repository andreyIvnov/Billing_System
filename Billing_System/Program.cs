using System;
using System.Collections;
using System.Collections.Generic;
using static Billing_System.BillingSystem;

namespace Billing_System
{
    class Program
    {
        static void Main(string[] args)//VC number is: 2 
        {
            VIPCustomer VC = new VIPCustomer("Andrey");
            RegularCustomer RC = new RegularCustomer("Eytan");
            RegularCustomer RC1 = new RegularCustomer("John", 25);
            VIPCustomer VC1 = new VIPCustomer("Kety");
            RegularCustomer RC2 = new RegularCustomer("Georgy", 1500);


            BillingSystem customers = new BillingSystem();
            customers.AddCustomer(VC);
            customers.AddCustomer(RC);
            customers.AddCustomer(RC1);
            customers.AddCustomer(VC1);
            customers.AddCustomer(RC2);
            //Console.WriteLine("<====I prefer the for loop becose they can stop the loop before a Null objects of Array(I Have a num of Customer)======>\n\n");
            Console.WriteLine(customers);

            //Console.WriteLine("UpdateBalance(amount) Method Testing \namount = 100");
            //customers.UpdateBalance(100);
            //Console.WriteLine(customers);

            //Console.WriteLine("Should you make any changes to the Billing System to acknowledge the new Customer classes? Why not?");
            //Console.WriteLine("Not necessary, ");

            ////Console.WriteLine("Enter a Name: "); // Indexers Testing
            ////string name = Console.ReadLine();    // Indexers Testing
            ////Console.WriteLine(customers[name]);  // Indexers Search by Name Testing
            ////Console.WriteLine("A id num is: ");
            ////int idnum = int.Parse(Console.ReadLine());
            //Console.WriteLine(customers[4, "fff"]); //Indexers Search by Id number and Name
            ////Console.WriteLine(customers[idnum]);//by Location in a List

            //try
            //{
            ////  Console.WriteLine("\n\n\nCustomer whit id: 8 searched");
            ////  Console.WriteLine(customers[8]);
            ////    Console.WriteLine("\n\n\nIndexer by NAME (Joja)");
            ////    Console.WriteLine(customers["Joja"]);
            ////    Console.WriteLine("\n\n\nCustomer by id 2 and name Eytan");
            ////    Console.WriteLine(customers[2, "hhhh"]);
            //}
            //catch (IndexOutOfRangeException outOfRangeEx)
            //{
            //    throw new IndexOutOfRangeException(outOfRangeEx.Message);
            //}
            //catch (NotCorrectNameException nameExce)
            //{
            //    throw new NotCorrectNameException(nameExce.Message);
            //}
            //catch (Exception exce)
            //{
            //    throw new Exception(exce.Message);
            //}

            /*Sortytng testing*/
            //Console.WriteLine("SortByCustomerType() Method Testing:\n");
            //customers.SortByCustomerType();
            //Console.WriteLine(customers+"\n\n");

            //Console.WriteLine("CustomerSortingByName() Method Testing:\n");
            //customers.Sort(new CustomerSortingByName());
            //Console.WriteLine(customers);

            //Console.WriteLine("CustomerSortingByBalance() Method Testing:\n");
            //customers.Sort(new CustomerSortingByBalance());
            //Console.WriteLine(customers);

            #region Events Testing

            //CustomerService cs = new CustomerService(customers);
            //AccountingClerk ac = new AccountingClerk(customers);
            //            /*
            //             *  customers.SaiToAccountingClerk();
            //             *  customers.SaiToCustomerService();
            //             */
            //Console.WriteLine("UpdateBalance(amount) EVENT Method Testing \namount = 2100");
            //customers.UpdateBalance(2100);
            //Console.WriteLine("\n\n" + customers);
            //customers.ChargingCalls();

            #endregion
           
            Console.ReadLine();
        }

    }
}
