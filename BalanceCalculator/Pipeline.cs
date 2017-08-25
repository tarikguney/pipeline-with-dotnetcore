using System;
using Common;
namespace BalanceCalculator
{
    public class Pipeline : IAccountPipeline
    {
        public Account Process(Account account)
        {
            Console.WriteLine("From Calculator");
            return null;
        }
    }
}
