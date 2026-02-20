namespace February2026;

public class ByteCreator
{
  public string[] Create(string key)
  {
    var numbers = key.Split(' ').Select(int.Parse).ToArray();
    var result = new string[numbers.Length];
    for (var i = 0; i < numbers.Length; i++)
    {
      result[i] = Convert.ToString(numbers[i], 2);
    }
    return result;
  }
}