using _02.Structural_Pattern.Adapter.Version_02._01._Adaptee;
using _02.Structural_Pattern.Adapter.Version_02._02._Target;

namespace _02.Structural_Pattern.Adapter.Version_02._03._Adapter
{
    /// <summary>
    /// Ver2: Class Adapter (inheritance approach).
    /// </summary>
    public class Adapter_PrintBanner_InheritanceAdapter_Ver2 : Adapter_Banner, Adapter_IPrint_Ver2
    {
        public Adapter_PrintBanner_InheritanceAdapter_Ver2(string value)
            : base(value)
        {
        }

        public string PrintWeak()
        {
            return ShowWithParen();
        }

        public string PrintStrong()
        {
            return ShowWithAster();
        }
    }
}
