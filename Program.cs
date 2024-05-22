namespace ArraysHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Reversing Array
            //int[] numbers = { 2, 3, 4, 5, 6, 7 };

            //for (int i = 0; i < numbers.Length / 2; i++)
            //{
            //    numbers[i] = numbers[i] + numbers[numbers.Length - 1 - i];
            //    numbers[numbers.Length - 1 - i] = numbers[i] - numbers[numbers.Length - 1 - i];
            //    numbers[i] = numbers[i] - numbers[numbers.Length - 1 - i];
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            #endregion
            #region MyRegion
            int[] array1 = { 1, 2, 8 };
            int[] array2 = { 4,3,2,5,1 };
            int counter = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                         counter++;
                }
            }
            if(counter == array1.Length)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            #endregion
        }
    }
}
