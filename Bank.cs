using System;

using AccountN;
using UserN;

namespace BankN
{
    public sealed class Bank : Account
    {
        private String currencies;

        public Bank(User owner, String type, int number, int amounts, String currencies) : base(owner, type, number, amounts)
        {
            this.owner = owner;
            this.type = type;
            this.number = number;
            this.amounts = amounts;
            this.currencies = currencies;

            Console.WriteLine("Bank Account.\n");
        }
        public override void Buy(int money) //deposit
        {
            this.amounts += money;
            Console.WriteLine(money + " " + currencies + "has been deposited into the account (" + number + ").\n");
        }
        public override void Sell(int money) //withdraw
        {
            this.amounts -= money;
            Console.WriteLine(money + " " + currencies + "has been withdrawn from the account (" + number + ").\n");
        }
        public override void Statement()
        {
            Console.WriteLine("==Bank Account Statement=============================================================");
            Console.WriteLine("Owner username: " + this.owner.GetUsername() + ", Owner name: " + this.owner.GetName() + ", Type: " + this.type);
            Console.WriteLine("Number: " + this.number + ", Currencies: " + this.currencies + ", Amounts: " + this.amounts);
            Console.WriteLine("=====================================================================================\n");
        }
        public void Transfer()
        {
            Console.WriteLine("It has been transferred");
        }
    }
}
