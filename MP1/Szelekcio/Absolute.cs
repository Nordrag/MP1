using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Absolute : BaseExcersize
{
    int num1, num2;


    public override void AskForData(out bool res)
    {
        Console.WriteLine("első szám");
        bool n1 = int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("második szám");
        bool n2 = int.TryParse(Console.ReadLine(), out num2);

        res = n1 && n2;
    }

    public override void PrintResult()
    {
        int abs1 = Math.Abs(num1);
        int abs2 = Math.Abs(num2);

        if (abs1 == abs2)
        {
            Console.WriteLine("egyenlőek");
            return;
        }
        Console.WriteLine(abs1 > abs2 ? $"az első nagyobb: {abs1}" : $"a második nagyobb: {abs2}");
    }
}

