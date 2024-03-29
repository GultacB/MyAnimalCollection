using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnimalCollection;
public abstract class Animal
{ 
    public Animal(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public abstract void Say();

}
