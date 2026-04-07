using System;
using _01.Creational_Pattern.AbstractFactory.Version_02._01._Domain;
using _01.Creational_Pattern.AbstractFactory.Version_02._02._DAO;

namespace _01.Creational_Pattern.AbstractFactory.Version_02._03._Concrete.Oracle
{
    public class AbstractFactory_DAO_Oracle_Product : AbstractFactory_DAO_Product
    {
        public string InsertProduct(FactoryAbstract_Product product)
        {
            var value = $"insert into Oracle DB productId = {product.ProductId}";
            Console.WriteLine(value);
            return value;
        }

        public string UpdateProduct(FactoryAbstract_Product product)
        {
            var value = $"update into Oracle DB productId = {product.ProductId}";
            Console.WriteLine(value);
            return value;
        }

        public string DeleteProduct(FactoryAbstract_Product product)
        {
            var value = $"delete from Oracle DB productId = {product.ProductId}";
            Console.WriteLine(value);
            return value;
        }
    }
}
