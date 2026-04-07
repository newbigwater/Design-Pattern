using _01.Creational_Pattern.AbstractFactory.Version_02._01._Domain;

namespace _01.Creational_Pattern.AbstractFactory.Version_02._02._DAO
{
    public interface AbstractFactory_DAO_UserInfo
    {
        string InsertUserInfo(FactoryAbstract_UserInfo userInfo);
        string UpdateUserInfo(FactoryAbstract_UserInfo userInfo);
        string DeleteUserInfo(FactoryAbstract_UserInfo userInfo);
    }
}
