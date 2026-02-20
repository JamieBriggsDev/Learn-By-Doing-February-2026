using February2026;

namespace TestProject;

public class ByteCreatorTests
{
  /*[SetUp]
  public void Setup()
  {
  }
  */
  
  
  [Test]
  public void TestConvertingOne()
  {
    ByteCreator byteCreator = new ByteCreator();
    var result = byteCreator.Create("1");
    Assert.That(result, Is.Not.Null);
    Assert.That(result[0], Is.EqualTo("1"));
  }
  
  [Test]
  public void TestConvertingTen()
  {
    ByteCreator byteCreator = new ByteCreator();
    var result = byteCreator.Create("10");
    Assert.That(result, Is.Not.Null);
    Assert.That(result[0], Is.EqualTo("1010"));
  }
}