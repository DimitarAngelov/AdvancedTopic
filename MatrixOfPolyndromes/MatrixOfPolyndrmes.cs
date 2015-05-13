using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfPolidromes
{
    static void Main()
    {
        int Row = int.Parse(Console.ReadLine());
        int Col = int.Parse(Console.ReadLine());
        string[,] Matrix = new string[Row, Col];
        for (int row = 0; row < Row; row++)
        {
            for (int col = 0; col < Col; col++)
            {
                Matrix[row, col] = "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);
            }
        }
        for (int row = 0; row < Row; row++)
        {
            for (int col = 0; col < Col; col++)
            {
                Console.Write(Matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
