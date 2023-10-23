using System;
using System.Collections.Generic;
using System.Text;

using AccountN;
using UserN;

namespace SharesN
{
    public sealed class Shares : Account
    {
        private String shares;
        private String bonds;
        private int percentage; //shareholder’s percentage for the shares

        public Shares(User owner, String type, int number, int amounts, String shares, String bonds, int percentage) : base(owner, type, number, amounts)
        {
            this.owner = owner;
            this.type = type;
            this.number = number;
            this.amounts = amounts;
            this.shares = shares;
            this.bonds = bonds;
            this.percentage = percentage;

            Console.WriteLine(this.Category() + " Account.\n");
        }
        public string Category()
        {
            if (this.shares.Equals(""))
            {
                return this.bonds;
            }
            else
            {
                return this.shares;
            }
        }
        public override void Buy(int money) 
        {
            this.amounts += money;
            Console.WriteLine(this.Category() + " has been bought.\n");
        }
        public override void Sell(int money) 
        {
            this.amounts -= money;
            Console.WriteLine(this.Category() + " has been sold.\n");
        }
        public override void Statement()
        {
            Console.WriteLine("==Shares/Bonds Account Statement=====================================================");
            Console.WriteLine("Owner username: " + this.owner.GetUsername() + ", Owner name: " + this.owner.GetName() + ", Type: " + this.type);
            Console.WriteLine("Number: " + this.number + ", Amounts: " + this.amounts + ", percentage: " + this.percentage);
            Console.WriteLine("=====================================================================================\n");
        }
        public void Transfer()
        {
            Console.WriteLine("It has been transferred");
        }
    }
}
