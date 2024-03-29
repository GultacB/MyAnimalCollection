using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnimalCollection;

public class Cow:Animal
{
    public Cow(string name) : base(name)
    {

    }
    public override void Say()
    {
        Console.WriteLine($"{Name} say ccccccccc");
    }
    public void CowFeature()
    {
        Console.WriteLine("Ineyler yuxu gorurler");
    }
}
