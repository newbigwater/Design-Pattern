using _01.Creational_Pattern.AbstractFactory.Version_03._02._DAO;

namespace _01.Creational_Pattern.AbstractFactory.Version_03._03._Concrete.MySQL
{
    public class AbstractFactory_DAO_MySQL_UserInfo : AbstractFactory_DAO_UserInfoBase
    {
        protected override string ProviderName => "MySQL";
    }
}
