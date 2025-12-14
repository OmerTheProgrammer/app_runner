using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


class Student{
    public static Comparer<Student> studentComparer = Comparer<Student>.Create((first, second) => first.Time.CompareTo(second.Time));
    public int score{
        get; set;
    }
    //get ל2 השדות
    public string name{
        get; set;
    }
    
    private DateTime time;
    public DateTime Time {
        get {
            return this.time;
        }
        set {
            this.time = new DateTime(1, 1, 1, value.Hour, value.Minute, value.Second, value.Millisecond);
        }
    }
    
    public Student previous{
        get; set;
    }   
    public Student next{
        get; set;
    }
    
    public string str_time() {
        return string.Format("{0} hours : {1} minutes : {2}.{3} seconds", 
        this.time.Hour, this.time.Minute, this.time.Second, this.time.Millisecond);
    }
    
    //בנאי
    public Student(string name, DateTime time){
        this.name = name;
        this.Time = time;
        this.score = 0;
        
        this.previous = null;
        this.next = null;
    }
    
    public Student(Student s){
        this.name = s.name;
        this.Time = s.time;
        this.score = s.score;
        
        this.previous = s.previous;
        this.next = s.next;
    }
    
    public Student faster(Student s) {
        if (this.time < s.time){
            return this;
        }
        if(s.time < this.time){
            return s;
        }
        return this;
    }
    
    //הצגת נתוני תלמיד
    public override string ToString(){
        return "the student " + this.name + " had played " + this.str_time() + " and got score of " + this.score;
    }
}

class Sports_facility{
    public Student head { get; set; }
    public Student tail { get; set; }
    public Sports_facility previous{ get; set; }   
    public Sports_facility next{ get; set; }
    public Student[] students{
        get; set;
    }
    
    public string name{
        get; set;
    }
    
    private double[] pos;
    public double[] Pos{
        get {
            return this.pos;
        }
        set {
            this.pos = new double[2];
            if( value[0] <= 4 && value[1] <= 3){
                this.pos = value;
            }
        }
    }
    
    public bool is_students_empty(){
        if (this.students == null){ return true; }
        foreach(Student s in this.students){
            if(s == null){
                return true;
            }
            else{
                return false;
            }
        }
        return false;
    }
    
    public string str_students() {
        //בודק שרשימת הסטודנטים מלאה
        if(this.is_students_empty()){ return "no one"; }
        if(this.name == "" && (this.pos[0] == 0 || this.pos[1] == 0) && this.students.Length == 3){
            return "[ \nthe first: " + this.students[0] + "\nthe second: " + this.students[1] +
            "\n the last: " + this.students[2] + "\n ]";
        }
        
        string str = "[ \n";
        foreach(Student student in this.students){
            if (student == null){
                break;
            }
            str += student.ToString() + ",\n";
        }
        str += " ]";
        
        return str;
    }
    
    public void add_student(Student s){
        if(this.is_students_empty()){
            s.previous = null;
            s.next = s.previous;
            this.students[0] = s;
            this.head = s;
            this.tail = s;
            return;
        }
        for(int i = 0; i < this.students.Length; i++){
            if (this.students[i] == null){
                s.previous = this.tail;
                this.students[i] = s;
                if(this.students.Length-1 == i){
                    s.next = null;
                }
                this.tail.next = s;
                this.tail = s;
                break;
            }
        }
    }
    
    public Student fastest_student(){
        //בודק אם המערך ריק, או באורך 0
        if (this.students == null || this.students.Length == 0) {
            return null;
        }
        //הכי קטן שאפשר
        Student fastest = null;
        //רץ על כל המערך
        for(int i = 0; i < this.students.Length; i++){
            /*
            this.students[i] != null -> מוודא שאף אחד מהסטודנטים ברשימה לא null, 
            fastest == null -> null שאנחנו לא מחזירים, null או  מחפשים את הזמן של
            this.students[i].Time < fastest.Time -> ושהזמן של הסטודנט הוא הזמן הכי קטן
            */
            if (this.students[i] != null && (fastest == null || this.students[i].Time < fastest.Time)){
                //מעדכן את המהיר ביותר
                fastest = this.students[i];
            }
        }
        return fastest;
    }
    
    public Sports_facility top_3_students(){
        double[] pos = {0,0};
        Sports_facility list_top_3 = new Sports_facility("",pos, 3);

        Array.Sort(this.students, Student.studentComparer);
        list_top_3.add_student(this.fastest_student());
        list_top_3.add_student(this.students[1]);
        list_top_3.add_student(this.students[2]);
        return list_top_3;
    }
    
    public void grading(){
        Sports_facility list_top_3 = this.top_3_students();
        for(int i = 0; i < this.students.Length ; i++){
            if(list_top_3.students[0] == this.students[i]){
                this.students[i].score += 3;
                continue;
            }
            if(list_top_3.students[1] == this.students[i]){
                this.students[i].score += 2;
                continue;
            }
            if(list_top_3.students[2] == this.students[i]){
                this.students[i].score += 1;
                continue;
            }
        }
        
    }
    /*
    היה צריך שינוי במחלקת Student, כדי לשמור את השדה
    */
    
    public Sports_facility(string name, double[] pos, int students_amount){
        this.name = name;
        this.Pos = pos;
        this.students = new Student[students_amount];
    }
    
    public Sports_facility(){
        this.name = "";
        this.Pos = new double[]{-1,-1};
        this.students = new Student[0];
    }
    
    public override string ToString(){
        if(this.name == "" && (this.pos[0] == 0 || this.pos[1] == 0) && this.students.Length == 3){
            return "the top 3 students are: " + this.str_students();
        }
        return "the sports facility '" + this.name +  "' is in [" + this.pos[0] + "," + this.pos[1] + "] and was played by: " + this.str_students();
    }
    
}

class Playground{
    public Sports_facility head { get; set; }
    public Sports_facility tail { get; set; }
    
    public Sports_facility[] facilities{
        get; set;
    }
    
    public bool is_facilities_empty(){
        if (this.facilities == null || this.facilities.Length == 0){ return true; }
        foreach(Sports_facility s in this.facilities){
            if(s == null){
                return true;
            }
            else{
                return false;
            }
        }
        return false;
    }
    
    public void add_sports_facility(Sports_facility s){
        if(this.is_facilities_empty()){
            s.previous = null;
            s.next = s.previous;
            this.facilities[0] = s;
            this.head = s;
            this.tail = s;
            return;
        }
        for(int i = 0; i < this.facilities.Length; i++){
            if (this.facilities[i] == null){
                s.previous = this.tail;
                this.facilities[i] = s;
                if(this.facilities.Length-1 == i){
                    s.next = null;
                }
                this.tail.next = s;
                this.tail = s;
                break;
            }
        }
    }
    
    public Student[] how_plays(Sports_facility s){
        return s.students;
    }
    
    public string[] played_in(string student_name){
        string[] facilities_names = new string[0]; // ריק
        foreach(Sports_facility facility in this.facilities){
            if (facility == null) { continue; } //מוודא שאין מתקן ריק
            foreach(Student s in facility.students){
                if (s == null || s.name == null) { continue; } //מודא שלא התלמיד או שמו הוא ריק
                if(s.name == student_name){
                    Array.Resize(ref facilities_names, facilities_names.Length + 1); // מעריך את המערך
                    facilities_names[facilities_names.Length - 1] = facility.name; // מוסיף את השם למקום שיצרו
                }
            }
        }
        return facilities_names;
    }

    
    public string[] winners(){
        string[] facilities_to_winners = new string[0]; // ריק
        foreach(Sports_facility facility in this.facilities){
            if(facility == null) { continue; }
            if(facility.fastest_student() == null) { continue; }
            Array.Resize(ref facilities_to_winners, facilities_to_winners.Length + 1); // resize array
            facilities_to_winners[facilities_to_winners.Length - 1] = "[ the winner of " + facility.name + " is - " + facility.fastest_student().ToString() + "]";
        }
        return facilities_to_winners;
    }
    
    public Playground(int facilities_amount){
        this.facilities = new Sports_facility[facilities_amount];
    }

    public string str_facilities() {
        //בודק שרשימת המתקנים מלאה
        if(this.is_facilities_empty()){ return "no facilities"; }
        string str = "[ \n";
        foreach(Sports_facility f in this.facilities){
            if (f == null){
                break;
            }
            str += f.ToString() + ",\n";
        }
        str += " ]";
        
        return str;
    }
    
    public override string ToString(){
        return "the playground contians: " + this.str_facilities();
    }
}

class Task1 {
    //עוזר להמיר מערכים לstr להדפסות
    static string ArrayToString<T>(T[] array) {
        //רץ על המערך ומוודא ששום דבר הוא לא null
        foreach( T item in array){
            if(item == null){
                return "empty";
            }
        }
        StringBuilder sb = new StringBuilder();
        sb.Append("{\n");
        foreach (T item in array) {
            sb.Append(item.ToString() + "\n");
        }
        sb.Append("}");
        return sb.ToString();
    }
    
    static Student best_student(Sports_facility[] our_class) {
        Student max_student = new Student("no one", DateTime.MaxValue);
        /*
        if(our_class == null){
            return max_student;
        }
        */
        foreach(Sports_facility facility in our_class){
            if(facility == null){ continue; }
            if(facility.fastest_student() == null){ continue; }
            if(max_student.faster(facility.fastest_student()) == facility.fastest_student()){
                max_student = facility.fastest_student();
            }
        }
        return max_student;
    }
    
  public static void runner() {
    Sports_facility[] class_A1 = new Sports_facility[] {
        new Sports_facility("runner", new double[]{4, 3}, 3),
        new Sports_facility("tension poles", new double[]{3, 3}, 3)
    };
    class_A1[0].add_student(new Student("omer", new DateTime(1, 1, 1, 15, 32, 18, 500)));
    class_A1[0].add_student(new Student("srtty", new DateTime(1, 1, 1, 14, 9, 3, 7)));
    class_A1[0].add_student(new Student("gfhjhj", new DateTime(1, 1, 1, 13, 19,7, 5)));
    class_A1[1].add_student(new Student("tgtljk", new DateTime(1, 1, 1, 9, 5,3, 2)));
    class_A1[1].add_student(new Student("ujgikh", new DateTime(1, 1, 1, 23, 4,6, 68)));
    class_A1[1].add_student(new Student("hklgykt", new DateTime(1, 1, 1, 8, 9,59, 99)));
    Console.WriteLine(ArrayToString(class_A1));
  }
}