namespace Algorithms
{
    public class BubbleShort
    {
        public static int[] Short(int[] array)
        {
            int swaps;

            do
            {
                swaps = 0;
                for (int i = 0; i <= array.Length; i++)
                {
                    if (i + 1 <= array.Length -1 && array[i] > array[i + 1])
                    {
                        int current = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = current;
                        swaps = swaps + 1;
                    }
                }
            }
            while (swaps > 0);  

            return array;
        }
    }
}