namespace _03.Behavioral_Pattern.Strategy.Version_02._01._Strategy
{
    public interface Strategy_Scheduler
    {
        #region ?? Event Handle             ?

        #endregion // Event Handle

        #region ?? Properties               ?

        string Name { get; }

        #endregion // Properties

        #region ?? Method : Predicate       ?

        #endregion // Method : Predicate

        #region ?? Method : Event Handler   ?

        #endregion // Method : Event Handler

        #region ?? Method : Function        ?

        string GetNextCall();
        string SendCallToAgent();

        #endregion // Method : Function
    }
}
