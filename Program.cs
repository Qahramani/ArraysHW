namespace ArraysHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Reversing Array
            int[] numbers = { 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                numbers[i] = numbers[i] + numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = numbers[i] - numbers[numbers.Length - 1 - i];
                numbers[i] = numbers[i] - numbers[numbers.Length - 1 - i];
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            #endregion
        }
    }
}
