Console.WriteLine("Name your dog: ");
string myDogName = Console.ReadLine();
Dog mydog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good girl");

Console.WriteLine($"My dogs name is {mydog.Name}");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}");

mydog.Rename("Bad boy");

while (mydog.LevelOfHappiness != 5)
{
    mydog.Bark();
}

mydog.WagTail();

class Dog
{
    private string _name;
    private int _levelOfHappiness;

    //constructor

    public Dog(string name)
    {
        _name = name;
        _levelOfHappiness = 0;
    }
    //getter

    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"Your dog has been renamed to: {newName}");

    }

    public void Bark()
    {
        Console.WriteLine("Woof-Woof");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-Wiggle");
    }
}
