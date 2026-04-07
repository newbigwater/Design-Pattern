using System;
using _01.Creational_Pattern.AbstractFactory.Version_03._02._DAO;

namespace _01.Creational_Pattern.AbstractFactory.Version_03._04._Factory
{
    public abstract class AbstractFactory_DAO_Factory
    {
        public static AbstractFactory_DAO_Factory CreateFactory(string databaseType)
        {
            if (string.IsNullOrWhiteSpace(databaseType))
            {
                throw new ArgumentNullException(nameof(databaseType));
            }

            switch (databaseType.Trim().ToLowerInvariant())
            {
                case "mysql":
                    return new AbstractFactory_DAO_MySQL_Factory();
                case "oracle":
                    return new AbstractFactory_DAO_Oracle_Factory();
                default:
                    throw new ArgumentException($"Unsupported database type: {databaseType}", nameof(databaseType));
            }
        }

        public abstract AbstractFactory_DAO_UserInfo CreateUserInfoDao();
        public abstract AbstractFactory_DAO_Product CreateProductDao();
    }
}
