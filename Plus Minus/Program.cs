using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double positivo = 0;
        double zero = 0;
        double negativo = 0;

        foreach (var numero in arr)
        {
            if (numero >= 1)
            {
                positivo++;
            }
            if (numero <= -1)
            {
                negativo++;
            }
            if (numero == 0)
            {
                zero++;
            }
        }

        double resultadoPositivo = positivo / arr.Count;
        double resultadoNegativo = negativo / arr.Count;
        double resultadoZero = zero / arr.Count;

        Console.WriteLine(resultadoPositivo.ToString("F5"));
        Console.WriteLine(resultadoNegativo.ToString("F5"));
        Console.WriteLine(resultadoZero.ToString("F5"));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
