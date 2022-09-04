using System;
using MyATMApp.Domain.Entities;
using MyATMApp.Domain.Interfaces;
using MyATMApp.UI;

namespace MyATMApp.App
{
    public class ATMApp : IUserLogin
    {

        private List<UserAccount> userAccountList;
        private UserAccount selectedAccount;

        public void InitializeData()
        {
            userAccountList = new List<UserAccount>
            {
                new UserAccount{AccountId=1, FullName = "Joe Smith", AccountNumber=123456, CardNumber=123123, CardPin=123123, AccountBalance=4500, IsLocked=false},
                new UserAccount{AccountId=2, FullName = "Mike Smith", AccountNumber=654321, CardNumber=321321, CardPin=321321, AccountBalance=5500, IsLocked=false},
                new UserAccount{AccountId=1, FullName = "Joe Smith", AccountNumber=4456123, CardNumber=789789, CardPin=456456, AccountBalance=8500, IsLocked=true},
            };
        }

        public void CheckUserCardNumAndPassword()
        {
            bool isCorrectLogin = false;

            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.CardNumber = Validator.Convert<long>("your card number");
            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card pin number please"));




        }

    }
}