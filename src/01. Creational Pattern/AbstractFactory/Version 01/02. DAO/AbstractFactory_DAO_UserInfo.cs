using _01.Creational_Pattern.AbstractFactory.Version_01._01._Domain;

namespace _01.Creational_Pattern.AbstractFactory.Version_01._02._DAO
{
    public interface AbstractFactory_DAO_UserInfo
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Properties               ◀

        #endregion // Properties

        #region ▶  Method : Predicate	    ◀

        #endregion // Method : Predicate

        #region ▶  Method : Event Handler   ◀

        #endregion // Method : Event Handler

        #region ▶  Method : Function	    ◀
        string InsertUserInfo(FactoryAbstract_UserInfo userInfo);
        string UpdateUserInfo(FactoryAbstract_UserInfo userInfo);
        string DeleteUserInfo(FactoryAbstract_UserInfo userInfo);

        #endregion // Method : Function
    }
}