namespace February2026;

public abstract class BinaryConverter
{
  public class BinaryObject
  {
    public string Binary { get; private set; }

    public byte[] Bytes()
    {
      // TODO: Handle zeros at beginning of binary
      int numberOfBytes = Binary.Length / 8;
      byte[] bytes = new byte[numberOfBytes];
      for (int i = 0; i < numberOfBytes; i++)
      {
        bytes[i] = Convert.ToByte(Binary.Substring(8 * i, 8), 2);
      }
      return bytes;
    }

    public BinaryObject(string binary)
    {
      Binary = binary;
    }
  }

  public static BinaryObject[] Create(string key)
  {
    var numbers = key.Split(' ').Select(int.Parse).ToArray();
    var result = new BinaryObject[numbers.Length];
    for (var i = 0; i < numbers.Length; i++)
    {
      var binary = Convert.ToString(numbers[i], 2);
      result[i] = new BinaryObject(binary);
    }

    return result;
  }
}