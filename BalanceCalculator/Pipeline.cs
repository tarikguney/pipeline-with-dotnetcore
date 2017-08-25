using System;
using Common;
namespace BalanceCalculator
{
    public class Pipeline : IAccountPipeline
    {
        public Account Process(Account account)
        {
            account.Balance = account.Balance - (account.Balance * 10 / 100);
            return account;
        }
    }
}
