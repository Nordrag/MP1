using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CarConsumption : BaseExcersize
{
    float consumption, distance, pricePerLiter;
    int roadTaxes;

    public override void AskForData(out bool res)
    {        
        Console.WriteLine("fogyasztás / 100km");
        var cons =  float.TryParse(Console.ReadLine(), out consumption); //try - catch
        Console.WriteLine("távolság (km)");
        var dist = float.TryParse(Console.ReadLine(), out distance);
        Console.WriteLine("ft / liter");
        var perliter = float.TryParse(Console.ReadLine(), out pricePerLiter);       
        Console.WriteLine("összes út díj");
        var taxes = int.TryParse(Console.ReadLine(), out roadTaxes);

        res = cons && dist && perliter && taxes;
    }
   
    public override void PrintResult()
    {
        var consumed = distance / consumption;
        var costOfConsuption = consumed * pricePerLiter;
        Console.WriteLine((float)Math.Round((costOfConsuption + roadTaxes), 2));
    }
}

