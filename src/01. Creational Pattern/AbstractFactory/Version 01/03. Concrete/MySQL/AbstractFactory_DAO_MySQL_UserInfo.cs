using System;
using _01.Creational_Pattern.AbstractFactory.Version_01._01._Domain;
using _01.Creational_Pattern.AbstractFactory.Version_01._02._DAO;

namespace _01.Creational_Pattern.AbstractFactory.Version_01._03._Concrete.MySQL
{
    public class AbstractFactory_DAO_MySQL_UserInfo : AbstractFactory_DAO_UserInfo
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Fields                   ◀



        #endregion // Fields

        #region ▶  Properties               ◀

        #endregion // Properties

        ////////////////////////////////////////

        #region ▶  Constructor              ◀

        #endregion // Constructor

        ////////////////////////////////////////

        #region ▶  Override                 ◀

        #region ▶  Override : Predicate     ◀

        #endregion // Override : Predicate

        #region ▶  Override : Event Handler ◀

        #endregion // Override : Event Handler

        #region ▶  Override : Function      ◀

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

        #endregion // Override : Function

        #endregion // Override

        ////////////////////////////////////////

        #region ▶  Method                   ◀

        #region ▶  Method : Predicate       ◀

        #endregion // Method : Predicate

        #region ▶  Method : Event Handler   ◀

        #endregion // Method : Event Handler

        #region ▶  Method : Function	    ◀

        #endregion // Method : Function

        #endregion // Method
    }
}