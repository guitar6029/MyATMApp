using System;
using MyATMApp.Domain.Entities;
using MyATMApp.UI;

namespace MyATMApp.App
{
    public class ATMApp
    {

        private List<UserAccount> userAccountList;
        private UserAccount selectedAccount;

        public void InitializeData()
        {
            userAccountList = new List<UserAccount>
            {
                new UserAccount{AccountId=1, FullName = "Joe Smith", AccountNumber=123456, CardNumber=123123, CardPin=123, AccountBalance=4500, IsLocked=false},
                new UserAccount{AccountId=2, FullName = "Mike Smith", AccountNumber=654321, CardNumber=321321, CardPin=321, AccountBalance=5500, IsLocked=false},
                new UserAccount{AccountId=1, FullName = "Joe Smith", AccountNumber=4456123, CardNumber=789789, CardPin=456, AccountBalance=8500, IsLocked=true},
            };
        }

    }
}