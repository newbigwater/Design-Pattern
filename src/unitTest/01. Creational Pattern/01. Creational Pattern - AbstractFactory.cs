using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01.Creational_Pattern.AbstractFactory.Version_01._01._Domain;
using _01.Creational_Pattern.AbstractFactory.Version_01._04._Factory;
using Version02Domain = _01.Creational_Pattern.AbstractFactory.Version_02._01._Domain;
using Version02Factory = _01.Creational_Pattern.AbstractFactory.Version_02._04._Factory;
using Version03Domain = _01.Creational_Pattern.AbstractFactory.Version_03._01._Domain;
using Version03Factory = _01.Creational_Pattern.AbstractFactory.Version_03._04._Factory;

namespace unitTest._01._Creational_Pattern
{
    partial class _01_Creational_Pattern
    {
        [TestMethod("[AbstractFactory Ver1 Creates Matching MySQL Family]")]
        public void AbstractFactory_Ver1_Creates_Matching_MySQL_Family()
        {
            var factory = new AbstractFactory_DAO_MySQL_Factory();
            var userDao = factory.CreateUserInfoDao();
            var productDao = factory.CreateProductDao();

            Assert.AreEqual("AbstractFactory_DAO_MySQL_UserInfo", userDao.GetType().Name);
            Assert.AreEqual("AbstractFactory_DAO_MySQL_Product", productDao.GetType().Name);
        }

        [TestMethod("[AbstractFactory Ver1 Oracle Product Message Keeps Baseline]")]
        public void AbstractFactory_Ver1_Oracle_Product_Message_Keeps_Baseline()
        {
            var factory = new AbstractFactory_DAO_Oracle_Factory();
            var productDao = factory.CreateProductDao();
            var product = new FactoryAbstract_Product { ProductId = "P-01" };

            var result = productDao.InsertProduct(product);

            Assert.AreEqual("insert into ORCLE DB productId = P-01", result);
        }

        [TestMethod("[AbstractFactory Ver2 Selects Factory By Name]")]
        public void AbstractFactory_Ver2_Selects_Factory_By_Name()
        {
            var factory = Version02Factory.AbstractFactory_DAO_Factory.CreateFactory(" oracle ");
            var userDao = factory.CreateUserInfoDao();
            var productDao = factory.CreateProductDao();

            Assert.AreEqual("AbstractFactory_DAO_Oracle_UserInfo", userDao.GetType().Name);
            Assert.AreEqual("AbstractFactory_DAO_Oracle_Product", productDao.GetType().Name);
        }

        [TestMethod("[AbstractFactory Ver2 Rejects Unknown Database]")]
        public void AbstractFactory_Ver2_Rejects_Unknown_Database()
        {
            Assert.ThrowsException<System.ArgumentException>(
                () => Version02Factory.AbstractFactory_DAO_Factory.CreateFactory("sqlserver"));
        }

        [TestMethod("[AbstractFactory Ver2 Fixes Oracle Product Message]")]
        public void AbstractFactory_Ver2_Fixes_Oracle_Product_Message()
        {
            var factory = Version02Factory.AbstractFactory_DAO_Factory.CreateFactory("oracle");
            var productDao = factory.CreateProductDao();
            var product = new Version02Domain.FactoryAbstract_Product { ProductId = "P-02" };

            var result = productDao.InsertProduct(product);

            Assert.AreEqual("insert into Oracle DB productId = P-02", result);
        }

        [TestMethod("[AbstractFactory Ver3 Uses Unified Command Format]")]
        public void AbstractFactory_Ver3_Uses_Unified_Command_Format()
        {
            var factory = Version03Factory.AbstractFactory_DAO_Factory.CreateFactory("mysql");
            var userDao = factory.CreateUserInfoDao();
            var userInfo = new Version03Domain.FactoryAbstract_UserInfo { UserId = "U-03" };

            var result = userDao.InsertUserInfo(userInfo);

            Assert.AreEqual("INSERT MySQL UserInfo userId = U-03", result);
        }

        [TestMethod("[AbstractFactory Ver3 Throws On Null Product]")]
        public void AbstractFactory_Ver3_Throws_On_Null_Product()
        {
            var factory = Version03Factory.AbstractFactory_DAO_Factory.CreateFactory("oracle");
            var productDao = factory.CreateProductDao();

            Assert.ThrowsException<System.ArgumentNullException>(() => productDao.InsertProduct(null));
        }

        [TestMethod("[AbstractFactory Ver3 Throws On Null UserInfo]")]
        public void AbstractFactory_Ver3_Throws_On_Null_UserInfo()
        {
            var factory = Version03Factory.AbstractFactory_DAO_Factory.CreateFactory("mysql");
            var userDao = factory.CreateUserInfoDao();

            Assert.ThrowsException<System.ArgumentNullException>(() => userDao.DeleteUserInfo(null));
        }

        [TestMethod("[AbstractFactory Ver3 Scenario Runs User And Product Transactions]")]
        public void AbstractFactory_Ver3_Scenario_Runs_User_And_Product_Transactions()
        {
            var factory = Version03Factory.AbstractFactory_DAO_Factory.CreateFactory("oracle");
            var userDao = factory.CreateUserInfoDao();
            var productDao = factory.CreateProductDao();

            var userInfo = new Version03Domain.FactoryAbstract_UserInfo
            {
                UserId = "12345",
                Passwd = "!@#$%",
                UserName = "홍길동"
            };

            var product = new Version03Domain.FactoryAbstract_Product
            {
                ProductId = "0011AA",
                ProductName = "TV"
            };

            var commands = new[]
            {
                userDao.InsertUserInfo(userInfo),
                userDao.UpdateUserInfo(userInfo),
                userDao.DeleteUserInfo(userInfo),
                productDao.InsertProduct(product),
                productDao.UpdateProduct(product),
                productDao.DeleteProduct(product)
            };

            var expected = new[]
            {
                "INSERT Oracle UserInfo userId = 12345",
                "UPDATE Oracle UserInfo userId = 12345",
                "DELETE Oracle UserInfo userId = 12345",
                "INSERT Oracle Product productId = 0011AA",
                "UPDATE Oracle Product productId = 0011AA",
                "DELETE Oracle Product productId = 0011AA"
            };

            CollectionAssert.AreEqual(expected, commands);
        }
    }
}
