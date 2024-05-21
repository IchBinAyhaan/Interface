
namespace Array
{
    internal static class ArrayExtension
    {
        public static double Average(this int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }

            return sum / array.Length;
        }
    }
    }

