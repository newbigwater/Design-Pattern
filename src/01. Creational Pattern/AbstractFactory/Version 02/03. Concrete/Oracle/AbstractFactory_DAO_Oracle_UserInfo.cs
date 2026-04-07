using System;
using _01.Creational_Pattern.AbstractFactory.Version_02._01._Domain;
using _01.Creational_Pattern.AbstractFactory.Version_02._02._DAO;

namespace _01.Creational_Pattern.AbstractFactory.Version_02._03._Concrete.Oracle
{
    public class AbstractFactory_DAO_Oracle_UserInfo : AbstractFactory_DAO_UserInfo
    {
        public string InsertUserInfo(FactoryAbstract_UserInfo userInfo)
        {
            var value = $"insert into Oracle DB userId = {userInfo.UserId}";
            Console.WriteLine(value);
            return value;
        }

        public string UpdateUserInfo(FactoryAbstract_UserInfo userInfo)
        {
            var value = $"update into Oracle DB userId = {userInfo.UserId}";
            Console.WriteLine(value);
            return value;
        }

        public string DeleteUserInfo(FactoryAbstract_UserInfo userInfo)
        {
            var value = $"delete from Oracle DB userId = {userInfo.UserId}";
            Console.WriteLine(value);
            return value;
        }
    }
}
