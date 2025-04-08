
using Company.TestProject1;
using csharp_course;
using csharp_course.Exceptions;

namespace Tests;

[TestClass]
public sealed class Task1:BaseMathTest
{

    [TestMethod]
    public void Test1()
    {
        var a=2;
        var b=5;
        var trueRes1 = 10;
        var trueRes2 = 14;

        var res1 = _math.begin31(a,b);
        var res2 = _math.begin32(a,b);

        Assert.IsFalse(res1!=trueRes1);
        Assert.IsFalse(res2!=trueRes2);
    }
    [TestMethod]
    public void TestNegative(){
        var a=-2;
        var b=5;

        Assert.ThrowsException<NegativeNumberException>(()=>_math.begin31(a,b));
        Assert.ThrowsException<NegativeNumberException>(()=>_math.begin32(a,b));
    }
}