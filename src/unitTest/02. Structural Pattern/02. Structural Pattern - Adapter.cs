using _02.Structural_Pattern.Adapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unitTest._02._Structural_Pattern
{
    public partial class _02_Structural_Pattern
    {
        [TestMethod("[Adapter Ver1 Uses Existing Abstract Target]")]
        public void Adapter_Ver1_Uses_Existing_Abstract_Target()
        {
            Adapter_Banner banner = new Adapter_Banner("Hello Adapter");
            Adapter_PrintBanner_Ver1 bannerAdapter = new Adapter_PrintBanner_Ver1(banner);

            Assert.AreEqual(banner.ShowWithParen(), bannerAdapter.PrintWeak());
            Assert.AreEqual(banner.ShowWithAster(), bannerAdapter.PrintStrong());
        }

        [TestMethod("[Adapter Ver2 Uses Inheritance Class Adapter]")]
        public void Adapter_Ver2_Uses_Inheritance_Class_Adapter()
        {
            Adapter_IPrint_Ver2 printer = new Adapter_PrintBanner_InheritanceAdapter_Ver2("Hello Adapter");

            Assert.AreEqual("(Hello Adapter)", printer.PrintWeak());
            Assert.AreEqual("*Hello Adapter*", printer.PrintStrong());
        }

        [TestMethod("[Adapter Ver3 Uses Composition Object Adapter]")]
        public void Adapter_Ver3_Uses_Composition_Object_Adapter()
        {
            Adapter_Banner banner = new Adapter_Banner("Hello Adapter");
            Adapter_IPrint_Ver2 printer = new Adapter_PrintBanner_CompositeAdapter_Ver3(banner);

            Assert.AreEqual("(Hello Adapter)", printer.PrintWeak());
            Assert.AreEqual("*Hello Adapter*", printer.PrintStrong());
        }

        [TestMethod("[Adapter Ver3 Throws On Null Adaptee]")]
        public void Adapter_Ver3_Throws_On_Null_Adaptee()
        {
            Assert.ThrowsException<System.ArgumentNullException>(
                () => new Adapter_PrintBanner_CompositeAdapter_Ver3(null));
        }
    }
}
