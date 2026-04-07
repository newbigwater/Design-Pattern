using System;
using _01.Creational_Pattern.AbstractFactory.Version_02._01._Domain;
using _01.Creational_Pattern.AbstractFactory.Version_02._02._DAO;

namespace _01.Creational_Pattern.AbstractFactory.Version_02._03._Concrete.MySQL
{
    public class AbstractFactory_DAO_MySQL_UserInfo : AbstractFactory_DAO_UserInfo
    {
        public string InsertUserInfo(FactoryAbstract_UserInfo userInfo)
        {
            var value = $"insert into MySQL DB userId = {userInfo.UserId}";
            Console.WriteLine(value);
            return value;
        }

        public string UpdateUserInfo(FactoryAbstract_UserInfo userInfo)
        {
            var value = $"update into MySQL DB userId = {userInfo.UserId}";
            Console.WriteLine(value);
            return value;
        }

        public string DeleteUserInfo(FactoryAbstract_UserInfo userInfo)
        {
            var value = $"delete from MySQL DB userId = {userInfo.UserId}";
            Console.WriteLine(value);
            return value;
        }
    }
}
