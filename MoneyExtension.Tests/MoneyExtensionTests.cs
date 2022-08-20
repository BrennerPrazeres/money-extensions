namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void SholdConvertDecimaltoInt()
    {
        decimal valor = 279.98M;
        var cents = valor.Tocents();

        Assert.AreEqual(27998, cents);
    }
}