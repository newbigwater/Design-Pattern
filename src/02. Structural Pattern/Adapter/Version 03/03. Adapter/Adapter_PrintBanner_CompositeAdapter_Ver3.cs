using System;
using _02.Structural_Pattern.Adapter.Version_03._01._Adaptee;
using _02.Structural_Pattern.Adapter.Version_03._02._Target;

namespace _02.Structural_Pattern.Adapter.Version_03._03._Adapter
{
    /// <summary>
    /// Ver3: Object Adapter (composition approach).
    /// </summary>
    public class Adapter_PrintBanner_CompositeAdapter_Ver3 : Adapter_IPrint_Ver2
    {
        private readonly Adapter_Banner _banner;

        public Adapter_PrintBanner_CompositeAdapter_Ver3(Adapter_Banner banner)
        {
            _banner = banner ?? throw new ArgumentNullException(nameof(banner));
        }

        public string PrintWeak()
        {
            return _banner.ShowWithParen();
        }

        public string PrintStrong()
        {
            return _banner.ShowWithAster();
        }
    }
}
