using FluentAssertions;
using SQSV_lab2_14042024;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            float income = 13000000f;
            int depenQty = 1;
            float expectResult = 0f;

            // Execute
            float actualResult = TaxCalculate.Calculate(income, depenQty);

            // Assert
            actualResult.Should().BeApproximately(expectResult, 0.01f);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            float income = 18000000f;
            int depenQty = 1;
            float expectResult = 130000f;

            // Execute
            float actualResult = TaxCalculate.Calculate(income, depenQty);

            // Assert
            actualResult.Should().BeApproximately(expectResult, 0.01f);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            float income = 22000000f;
            int depenQty = 1;
            float expectResult = 410000f;

            // Execute
            float actualResult = TaxCalculate.Calculate(income, depenQty);

            // Assert
            actualResult.Should().BeApproximately(expectResult, 0.01f);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            float income = 26000000f;
            int depenQty = 1;
            float expectResult = 840000f;

            // Execute
            float actualResult = TaxCalculate.Calculate(income, depenQty);

            // Assert
            actualResult.Should().BeApproximately(expectResult, 0.2f);
        }

        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            float income = 35000000f;
            int depenQty = 1;
            float expectResult = 2270000f;

            // Execute
            float actualResult = TaxCalculate.Calculate(income, depenQty);

            // Assert
            actualResult.Should().BeApproximately(expectResult, 0.01f);
        }

        [TestMethod]
        public void TestMethod6()
        {
            // Arrange
            float income = 48000000f;
            int depenQty = 1;
            float expectResult = 4900000f;

            // Execute
            float actualResult = TaxCalculate.Calculate(income, depenQty);

            // Assert
            actualResult.Should().BeApproximately(expectResult, 0.01f);
        }

        [TestMethod]
        public void TestMethod7()
        {
            // Arrange
            float income = 48000000f;
            int depenQty = 1;
            float expectResult = 4900000f;

            // Execute
            float actualResult = TaxCalculate.Calculate(income, depenQty);

            // Assert
            actualResult.Should().BeApproximately(expectResult, 0.01f);
        }

        [TestMethod]
        public void TestMethod8()
        {
            // Arrange
            float income = 69000000f;
            int depenQty = 1;
            float expectResult = 10230000f;

            // Execute
            float actualResult = TaxCalculate.Calculate(income, depenQty);

            // Assert
            actualResult.Should().BeApproximately(expectResult, 1f);
        }

        [TestMethod]
        public void TestMethod9()
        {
            // Arrange
            float income = 98000000f;
            int depenQty = 1;
            float expectResult = 19060000f;

            // Execute
            float actualResult = TaxCalculate.Calculate(income, depenQty);

            // Assert
            actualResult.Should().BeApproximately(expectResult, 0.01f);
        }

        [TestMethod]
        public void TestMethod10()
        {
            // Arrange
            float income = 18000000f;
            int depenQty = 2;
            float expectResult = 0f;

            // Execute
            float actualResult = TaxCalculate.Calculate(income, depenQty);

            // Assert
            actualResult.Should().BeApproximately(expectResult, 0.01f);
        }

        [TestMethod]
        public void TestMethod11()
        {
            // Arrange
            float income = 98000000f;
            int depenQty = 5;
            float expectResult = 13650000f;

            // Execute
            float actualResult = TaxCalculate.Calculate(income, depenQty);

            // Assert
            actualResult.Should().BeApproximately(expectResult, 0.01f);
        }
    }
}