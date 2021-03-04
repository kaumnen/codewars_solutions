using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
    string result = "";
    
    foreach (char s in Convert.ToString(n))
    {
      result += Convert.ToString((Convert.ToInt32(s) - 48) * (Convert.ToInt32(s) - 48));
    }
    
    return Convert.ToInt32(result);
  }
}
