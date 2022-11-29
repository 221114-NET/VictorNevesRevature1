namespace pokemonapp;
class Program
{
    static void Main(string[] args)
    {
        //Object Instantion
        Pokemon charmander = new Pokemon("charmander");

        //You can use dot notation to access fields and methods availible to an object of that class
        charmander.type = "fire";

        // This is how you call instance method. It "belongs to" the class
        charmander.isPokemon();

        // This is how you call a class/static method. It "belongs to" the class
        //Pokemon.Sound();
    }
}

class Pokemon 
{
    //Fields
    public string name;
    public string type;
    public int hitpoints;
    public int dexNumber;
    public int weight;
    public int level;

    //Constructor
    public Pokemon(string name){
        this.name = name;
    }
    public Pokemon(string pokename, string type, int hitpoints, int dexNumber, int weight, int level)
    {
        name = pokename;
        this.type = type;
        hitpoints = hp;
        dexNumber = dex;
        weight = wt;
        level = lvl;



    }
    //Methods
    public void isPokemon(){
        Console.WriteLine($"My name is {name}. I am a {type} type. I am a pokemon.");
    }
}

    //public static void Sound()
    //{
        //Console.WriteLine("*noises*");
    //}

