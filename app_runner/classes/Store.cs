using I_O = System.Console;

class Store{
    double area = 0.0;
    double income = 0.0;
    double spendings = 0.0;
    
    public string name{ get; set;}
    public string city{ get; set; }
    public double Area{
        get {return this.area;}
        set { if(value > 0){ this.area = value; } }
    }
    public double Income{
        get {return this.income;}
        set { if(value > 0){ this.income = value; } }
    }
        public double Spendings{
        get {return this.spendings;}
        set { if(value > 0){ this.spendings = value; } }
    }
    
    public Store(string name,string city ,double area, double income,double spendings)
    {
        this.name = name;
        this.city = city;
        this.Area = area;
        this.Income = income;
        this.Spendings = spendings;
    }
    public Store(string name,string city ,double area)
    {
        this.name = name;
        this.city = city;
        this.Area = area ;
        this.income = -1;
        this.spendings = -1;
    }
    

    public override string ToString(){
        if(this.income+this.spendings == -2){
            return "the store " + this.name + " is in " + this.city + " and it is " + this.Area +
            "m^2 in land area and it doesn't earn or lose money yet.";
        }
        else {
        return "the store " + this.name + " is in " + this.city + " and it is " + this.Area +
        "m^2 in land area and it earns " + this.Income + "$ and loses " + this.Spendings + '$';
        }
    }
    
    public void chack_balance(){
        if(this.Income-this.Spendings>1000){
            I_O.WriteLine("Keep that way");
        }
        else{
            I_O.WriteLine("You must find how to save money");
        }
    }
}

class store_presenter{
  public static void presenter() {
     I_O.WriteLine("enter: name,what city is in?,land area,earnings, spendings");
     Store s = new Store(I_O.ReadLine(),I_O.ReadLine(),double.Parse(I_O.ReadLine()),
     double.Parse(I_O.ReadLine()),double.Parse(I_O.ReadLine()));
     s.chack_balance();
     
    I_O.WriteLine("enter: name,what city is in?,land area");
     Store s_1 = new Store(I_O.ReadLine(),I_O.ReadLine(),double.Parse(I_O.ReadLine()));
     I_O.WriteLine(s_1);
     
  }
}