namespace _01.Creational_Pattern.Builder.Version_01
{
    public interface Builder_MakeReport_Ver1
    {
        void MakeHeader();
        void MakeBody();
        void MakeFooter();
        string GetReport();
    }
}
