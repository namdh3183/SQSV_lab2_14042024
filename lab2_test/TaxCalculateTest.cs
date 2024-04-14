using FluentAssertions;
using SQSV_lab2_14042024;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab2_test
{
    public class TaxCalculateTest
    {
        public void TaxCalTest()
        {
            // Arrange
            float income = 18000000f;
            int depenQty = 1;
            float expectResult = 130000;

            // Execute
            float actualResult = TaxCalculate.Calculate(income, depenQty);

            // Assert
            actualResult.Should().BeApproximately(expectResult, 0.001f);
        }
    }
}
