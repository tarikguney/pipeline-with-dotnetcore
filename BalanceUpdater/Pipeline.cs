using System;
using Common;
namespace BalanceUpdater
{
    public class Pipeline : IAccountPipeline
    {
        public Account Process(Account account)
        {
            Console.WriteLine("From Updater");
            return null;
        }
    }
}
