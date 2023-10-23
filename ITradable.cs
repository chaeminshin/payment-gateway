using System;

namespace ITradableN
{
    public interface ITradable
    {
        void Sell(int money); //deposit
        void Buy(int money); //withdraw
        void Statement();
    }
}
