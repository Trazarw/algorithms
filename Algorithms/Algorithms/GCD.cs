namespace AlgorithmsAndDataStructures.Algorithms
{
    public static class GCD
    {
        public static int GetGCF(int num, int[] arr)
        {
            int lastRemainder = arr[0];
            int i = 1;

            while (i < num - 1)
            {
                int currentRemainder;

                if (lastRemainder > arr[i])
                    currentRemainder = GetReminder(lastRemainder, arr[i]);
                else
                    currentRemainder = GetReminder(arr[i], lastRemainder);

                if (currentRemainder < 1)
                {
                    i += 1;
                    continue;
                }

                lastRemainder = currentRemainder;
                i += 1;
            }

            return lastRemainder;
        }

        private static int GetReminder(int a, int b)
        {
            if (a < 1) return b;
            if (b < 1) return a;
            return a - (b * (a / b));
        }
    }
}
