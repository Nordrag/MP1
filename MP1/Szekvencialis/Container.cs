using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Container
{
    float diameter, height, coverVolume;

    public void AskForData(out bool res)
    {
        Console.WriteLine("átmérő");
        bool dia = float.TryParse(Console.ReadLine(), out diameter);
        Console.WriteLine("magasság");
        bool h = float.TryParse(Console.ReadLine(), out height);
        Console.WriteLine("fedőképesség m2-ben");
        bool c = float.TryParse(Console.ReadLine(), out coverVolume);

        res = dia && h & c;
    }

    public int GetResult()
    {
        var radius = diameter / 2;
        var radiusSquared = radius * radius;

        var surface = 2 * radiusSquared * Math.PI + 2 * radius * height * Math.PI;
        var buckets = surface / coverVolume;
        return (int)Math.Ceiling(buckets);
    }
}

