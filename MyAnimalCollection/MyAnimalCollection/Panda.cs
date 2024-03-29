using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnimalCollection;

public class Panda : Animal
{ 
    public Panda(string name) : base(name)
    {

    }
    public override void Say()
    {
        Console.WriteLine($"{Name} say pppppp");
    }

    public void PandaFeature()
    {
        Console.WriteLine("Pandalar gunun yarisini yemek yeyerek kecirir");
    }
}
