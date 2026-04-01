using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01.Creational_Pattern.Singleton;

namespace unitTest._01._Creational_Pattern
{
    partial class _01_Creational_Pattern
    {
        [TestMethod("[Singleton Ver1 Returns Same Instance]")]
        public void Singleton_Ver1_Returns_Same_Instance()
        {
            Singleton_ConnectionPool_Ver1 pool1 = Singleton_ConnectionPool_Ver1.Instance;
            Singleton_ConnectionPool_Ver1 pool2 = Singleton_ConnectionPool_Ver1.Instance;

            Assert.AreSame(pool1, pool2);
        }

        [TestMethod("[Singleton Ver2 Returns Same Instance]")]
        public void Singleton_Ver2_Returns_Same_Instance()
        {
            Singleton_ConnectionPool_Ver2 pool1 = Singleton_ConnectionPool_Ver2.Instance;
            Singleton_ConnectionPool_Ver2 pool2 = Singleton_ConnectionPool_Ver2.Instance;

            Assert.AreSame(pool1, pool2);
        }

        [TestMethod("[Singleton Ver3 Returns Same Instance]")]
        public void Singleton_Ver3_Returns_Same_Instance()
        {
            Singleton_ConnectionPool_Ver3 pool1 = Singleton_ConnectionPool_Ver3.Instance;
            Singleton_ConnectionPool_Ver3 pool2 = Singleton_ConnectionPool_Ver3.Instance;

            Assert.AreSame(pool1, pool2);
        }

        [TestMethod("[Singleton Ver3 Keeps CreatedAt]")]
        public void Singleton_Ver3_Keeps_CreatedAt_Value()
        {
            Singleton_ConnectionPool_Ver3 pool1 = Singleton_ConnectionPool_Ver3.Instance;
            Singleton_ConnectionPool_Ver3 pool2 = Singleton_ConnectionPool_Ver3.Instance;

            Assert.AreEqual(pool1.CreatedAt, pool2.CreatedAt);
        }

        [TestMethod("[Singleton Ver3 Returns Connection Message]")]
        public void Singleton_Ver3_Returns_Connection_Message()
        {
            Singleton_ConnectionPool_Ver3 pool = Singleton_ConnectionPool_Ver3.Instance;
            string connection = pool.GetConnection();

            Assert.IsFalse(string.IsNullOrWhiteSpace(connection));
            StringAssert.Contains(connection, "Connection created at");
        }

        [TestMethod("[Singleton Ver3 Uses Same Connection Message]")]
        public void Singleton_Ver3_Uses_Same_Connection_Message()
        {
            Singleton_ConnectionPool_Ver3 pool1 = Singleton_ConnectionPool_Ver3.Instance;
            Singleton_ConnectionPool_Ver3 pool2 = Singleton_ConnectionPool_Ver3.Instance;

            Assert.AreEqual(pool1.GetConnection(), pool2.GetConnection());
        }
    }
}
