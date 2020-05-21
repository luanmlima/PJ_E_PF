

namespace PF_VS_PJ.Entities
{

    class PhysicalPerson : Contributors
    {
        public double HealthSpending { get; set; }

        public PhysicalPerson()
        {
        }

        public PhysicalPerson(string name, double annualIncome, double healthSpending)
            : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double Tax()
        {
            double tax = 0;
            if (AnnualIncome <= 20000.00)
            {
                tax = AnnualIncome * 0.15 ;
            }
            else
            {
                tax = AnnualIncome * 0.25;
            }
            if (HealthSpending != 0)
            {
                tax -=  HealthSpending * 0.50;
            }
            return tax;
        }
    }
}
