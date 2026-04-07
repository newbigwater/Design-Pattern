using _01.Creational_Pattern.AbstractFactory.Version_03._02._DAO;
using _01.Creational_Pattern.AbstractFactory.Version_03._03._Concrete.Oracle;

namespace _01.Creational_Pattern.AbstractFactory.Version_03._04._Factory
{
    public class AbstractFactory_DAO_Oracle_Factory : AbstractFactory_DAO_Factory
    {
        public override AbstractFactory_DAO_UserInfo CreateUserInfoDao()
        {
            return new AbstractFactory_DAO_Oracle_UserInfo();
        }

        public override AbstractFactory_DAO_Product CreateProductDao()
        {
            return new AbstractFactory_DAO_Oracle_Product();
        }
    }
}
