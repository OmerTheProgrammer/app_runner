using I_O = System.Console;

class Animal{
    public string name{
        get; set;
    }
    public double weight{
        get; set;
    }
    
    public Animal(){}
    
    public Animal(string name, double weight)
    {
        this.name = name;
        this.weight = weight;
    }

    public override string ToString(){
        return "your animal: " + this.name + " is weighing " + this.weight + "kg.";
    }
}

class Dog : Animal {
    public string hair_color{
        get; set;
    }
    
    public Dog(string name, double weight,string color)
    {
        this.name = name;
        this.weight = weight;
        this.hair_color = color;
    }
    
    public void bark(){
        I_O.WriteLine("woof woof");
    }
    
    public override string ToString(){
        return "your dog: " + this.name + " is weighing " + this.weight + "kg and his hair is "  + this.hair_color + '.';
    }
}

class Snake : Animal {
    public string body_color{
        get; set;
    }
    
    public Snake(string name, double weight,string color)
    {
        this.name = name;
        this.weight = weight;
        this.body_color = color;
    }
    
    public void heis(){
        I_O.WriteLine("ssss ssss");
    }
    
    public override string ToString(){
        return "your snake: " + this.name + " is weighing " + this.weight + "kg and his body color is "  + this.body_color + '.';
    }
}
class prasnter_class{
  public static void presenter() {
    Snake s = new Snake("bob",12.5,"black");
    Dog dogo = new Dog("dogo",8,"orange");
    I_O.WriteLine(dogo);
    dogo.bark();
    I_O.WriteLine(s);
    s.heis();
  }
}