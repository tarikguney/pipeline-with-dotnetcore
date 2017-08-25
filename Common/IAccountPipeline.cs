using System;

namespace Common
{
    public interface IAccountPipeline
    {
        Account Process(Account account);
    }
}
