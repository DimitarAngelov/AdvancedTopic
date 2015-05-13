using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RemoveNames
{
    static void Main()
    {
        string n = Console.ReadLine();
        string[] fn = n.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string NamesToRemove = Console.ReadLine();
        string[] remove = NamesToRemove.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> firstLine = fn.ToList<string>();
        List<string> secondLine = remove.ToList<string>();
        for (int i = 0; i < secondLine.Count; i++)
        {
            for (int j = 0; j < firstLine.Count; j++)
            {
                if (firstLine.Contains(secondLine[i]))
                {
                    firstLine.Remove(secondLine[i]);
                }
            }
        }
        foreach (var item in firstLine)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}