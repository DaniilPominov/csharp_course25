using csharp_course;
using NUnit.Framework;
using System;
namespace KataTests;

public class KataTests
{


  [TestFixture]
  public class Sample_Test
  {
    [Test, Description("Sample Tests")]
    public void Test()
    {
      Assert.That(Kata.UInt32ToIP(2154959208), Is.EqualTo("128.114.17.104"));
      Assert.That(Kata.UInt32ToIP(0), Is.EqualTo("0.0.0.0"));
      Assert.That(Kata.UInt32ToIP(2149583361), Is.EqualTo("128.32.10.1"));
    }
  }
}
