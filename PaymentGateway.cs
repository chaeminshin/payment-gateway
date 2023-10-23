using System;

using IConnectionN;
using ITradableN;
using AccountN;
using BankN;
using SharesN;
using GoodsN;

using UserN;

namespace PaymentGatewayN
{
    class PaymentGateway
    {
        static void Main(string[] args)
        {
            User user = new User("chaemin0708", "1234abcd", "Chaemin Shin");
           
            IConnection connection = user;
            connection.Connection();

            Account sharesAccount = new Shares(user, "Not Shared", 1111122222, 50000, "Shares", "", 10);
            ITradable tradableShares = sharesAccount;

            Account goodsAccount = new Goods(user, "Not Shared", 1000010000, 30000, "Good1", "Grams");
            ITradable tradableGoods = goodsAccount;

            Account bankAccount = new Bank(user, "Not Shared", 1234567890, 10000, "CAD");
            ITradable tradableBank = bankAccount;

            tradableShares.Buy(1000);
            tradableShares.Sell(7000);

            tradableGoods.Buy(200);
            tradableGoods.Sell(100);

            tradableBank.Buy(100);
            tradableBank.Sell(700);

            
            tradableShares.Statement();
            tradableGoods.Statement();
            tradableBank.Statement();


            connection.Disconnection();
        }
    }
}
