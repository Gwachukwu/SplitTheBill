namespace SplitTheBillTest;

using SplitTheBillClass;

[TestClass]
public class CalculateTipsTest
{
    [DataTestMethod]
    [DataRow(100.0, 10.0, 10.0, DisplayName = "Standard 10% Tip")]
    [DataRow(123.45, 12.5, 15.43, DisplayName = "Decimal Percent Tip")]
    public void CalculateTips_SingleInput_CorrectCalculation(double mealCost, double tipPercentage, double expectedTip)
    {
        var mealCosts = new Dictionary<string, decimal> { { "Gwachukwu", (decimal)mealCost } };
        var calculator = new SplitTheBill();

        var result = calculator.CalculateTips(mealCosts, (float)tipPercentage);

        Assert.AreEqual((decimal)expectedTip, result["Gwachukwu"], 0.01m, "Tip calculation mismatch.");
    }
    [TestMethod]
    public void CalculateTips_MultipleEntries_CorrectCalculation()
    {
        var mealCosts = new Dictionary<string, decimal>
            {
                { "Alice", 100m },
                { "Bob", 200m }
            };
        float tipPercentage = 10.0f;

        var expectedTips = new Dictionary<string, decimal>
            {
                { "Alice", 10m },
                { "Bob", 20m }
            };

        var calculator = new SplitTheBill();
        var result = calculator.CalculateTips(mealCosts, tipPercentage);

        CollectionAssert.AreEqual(expectedTips, result);
    }
}