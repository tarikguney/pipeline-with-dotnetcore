using System;
using Common;

namespace BalanceChecker
{
    public class Pipeline : IAccountPipeline
    {
        public Account Process(Account account)
        {
            if (account.Balance < 1000 && account.Balance > 500)
            {
                account.Status = AccountStatus.Average;
            }
            else if (account.Balance > 1000 && account.Balance < 2000)
            {
                account.Status = AccountStatus.Good;
            }
            else if (account.Balance > 2000 && account.Balance < 3000)
            {
                account.Status = AccountStatus.Great;
            }
            return account;
        }
    }
}
