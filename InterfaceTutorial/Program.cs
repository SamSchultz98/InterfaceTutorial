using InterfaceTutorial;

Boxer joe = new();
Parrot poly = new();
Frog bart = new();
//ISpeakable joe2 = new Boxer();          //Even though Joe2 is a boxer, since the interface does not have a color property, there is no color value for joe2


List<ISpeakable> pets = new() { joe, poly, bart };          //We make the interface to put all the data on the same list

foreach(ISpeakable pet in pets)
{
    pet.Speak();
    pet.Scream();
}


