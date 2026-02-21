using February2026;

namespace TestProject;

public class BinaryConverterTests
{
  
  [Test]
  public void ShouldConvertSingleDigitNumber()
  {
    var result = BinaryConverter.Create("1");
    Assert.That(result, Is.Not.Null);
    Assert.That(result[0].Binary, Is.EqualTo("1"));
  }
  
  [Test]
  public void ShouldConvertMultipleDigitNumbers()
  {
    var result = BinaryConverter.Create("10");
    Assert.That(result, Is.Not.Null);
    Assert.That(result[0].Binary, Is.EqualTo("1010"));
  }

  [Test]
  public void ShouldConvertMultipleNumbers()
  {
    var result = BinaryConverter.Create("1 10");
    Assert.That(result, Is.Not.Null);
    Assert.That(result[0].Binary, Is.EqualTo("1"));
    Assert.That(result[1].Binary,  Is.EqualTo("1010"));
  }
}