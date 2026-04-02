namespace _02.Structural_Pattern.Adapter
{
    /// <summary>
    /// Target interface used by Adapter examples.
    /// Ver2 and Ver3 share this contract.
    /// </summary>
    public interface Adapter_IPrint_Ver2
    {
        string PrintWeak();
        string PrintStrong();
    }
}
