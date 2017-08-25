using System;
using Common;
namespace CustomerTypeUpdater
{
    public class Pipeline : IAccountPipeline
    {
        public Account Process(Account account)
        {
            if (account.Balance < 2000)
            {
                account.CustomerType = CustomerType.Regular;
            }
            else if (account.Balance >= 2000)
            {
                account.CustomerType = CustomerType.Premium;
            }
            return account;
        }
    }
}
