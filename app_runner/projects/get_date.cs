using I_O = System.Console;
class get_date {
  public enum Days{
    Sunday = 1,
    Monday = 2,
    Tuesday = 3,
    Wednesday = 4,
    Thursday = 5,
    Friday = 6,
    Saturnday = 7
  }
  public enum Months{
    January = 1,
    February = 2,
    March = 3,
    April = 4,
    May = 5,
    June = 6,
    July = 7,
    August = 8,
    September = 9,
    October = 10,
    November = 11,
    December = 12
  }

  static void write_times_names(int size, string name){
    I_O.WriteLine($"pick a {name} by the number:");
    for(int i = 1; i<size;i++){
        if(name == "days"){
            I_O.WriteLine(i +" -> "+ (Days)i);
        }
        else if(name == "months"){
            I_O.WriteLine(i +" -> "+ (Months)i);
        }
        
    }
  }
  public static void date_presnater() {
    write_times_names(8,"days");
    int day = int.Parse(I_O.ReadLine());
    write_times_names(13,"months");
    int month = int.Parse(I_O.ReadLine());
    I_O.WriteLine("write a year:");
    int year = int.Parse(I_O.ReadLine());
    
    I_O.WriteLine("your event is on: " + (Days)day);
    I_O.WriteLine((Months)month + " of " + year);
  }
}