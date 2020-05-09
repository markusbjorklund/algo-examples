namespace part1
{
  public class Tables
  {
    public int Calculate(int[] t)
    {

      /*

if t.Length == 1
return value of the only thing in t
else
create new array, int[t.Length-1]
for each in the original array
do the calculations, do not overflow
return Calculate(new array)*/

// solution from example during class

      if (t.Length == 1)
      {
        return t[0];
      }

      else
      {
        int[] newArray = new int[t.Length - 1];
        for (int i = 0; i < t.Length - 1; i++)
        {
          newArray[i] = t[i] + t[i + 1];
        }
        return Calculate(newArray);
      }
    }
  }
}