namespace examprep
{
  public class Numbers
  {
    public int Steps(int x)
    {
      int sum = 0;
      int counter = 0;
      for (int i = 1; sum < x; i++)
      {
        sum += i;
        counter++;
      }
      return counter;
    }
  }
}