using System;
using System.Collections.Generic;
using System.Text;

using UserN;
using AccountN;

namespace GoodsN
{
    class Goods : Account
    {
        private String goodsType; // type of the goods (grams, kilos, Uncas ,...)
        private String tradingUnit;

        public Goods(User owner, String type, int number, int amounts, String goodsType, String tradingUnit) : base(owner, type, number, amounts)
        {
            this.owner = owner;
            this.type = type;
            this.number = number;
            this.amounts = amounts;
            this.goodsType = goodsType;
            this.tradingUnit = tradingUnit;

            Console.WriteLine("Goods Account.\n");
        }

        public override void Buy(int money)
        {
            this.amounts += money;
            Console.WriteLine(this.goodsType + " has been bought. Trading Unit(" + this.tradingUnit + ")\n");
        }
        public override void Sell(int money)
        {
            this.amounts -= money;
            Console.WriteLine(this.goodsType + " has been sold. Trading Unit(" + this.tradingUnit + ")\n");
        }
        public override void Statement()
        {
            Console.WriteLine("==Goods Account Statement============================================================");
            Console.WriteLine("Owner username: " + this.owner.GetUsername() + ", Owner name: " + this.owner.GetName() + ", Type: " + this.type);
            Console.WriteLine("Number: " + this.number + ", Amounts: " + this.amounts + ", Goods Type: " + this.goodsType + ", Trading Unit: " + this.tradingUnit);
            Console.WriteLine("=====================================================================================\n");
        }

    }
}
