using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calculat_age
{
  
        internal class AgeCalculator
        {
            private int currentYear;
            private int birthYear;

            // Constructor to initialize currentYear and birthYear
            public AgeCalculator(int currentYear, int birthYear)
            {
                this.currentYear = currentYear;
                this.birthYear = birthYear;
            }

            // Method to calculate age
            public int CalculateAge()
            {
                return currentYear - birthYear;
            }
        }
}
