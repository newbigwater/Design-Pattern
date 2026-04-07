namespace _01.Creational_Pattern.AbstractFactory.Version_03._01._Domain
{
    public class FactoryAbstract_Product
    {
        private string _productId;
        private string _productName;

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
    }
}
