using System.Diagnostics;
using System.Xml.Linq;
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

        // We test that we cannot add two of the same bagels
        // (since we are storing the data in a dictionary)
        bool added2 = basket.add(name, price);
        Assert.That(added2, Is.False);
    }

    [TestCase("Cinnamon Bagel", 40)]
    public void Test2(string name, int price)
    {
        // We test that we can remove a bagel from the basket, to do this, we
        // must first add a bagel to the basket.
        Basket basket = new Basket();
        bool added = basket.add(name, price);
        bool removed = basket.remove(name);

        Assert.That(removed, Is.True);

        // Try and remove the bagel again, this should not work since it is already
        // removed
        bool removed2 = basket.remove(name);
        Assert.That(removed2, Is.False);
    }

    [Test]
    public void Test3()
    {
        Basket basket = new Basket();
        basket.add("Honey Bagel", 30);
        basket.add("Cinnamon Bagel", 40);

        // Now as a member of the public, I would like to know if the basket is full,
        // before I try to add another bagel
        bool result = basket.isFull();
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test4()
    {
        Basket basket = new Basket();
        // As the business manager, we do not need to add any bagels to the basket,
        // we just want to modify the basket capacity
        int newSize = 5;
        bool result = basket.changeCapacity(5);
    }
}