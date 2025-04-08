
using csharp_course;
using csharp_course.Exceptions;

namespace Tests;

[TestClass]
public sealed class Task1
{
    private readonly math02 _begin;

    public Task1(){
        _begin = new();
    }
    [TestMethod]
    public void Test1()
    {
        var a=2;
        var b=5;
        var trueRes1 = 10;
        var trueRes2 = 14;

        var res1 = _begin.begin31(a,b);
        var res2 = _begin.begin32(a,b);

        Assert.IsFalse(res1!=trueRes1);
        Assert.IsFalse(res2!=trueRes2);
    }
    [TestMethod]
    public void TestNegative(){
        var a=-2;
        var b=5;

        Assert.ThrowsException<NegativeNumberException>(()=>_begin.begin31(a,b));
        Assert.ThrowsException<NegativeNumberException>(()=>_begin.begin32(a,b));
    }
}