class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        arr.Sort();

        double somaMaximo = 0;
        double somaMinimo = 0;

        for (int i = 0; i < arr.Count - 1; i++)
        {
            somaMinimo += arr[i];
        }

        for (int i = 1; i < arr.Count; i++)
        {
            somaMaximo += arr[i];
        }

        Console.WriteLine($"{somaMinimo} {somaMaximo}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
