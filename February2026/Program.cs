// See https://aka.ms/new-console-template for more information

// IV = opencastsoftware (16 characters)

namespace February2026
{
  internal class LBDEncryptionUtil
  {
    public string Decrypt(string encryptedText)
    {
      return "Not sure yet...";
    }
  }

  internal abstract class Program
  {
    private const string initialVector = "opencastsoftware";
    private string ciphertext =
      "noXUD0O8rDaNxis+D/vpJ1Vzn1EgI4f0XNlXj7MRjgGEIIOzoPd+RxjCTRahOpkMFOGshTNo5SoAIs849vyr1DR7uWrLt2GBq5bwnAfNlBO8uUX2eT0d7vpo9K3BcnlTshiv1iU2cwkWhEeGm8TQ7lKaae5s1zYMTzgOKLuaNvYnfyx+F3T346GT91q+07CbLjgfoUybkJbWWIxNggvmldUky5NskhWydOqwWma4uqlP6CO8rgZLVhr/bRPfsukd8WDg4NsVl7QhSNlty+pjLJ4HVlXoHKo6kEHJz8EmmoHqfjxXbVQKPmfdiNhNZ5558PA1f/iOhKHICEqFyXoFYScTVeB2eULLEU5bHkzgnxq35moHxWyTzX6c03ShGs9r9oqS2q803qSeG5wKg6EjKsixD03gcRWX1mJH/6sWsNwqNYMkq6cTXK5KYSlcDl82rHOgaFFNSdLiHrmzDE7dD6QZy5XHJP3UxXMFNZAGQCjoOUh1ybGMPyuUoUqUHMzLqkmG2UbwHTCk0pAwEDfS7tHKyW3GM7R8unL6ugX29/rEosTnaGSyl/PSQie1NXGMXk23kJ06azA4wJnRLrEyzqXEVUwhxFiGcRq4Kw835ZI93JLYdnZagGd63hqDvWElAH8QviLtqynnK1UrTVVmSjsDEcYD8bHuGynFBTfgcZtbaEOIYoN/ZMdv8jSkyxWk5q3lBidyOQ1CmWwwKbWLwXI7GKBtSOEGhs9usoCOtfzs3sQdzwRSTGMdt1mnUJdgr2fx+1ftC4A28OcaKdfoaxmXmfR6cKW5hKX6+50AvBn7RZWuUL96rU9twoYDyyi742qXzdOWZ9Q4/TuEHKXWmIHpSWkJ8hnLDJSuOGniT4TpqNtpzB0MzuCwfHdTAoDVJ8+iuXImCJ03ba9Yvfhi1ngCNuV06NCRxDoi9le07Eaq/HkAvjrjH0vXtBNgMC7t9lbOYm2rKcjgqYa1usB4yreIkOdWyY9nDO8aq98cV71DhGPLOS9XByWyysLfPXLFc0L8Ft91IFliw/4GGXTKLAUlzvodSvRUtUsxZ0Cf5OGugunexj8U8I0Eu0e1BopQQK447lbAOEyryPRAcE7eM35uXRMVz7tEvzSqnzty82npQ7m9kQTHZReZmHWh9v+SCzG9amS8hjxGhghT8LoaWQKFIcfOcwlEx0FwH5v92DEZyaYUXNzOJKLfEMgz697eERzrHOb/7A/EpaysKYptl1BZ+Lm9sM2GEgM/stAy05RJJPh1NKCfRCgRK4CTJEtYBHk4h9jKatUjQFNoudDhZ2eiGLlrjrS808MTLlWtHx4i1rfLLEinBgR0dTjMBTFV3gAc5L0PHJvjdOduTF5EZ+w39qMcxToJ46tJPM5/R6HZICdLJd+jgj4q1IG4Z4vM";

    private static void Main(string[] args)
    {
      Console.WriteLine("=== Learn By Doing February 2026 ===");

      Console.WriteLine("Please provide me with your super secret message:");
      const string keyInput =
        "2 4 6 9 5 2 3 1 2 4 5 4 4 8 2 2 3 1 3 2 2 6 14 2 0 4 13 9 4 11 6 4 10 6 2 2 5 7 0 1 4 1 6 1 0 3 1 0 5 6 3 6";
      var keys = BinaryConverter.Create(keyInput);
      //string? userInput = Console.ReadLine();
      // Print all keys
      foreach (var key in keys)
      {
        Console.Write(key + " ");
      }
    }
  }
}