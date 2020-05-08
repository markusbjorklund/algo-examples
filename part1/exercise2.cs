namespace part1
{
  public class Substrings
  {
    public int Calculate(string a, string b)
    {
      int match = 0;

      for (int i = 0; i <= a.Length - b.Length; i++)
      {

        int j;
        for (j = 0; j < b.Length; j++)
        {
          if (a[i + j] != b[j])
          {
            break;
          }
        }

        if (j == b.Length)
        {
          match++;
          j = 0;
        }
      }
      return match;
    }
  }
}