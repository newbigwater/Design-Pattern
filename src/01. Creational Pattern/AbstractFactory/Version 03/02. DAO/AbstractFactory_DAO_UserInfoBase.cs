using System;
using _01.Creational_Pattern.AbstractFactory.Version_03._01._Domain;

namespace _01.Creational_Pattern.AbstractFactory.Version_03._02._DAO
{
    public abstract class AbstractFactory_DAO_UserInfoBase : AbstractFactory_DAO_UserInfo
    {
        protected abstract string ProviderName { get; }

        public string InsertUserInfo(FactoryAbstract_UserInfo userInfo)
        {
            return WriteCommand("INSERT", ValidateUserInfo(userInfo).UserId);
        }

        public string UpdateUserInfo(FactoryAbstract_UserInfo userInfo)
        {
            return WriteCommand("UPDATE", ValidateUserInfo(userInfo).UserId);
        }

        public string DeleteUserInfo(FactoryAbstract_UserInfo userInfo)
        {
            return WriteCommand("DELETE", ValidateUserInfo(userInfo).UserId);
        }

        private FactoryAbstract_UserInfo ValidateUserInfo(FactoryAbstract_UserInfo userInfo)
        {
            if (userInfo == null)
            {
                throw new ArgumentNullException(nameof(userInfo));
            }

            return userInfo;
        }

        private string WriteCommand(string command, string userId)
        {
            var value = $"{command} {ProviderName} UserInfo userId = {userId}";
            Console.WriteLine(value);
            return value;
        }
    }
}
