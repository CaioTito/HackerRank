class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int soma = 0;
        int subtracao = 0;
        int subtracaoContador = 0;
        int resultado = 0;

        for (var i = 0; i < arr.Count; i++)
        {
            var lista1 = arr[i];
            soma += lista1[i];
        }

        for (var i = arr.Count-1; i > -1; i--)
        {
            var lista1 = arr[i];
            subtracao += lista1[subtracaoContador];
            subtracaoContador++;
        }
        if(subtracao>soma)
             resultado = subtracao - soma ;
        else
            resultado = soma - subtracao;

        return resultado;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("C:\\Users\\caio_\\source\\repos\\HackerRank\\Diagonal Difference\\output.txt", true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
