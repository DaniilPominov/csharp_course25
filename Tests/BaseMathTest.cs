using csharp_course;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Company.TestProject1;

[TestClass]
public abstract class BaseMathTest
{
    private protected readonly math02 _math;
    public BaseMathTest(){
        _math = new();
    }

}
