using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class BasketTests
{

    [TestCase("Honey Bagel", 30)]
    public void Test1(string name, int price)
    {
        // We test that we are able to add the bagel to the basket
        Basket basket = new Basket();
        bool added = basket.add(name, price);
        Assert.That(added, Is.True);
    }
}