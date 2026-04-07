using _01.Creational_Pattern.AbstractFactory.Version_03._01._Domain;

namespace _01.Creational_Pattern.AbstractFactory.Version_03._02._DAO
{
    public interface AbstractFactory_DAO_Product
    {
        string InsertProduct(FactoryAbstract_Product product);
        string UpdateProduct(FactoryAbstract_Product product);
        string DeleteProduct(FactoryAbstract_Product product);
    }
}
