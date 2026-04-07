using _01.Creational_Pattern.AbstractFactory.Version_01._01._Domain;

namespace _01.Creational_Pattern.AbstractFactory.Version_01._02._DAO
{
    public interface AbstractFactory_DAO_Product
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
        string InsertProduct(FactoryAbstract_Product product);
        string UpdateProduct(FactoryAbstract_Product product);
        string DeleteProduct(FactoryAbstract_Product prodcut);

        #endregion // Method : Function
    }
}