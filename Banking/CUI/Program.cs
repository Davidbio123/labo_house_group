using BLL;
using System;

namespace CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person owner = new Person();
            owner.Name = "david";
            new DateTime();
            owner.SetBirthDate(new DateTime(1990, 01, 29));
            owner.Email = "toto@thetoto.com";
            owner.IdentificationNumber = "4201-220-5181";
            Console.WriteLine("testing===========================");
            Console.WriteLine(owner.IdentificationNumber);
            Console.WriteLine("==================================");
            BankAccount david = new BankAccount();
            
            Console.WriteLine(david.GetBalance());
            Console.WriteLine(david.GetOwner());
            Console.WriteLine(david.GetAccountType());

            david.Deposit(8000);
            david.Withdraw(1);

            Console.WriteLine(david.GetBalance());
            Console.WriteLine(david.GetAccountType());


            NationalRegister numr = new NationalRegister();
            numr.RegisterNumber = "12345";
            string toto = numr.RegisterNumber;
            Console.WriteLine($"cool {toto}");

            long longToto = 29047833322;
            string strtoto = longToto.ToString();
            int inttoto = int.Parse(strtoto.Substring(9, 2));
            Console.WriteLine(inttoto);
        }
    }
}
