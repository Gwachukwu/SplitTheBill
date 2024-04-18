namespace SplitTheBillTest;

using SplitTheBillClass;

[TestClass]
public class TipPerPersonTests
{
    [DataTestMethod]
    [DataRow(1000, 10, 10, 10)]
    [DataRow(480, 12, 60, 24)]
    public void Shuold_Return_Correct_Amount_For_Each_Patron(int price, int patrons, int tipPercentage, int expected)
    {
        SplitTheBill calculator = new();
        decimal result = calculator.TipPerPerson((decimal)price, (decimal)patrons, (decimal)tipPercentage);
        Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void Should_Return_Correct_Decimal()
    {
        SplitTheBill calculator = new();
        decimal result = calculator.TipPerPerson(120, 5, 24);
        Assert.AreEqual(5.76m, result);
    }
}