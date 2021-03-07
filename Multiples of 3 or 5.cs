public static class Kata
{
  public static int Solution(int val)
  {
    int result = 0;
    
    for(int i = 0; i < val; i++)
      {
      
        if (i % 3 == 0 || i % 5 == 0)
          {
            result += i;
          }
      }
    
    return result;
  }
}
