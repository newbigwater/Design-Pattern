namespace _01.Creational_Pattern.Builder.Version_03
{
    public interface Builder_MakeReport_Ver3
    {
        void MakeHeader();
        void MakeBody();
        void MakeFooter();
        string GetReport();
    }
}
