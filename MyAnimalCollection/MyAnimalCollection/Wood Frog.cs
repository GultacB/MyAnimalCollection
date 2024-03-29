using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnimalCollection;

public class Wood_Frog:Animal
{
    public Wood_Frog(string name) : base(name)
    {

    }
    public override void Say()
    {
        Console.WriteLine($"{Name} say fffffff");
    }
    public void FrogFeature()
    {
        Console.WriteLine("Mese qurbagasi qis aylarinda ozlerini dondururlar yayda ise buzlarini acaraq yasamaga davam edirler");
    }
}
