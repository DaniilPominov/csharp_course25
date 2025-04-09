using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests;

[TestClass]
public class BooleanTest:BaseMathTest
{

    [TestMethod]
    public void TestMethod1()
    {
        int A = 1,B = 2, C = 3;
        var bob = new int[]{1,2,3};
        bob.Where((a)=> a==A);
        Assert.IsTrue(_math.CompareTriple(A,B,C));
    }
}
