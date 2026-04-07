using System;
using _01.Creational_Pattern.AbstractFactory.Version_01._01._Domain;
using _01.Creational_Pattern.AbstractFactory.Version_01._02._DAO;

namespace _01.Creational_Pattern.AbstractFactory.Version_01._03._Concrete.MySQL
{
    public class AbstractFactory_DAO_MySQL_Product : AbstractFactory_DAO_Product
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

        public string InsertProduct(FactoryAbstract_Product product)
        {
            var value = $"insert into MYSQL DB productId = {product.ProductId}";
            Console.WriteLine(value);

            return value;
        }

        public string UpdateProduct(FactoryAbstract_Product product)
        {
            var value = $"update into MYSQL DB productId = {product.ProductId}";
            Console.WriteLine(value);

            return value;
        }

        public string DeleteProduct(FactoryAbstract_Product prodcut)
        {
            var value = $"delete from MYSQL DB productId = {prodcut.ProductId}";
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