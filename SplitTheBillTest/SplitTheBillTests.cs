namespace SplitTheBillTest;

using SplitTheBillClass;

[TestClass]
public class SplitTheBillTests
{
    [DataTestMethod]
    [DataRow(100, 10, 10)]
    [DataRow(120, 5, 24)]
    [DataRow(4, 2, 2)]
    public void Shuold_Return_Correct_Amount_When_Split(int currency, int people, int expected)
    {
        SplitTheBill split = new();
        decimal result = split.SplitBill((decimal)currency, (decimal)people);
        Assert.AreEqual(expected, result);
    }
}