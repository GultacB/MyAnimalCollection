using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnimalCollection;

public class Owl:Animal
{
    public Owl(string name) : base(name)
    {

    }
    public override void Say()
    {
        Console.WriteLine($"{Name} say ooooooo");
    }
    public void OwlFeature()
    {
        Console.WriteLine("Bayquslarin 3 qat goz qabaqlari vardir");
    }
}
