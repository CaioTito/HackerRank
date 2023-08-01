using System.Collections.Generic;
using System.Linq;

class Result
{

    /*
     * Complete the 'getProductSuggestions' function below.
     *
     * The function is expected to return a 2D_STRING_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY products
     *  2. STRING search
     */

    public static List<List<string>> getProductSuggestions(List<string> products, string search)
    {
        List < List<string> > listaOutput = new List<List<string>>();
        List<string> lista1 = new List<string>();
        List<string> lista2 = new List<string>();
        List<string> lista3 = new List<string>();

        for (var i = 1; i <= 3; i++)
        {
            if(i == 1)
                lista1 = products.FindAll(x => x.Contains(search[i]));
                listaOutput.Add(lista1);
            if (i == 2)
                lista2 = products.FindAll(x => x.Contains(search[i]));
                listaOutput.Add(lista1);
            if (i == 3)
                lista3 = products.FindAll(x => x.Contains(search[i]));
                listaOutput.Add(lista1);
        }
        
        return listaOutput;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("C:\\Users\\caio_\\source\\repos\\HackerRank\\Avanade\\output.txt", true);

        int productsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> products = new List<string>();

        for (int i = 0; i < productsCount; i++)
        {
            string productsItem = Console.ReadLine();
            products.Add(productsItem);
        }

        string search = Console.ReadLine();

        List<List<string>> result = Result.getProductSuggestions(products, search);

        textWriter.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));

        textWriter.Flush();
        textWriter.Close();
    }
}
