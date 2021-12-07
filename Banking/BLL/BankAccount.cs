using System;

namespace BLL
{
    public class BankAccount
    {
        // champs d'encapsulation parce que private
        private decimal balance;
        private Person owner;
        private AccountType type;

        public decimal GetBalance()
        {
            return balance;
        }
        public Person GetOwner()
        {
            return owner;
        }
        public AccountType GetAccountType()
        {
            return type;
        }
        public decimal Deposit(decimal pAmount)
        {
            //Test de garde
            if (pAmount <= 0) throw new Exception("Le dépôt doit être positif");
            balance += pAmount;
            return balance;

        }

        public bool Withdraw(decimal pAmount)
        {
            if (pAmount > balance) return false;
            balance -= pAmount;
            return true;
        }
    }
}
