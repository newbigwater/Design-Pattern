namespace _01.Creational_Pattern.Builder.Version_02
{
    public interface Builder_MakeReport_Ver2
    {
        void MakeHeader();
        void MakeBody();
        void MakeFooter();
        string GetReport();
    }
}
