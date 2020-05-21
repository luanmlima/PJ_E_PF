using System;
using System.Collections.Generic;
using System.Text;

namespace PF_VS_PJ.Entities
{
    class LegalPerson : Contributors
    {
        public int NumberEmployees { get; set; }

        public LegalPerson()
        {
        }

        public LegalPerson(string name, double annualIncome, int numberEmployees)
            : base(name, annualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Tax()
        {
            double tax = 0;
            if (NumberEmployees <= 10)
            {
                tax = AnnualIncome * 0.16;
            }
            else
            {
                tax = AnnualIncome * 0.14;
            }
            return tax;
        }
    }
}
