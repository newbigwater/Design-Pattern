namespace _01.Creational_Pattern.AbstractFactory.Version_02._01._Domain
{
    public class FactoryAbstract_Product
    {
        #region ▶  Event Handle             ◀
        #endregion // Event Handle

        #region ▶  Fields                   ◀
        private string _productId;
        private string _productName;
        #endregion // Fields

        #region ▶  Properties               ◀
        public string ProductId
        {
            get => _productId;
            set => _productId = value;
        }

        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }
        #endregion // Properties
    }
}
