using System;

using System.Text;

using UserN;
using ITradableN;

namespace AccountN
{
    public abstract class Account : ITradable
    {
       
        protected User owner; //user
        protected String type; //shared, not shared
        protected int number; //unique id
        protected int amounts;

        protected Account(User owner, String type, int number, int amounts)
        {
            this.owner = owner;
            this.type = type;
            this.number = number;
            this.amounts = amounts;
        }

        //Itradable
        public abstract void Sell(int money); //deposit
        public abstract void Buy(int money); //withdraw
        public abstract void Statement(); //account statement
    }
}
