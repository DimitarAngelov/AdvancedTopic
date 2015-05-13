using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] mas = new int[n];
        for(int i=0; i<mas.Length; i++)
        {
            mas[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(mas);
        foreach (int value in mas)
        {
            Console.WriteLine(value);
        }
    }
}

