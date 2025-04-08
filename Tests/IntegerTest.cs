using csharp_course;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Company.TestProject1;

[TestClass]
public class IntegerTest:BaseMathTest
{
    [TestMethod]
    public void TestMethod1()
    {
        var i = 123;
        var sum = 6;
        var prod = 6;

        var res = _math.integer1(i);

        Assert.IsTrue(res.Item1==sum);
        Assert.IsTrue(res.Item2==prod);

    }
}
