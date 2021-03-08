using System;
public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    string result = "";
    
    foreach(char x in text)
      {
        if (char.IsLetter(x))
          result += $"{Convert.ToString(Convert.ToInt32(char.ToLower(x)) - 96)} ";
      }
    
    return result.Trim();
  }
}
