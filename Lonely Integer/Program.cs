class Result
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> a)
    {
        int lonelyInteger = 0;

        foreach (var item in a)
        {
            var isLonelyInteger = a.FindAll(x => x == item);
            if (isLonelyInteger.Count <= 1)
                lonelyInteger = item;
        }

        return lonelyInteger;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("C:\\Users\\caio_\\source\\repos\\HackerRank\\Lonely Integer\\output.txt", true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.lonelyinteger(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
