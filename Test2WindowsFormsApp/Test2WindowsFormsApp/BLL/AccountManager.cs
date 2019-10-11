using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2WindowsFormsApp.Repository;
using Test2WindowsFormsApp.Model;

namespace Test2WindowsFormsApp.BLL
{
    public class AccountManager
    {
        AccountRepository _accountRepository = new AccountRepository();
        public bool Update(Account account)
        {
            return _accountRepository.Update(account);
        }
        public bool WithUpdate(Account account)
        {
            return _accountRepository.WithUpdate(account);
        }
        public bool AddAmount(Account account)
        {
            return _accountRepository.AddAmount(account);
        }
    }
}
