namespace SplitTheBillClass;

public class SplitTheBill
{
    public decimal SplitBill(decimal currency, decimal people)
    {
        return currency / people;
    }
    public Dictionary<string, decimal> CalculateTips(Dictionary<string, decimal> data, float percent)
    {
        Dictionary<string, decimal> result = new();
        foreach (var item in data)
        {
            var amount = (float)item.Value * (percent / 100);
            result.Add(item.Key, (decimal)amount);
        }
        return result;
    }
    public decimal TipPerPerson(decimal price, decimal patrons, decimal tipPercentage)
    {
        decimal totalTip = price * (tipPercentage / 100);
        return totalTip / patrons;
    }
}
