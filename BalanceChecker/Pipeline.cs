using System;
using Common;

namespace BalanceChecker
{
   public class Pipeline : IAccountPipeline
    {
        public Account Process(Account account)
        {
            Console.WriteLine("From Checker");
            return null;
        }
    }
}
