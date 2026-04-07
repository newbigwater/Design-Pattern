using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdapterVer1Adaptee = _02.Structural_Pattern.Adapter.Version_01._01._Adaptee;
using AdapterVer1Adapter = _02.Structural_Pattern.Adapter.Version_01._03._Adapter;
using AdapterVer2Target = _02.Structural_Pattern.Adapter.Version_02._02._Target;
using AdapterVer2Adapter = _02.Structural_Pattern.Adapter.Version_02._03._Adapter;
using AdapterVer3Adaptee = _02.Structural_Pattern.Adapter.Version_03._01._Adaptee;
using AdapterVer3Target = _02.Structural_Pattern.Adapter.Version_03._02._Target;
using AdapterVer3Adapter = _02.Structural_Pattern.Adapter.Version_03._03._Adapter;

namespace unitTest._02._Structural_Pattern
{
    public partial class _02_Structural_Pattern
    {
        [TestMethod("[Adapter Ver1 Uses Existing Abstract Target]")]
        public void Adapter_Ver1_Uses_Existing_Abstract_Target()
        {
            AdapterVer1Adaptee.Adapter_Banner banner = new AdapterVer1Adaptee.Adapter_Banner("Hello Adapter");
            AdapterVer1Adapter.Adapter_PrintBanner_Ver1 bannerAdapter = new AdapterVer1Adapter.Adapter_PrintBanner_Ver1(banner);

            Assert.AreEqual(banner.ShowWithParen(), bannerAdapter.PrintWeak());
            Assert.AreEqual(banner.ShowWithAster(), bannerAdapter.PrintStrong());
        }

        [TestMethod("[Adapter Ver2 Uses Inheritance Class Adapter]")]
        public void Adapter_Ver2_Uses_Inheritance_Class_Adapter()
        {
            AdapterVer2Target.Adapter_IPrint_Ver2 printer = new AdapterVer2Adapter.Adapter_PrintBanner_InheritanceAdapter_Ver2("Hello Adapter");

            Assert.AreEqual("(Hello Adapter)", printer.PrintWeak());
            Assert.AreEqual("*Hello Adapter*", printer.PrintStrong());
        }

        [TestMethod("[Adapter Ver3 Uses Composition Object Adapter]")]
        public void Adapter_Ver3_Uses_Composition_Object_Adapter()
        {
            AdapterVer3Adaptee.Adapter_Banner banner = new AdapterVer3Adaptee.Adapter_Banner("Hello Adapter");
            AdapterVer3Target.Adapter_IPrint_Ver2 printer = new AdapterVer3Adapter.Adapter_PrintBanner_CompositeAdapter_Ver3(banner);

            Assert.AreEqual("(Hello Adapter)", printer.PrintWeak());
            Assert.AreEqual("*Hello Adapter*", printer.PrintStrong());
        }

        [TestMethod("[Adapter Ver3 Throws On Null Adaptee]")]
        public void Adapter_Ver3_Throws_On_Null_Adaptee()
        {
            Assert.ThrowsException<System.ArgumentNullException>(
                () => new AdapterVer3Adapter.Adapter_PrintBanner_CompositeAdapter_Ver3(null));
        }
    }
}
