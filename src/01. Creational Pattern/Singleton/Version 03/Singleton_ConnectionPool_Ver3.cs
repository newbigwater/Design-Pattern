using System;

namespace _01.Creational_Pattern.Singleton.Version_03
{
    /// <summary>
    /// Final singleton example using Lazy<T> and sealed.
    /// </summary>
    public sealed class Singleton_ConnectionPool_Ver3
    {
        #region ?? Event Handle             ?

        #endregion // Event Handle

        #region ?? Fields                   ?

        private static readonly Lazy<Singleton_ConnectionPool_Ver3> _instance =
            new Lazy<Singleton_ConnectionPool_Ver3>(() => new Singleton_ConnectionPool_Ver3());

        private readonly DateTime _createdAt;

        #endregion // Fields

        #region ?? Properties               ?

        public static Singleton_ConnectionPool_Ver3 Instance => _instance.Value;
        public DateTime CreatedAt => _createdAt;

        #endregion // Properties

        ////////////////////////////////////////

        #region ?? Constructor              ?

        private Singleton_ConnectionPool_Ver3()
        {
            _createdAt = DateTime.UtcNow;
        }

        #endregion // Constructor

        ////////////////////////////////////////

        #region ?? Override                 ?

        #region ?? Override : Predicate     ?

        #endregion // Override : Predicate

        #region ?? Override : Event Handler ?

        #endregion // Override : Event Handler

        #region ?? Override : Function      ?

        #endregion // Override : Function

        #endregion // Override

        ////////////////////////////////////////

        #region ?? Method                   ?

        #region ?? Method : Predicate       ?

        #endregion // Method : Predicate

        #region ?? Method : Event Handler   ?

        #endregion // Method : Event Handler

        #region ?? Method : Function        ?

        public string GetConnection()
        {
            return $"Connection created at {_createdAt:O}";
        }

        #endregion // Method : Function

        #endregion // Method
    }
}
