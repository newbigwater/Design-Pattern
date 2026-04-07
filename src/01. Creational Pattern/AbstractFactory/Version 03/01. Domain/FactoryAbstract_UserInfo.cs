namespace _01.Creational_Pattern.AbstractFactory.Version_03._01._Domain
{
    public class FactoryAbstract_UserInfo
    {
        private string _userId;
        private string _passwd;
        private string _userName;

        public string UserId
        {
            get => _userId;
            set => _userId = value;
        }

        public string Passwd
        {
            get => _passwd;
            set => _passwd = value;
        }

        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }
    }
}
