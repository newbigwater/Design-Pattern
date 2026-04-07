using System;
using _01.Creational_Pattern.AbstractFactory.Version_03._01._Domain;

namespace _01.Creational_Pattern.AbstractFactory.Version_03._02._DAO
{
    public abstract class AbstractFactory_DAO_ProductBase : AbstractFactory_DAO_Product
    {
        protected abstract string ProviderName { get; }

        public string InsertProduct(FactoryAbstract_Product product)
        {
            return WriteCommand("INSERT", ValidateProduct(product).ProductId);
        }

        public string UpdateProduct(FactoryAbstract_Product product)
        {
            return WriteCommand("UPDATE", ValidateProduct(product).ProductId);
        }

        public string DeleteProduct(FactoryAbstract_Product product)
        {
            return WriteCommand("DELETE", ValidateProduct(product).ProductId);
        }

        private FactoryAbstract_Product ValidateProduct(FactoryAbstract_Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            return product;
        }

        private string WriteCommand(string command, string productId)
        {
            var value = $"{command} {ProviderName} Product productId = {productId}";
            Console.WriteLine(value);
            return value;
        }
    }
}
