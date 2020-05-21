
namespace PF_VS_PJ.Entities
{
    abstract class Contributors
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Contributors()
        {
        }
        public Contributors(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}
