namespace Kunoichi.Algorithms.Sorting.ComparisonBased
{
// Bubble Sort
  public class BubbleSort
  {
      public static void BubbleSort(int[] inputs)
      {
        if (inputs == null) return;

        bool sorted;
        int size = inputs.Length;

       do
       {
         sorted = true;
         for(int i= 1; i < size; i++)
         {
           if(inputs[i-1] > inputs[i])
           {
             Swap(inputs, i-1, i);
             sorted = false;
           }
         }
       }
        while(!sorted)
       }

      public void Swap(int[] inputs, int i, int j)
      {
          int temp = inputs[i];
          inputs[i] = inputs[j];
          inputs[j] = temp;
      }
    }
}
