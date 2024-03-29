using MyAnimalCollection;
List<Animal> animals = new List<Animal>();
Animal panda = new Panda("Panda");
Animal frog = new Wood_Frog("Frog");
Animal cow = new Cow("Cow");
Animal owl = new Owl("Owl");
animals.Add(panda);                 
animals.Add(cow);
animals.Add(owl);
animals.Add(frog);

foreach (var animal in animals)
{
    animal.Say();
    if(animal is Panda)
    {
        ((Panda)(panda)).PandaFeature();
    }
    else if(animal is Cow)
    {
        ((Cow)(cow)).CowFeature();

    }
    else if(animal is Owl)
    {
        ((Owl)(owl)).OwlFeature();
    }
    else
    {
        ((Wood_Frog)(frog)).FrogFeature();
    }
    
}