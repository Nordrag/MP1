using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Density : BaseExcersize
{
    float mass, volume;
    const int limit = 997;
    string? objName;

    public override void AskForData(out bool res)
    {
        Console.WriteLine("test neve");
        objName = Console.ReadLine();
        Console.WriteLine("tömeg kg-ban (float / int)");
        bool m = float.TryParse(Console.ReadLine(), out mass);
        Console.WriteLine("térfogat m3 (float / int)");
        bool v = float.TryParse(Console.ReadLine(), out volume);

        res = m & v;
    }

    public override void PrintResult()
    {
        var density = mass / volume;

        //nem teljesen értem de gondolom ha a feladatban megadott 997 alatt van a sűrűség akkor úszik a vízen
        Console.WriteLine(density <= limit? objName + " úszik a vízen" : objName + " nem úszik a vízen");
    }
}

