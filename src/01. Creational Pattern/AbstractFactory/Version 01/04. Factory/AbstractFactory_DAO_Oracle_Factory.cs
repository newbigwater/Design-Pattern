using _01.Creational_Pattern.AbstractFactory.Version_01._02._DAO;
using _01.Creational_Pattern.AbstractFactory.Version_01._03._Concrete.Oracle;

namespace _01.Creational_Pattern.AbstractFactory.Version_01._04._Factory
{
    public class AbstractFactory_DAO_Oracle_Factory : AbstractFactory_DAO_Factory
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

        #endregion // Override : Function

        #endregion // Override

        ////////////////////////////////////////

        #region ▶  Method                   ◀

        #region ▶  Method : Predicate       ◀

        #endregion // Method : Predicate

        #region ▶  Method : Event Handler   ◀

        #endregion // Method : Event Handler

        #region ▶  Method : Function	    ◀

        public override AbstractFactory_DAO_UserInfo CreateUserInfoDao()
        {
            return new AbstractFactory_DAO_Oracle_UserInfo();
        }

        public override AbstractFactory_DAO_Product CreateProductDao()
        {
            return new AbstractFactory_DAO_Oracle_Product();
        }

        #endregion // Method : Function

        #endregion // Method
    }
}