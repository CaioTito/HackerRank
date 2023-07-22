using static System.Runtime.InteropServices.JavaScript.JSType;

class Result
{
    public static string stringInverter(string str)
    {
        int length = str.Length;
        char[] characters = new char[length];

        for (int i = 0; i < length; i++)
        {
            characters[i] = str[length - 1 - i];
        }

        return new string(characters);
    }

    /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */
    public static long flippingBits(long n)
    {
        int exp = 0;
        long output = 0;
        string binary = stringInverter(Convert.ToString(~n, 2).PadLeft(sizeof(int) * 8, '0'));

        for (int i = 0 ; i < 32; i++)
        {
            int number = Convert.ToInt32(binary.Substring(i, 1));
            output += number * (long)Math.Pow(2, exp);
            exp++;
        }

        return output;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("C:\\Users\\caio_\\source\\repos\\HackerRank\\Flipping Bits\\output.txt", true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
