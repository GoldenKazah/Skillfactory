namespace действиесмассивом
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа массива через пробел");
            string array = Console.ReadLine();
            int[] NewArray(string arr)
            {
                string temp = "";
                int[] nums = new int[arr.Length];
                int k = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != ' ')
                    { temp = temp + arr[i]; }
                    else
                    {
                        nums[k] = int.Parse(temp);
                        temp = "";
                        k++;
                    }
                    if (i == arr.Length - 1)
                    {
                        nums[k] = int.Parse(temp);
                        k++;
                    }
                }
                nums[k] = int.Parse(temp);
                int[] result = new int[k];
                for (int j = 0; j < k; j++)
                {
                    result[j] = nums[j];
                }
                return result;
            }
            int[] result = NewArray(array);
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < result.Length; i++)
            { Console.Write($"{result[i]}\t"); }
            int[] SortArray(int[] commonarray)
            {
                for (int i = 0; i < commonarray.Length; i++)
                {
                    for (int j = 0; j < commonarray.Length; j++)
                    {
                        if (commonarray[i] < commonarray[j])
                        {
                            int temp = commonarray[i];
                            commonarray[i] = commonarray[j];
                            commonarray[j] = temp;
                        }
                    }
                }
                return commonarray;
            }
            int[] sortedarray=SortArray(result);
            Console.WriteLine("\nСортированный массив");
            for (int i = 0;i < sortedarray.Length;i++) 
            { Console.Write($"{sortedarray[i]}\t"); }
        }
    }
}


