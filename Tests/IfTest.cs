using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests;

[TestClass]
public class IfTest:BaseMathTest
{

    [TestMethod]
    [DynamicData("generateTriple",DynamicDataSourceType.Method)]
    public void TestIf(List<double> numbers)
    {
        (double A, double B, double C) = (numbers[0],numbers[1],numbers[2]);
        Assert.AreEqual(_math.MinimalFromTriple(A,B,C),A);
    }
    private static IEnumerable<object[]>  generateTriple(){
        var random = new Random();
        var rand = random.NextDouble();
        yield return new object[]{new List<double>(){rand,rand+1,rand+2}};
    }
}
