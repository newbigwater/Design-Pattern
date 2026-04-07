using _01.Creational_Pattern.AbstractFactory.Version_03._02._DAO;

namespace _01.Creational_Pattern.AbstractFactory.Version_03._03._Concrete.Oracle
{
    public class AbstractFactory_DAO_Oracle_Product : AbstractFactory_DAO_ProductBase
    {
        protected override string ProviderName => "Oracle";
    }
}
