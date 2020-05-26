using System;
using System.Text;

namespace part3
{
  class Sorting
  {
    public void MergeSort(int[] t) { }
    /* pseudo
        sort(a,b)
      if a == b
        return
      k = (a+b)/2
      sort(a,k)
      sort(k+1,b)
      merge(a,k,k+1,b)
      */

    /* pseudo
    merge(a1, b1, a2, b2)
    a = a1, b = b2
    for i = a to b
      if a2 > b2 or (a1 <= b1 and array[a1] <= array[a2])
        help[i] = array[a1]
        a1 += 1
      else
        help[i] = array[a2]
        a2 += 1
    for i = a to b
      array[i] = help[i]
      */

    public void QuickSort(int[] t) { }
    /* pseudo
    sort(a, b)
  if a >= b
    return
  k = pivot(a,b)
  sort(a, k-1)
  sort(k+1, b
  */

    /* pseudo
    pivot(a,b)
    k = a
    for i = a+1 to b
      if array[i] < array[a]
        k += 1
        swap(array[i], array[k])
    swap(array[a], array[k])
    return k
    */
  }
}