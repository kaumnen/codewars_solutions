  using System;
  public class Sum
  {
     public int GetSum(int a, int b)
     {
       int[] orderedInput = new int[] {a, b};
       Array.Sort(orderedInput);
       
       int result = 0;
       
       for (int i = orderedInput[0]; i <= orderedInput[1]; i++)
         {
           result += i;
         }
       
       return result;
     }
  }
