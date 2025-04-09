using csharp_course;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests;

[TestClass]
public abstract class BaseMathTest
{
    private protected readonly math02 _math;
    public BaseMathTest(){
        _math = new();
    }

}
