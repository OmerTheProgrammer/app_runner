using System;
using System.Collections.Generic;
using System.Text;

class Human{
    public bool working{
        get; set;
    }
    //get ל2 השדות
    public string name{
        get; set;
    }
    
    private string phone_number;
    public string Phone_number {
        get {
            return this.phone_number;
        }
        set {
            bool is_numeric = false;
            foreach(char c in value){
                is_numeric = Char.IsDigit(c);
            }
            if(value.Length == 10 && is_numeric){
                this.phone_number = value;
            }
            else{
                this.phone_number = "0000000000";
            }
        }
    }
    
    //בנאי
    public Human(string name, bool working, string phone_number){
        this.name = name;
        this.working = working;
        this.Phone_number = phone_number;
    }

    //הצגת נתוני תלמיד
    public override string ToString(){
        return "the human " +this.name + ", how works " + this.working + "ly and his phone number is: " + this.Phone_number;
    }

}

public static class Queue_extensions
{
    public static string ToString<T>(this Queue<T> queue, string format)
    {
        StringBuilder sb = new StringBuilder();
        foreach (T item in queue)
        {
            sb.Append(string.Format(format, item));
            sb.Append(", ->\n");
        }
        if (queue.Count > 0)
        {
            sb.Length -= 5;
            sb.Append(".");
        }
        return sb.ToString();
    }
}

struct MrVanil
{
    public Queue<Human> waiting_list;
    public Queue<Human> workers_list;
    public MrVanil(Queue<Human> waiting_list, Queue<Human> workers_list)
    {
        this.waiting_list = waiting_list;
        this.workers_list = workers_list;
    }
    
    public override string ToString(){
        return "\nthe waiting list:\n" + waiting_list.ToString("{0}") + "\nand the workers list: " + workers_list.ToString("{0}");
    }
}
/*
השתמשתי במבנה נתונים טור, כי הוא עובד מי שנכנס ראשון יוצא ראשון, כפי שהמטלה ביקשה
*/
class Task2 {
  public static void runner() {
    
    MrVanil mr_vanil = new MrVanil{
    waiting_list = new Queue<Human>(),
    workers_list = new Queue<Human>() };
    bool is_running = true;
    int cases = 0;

    while (is_running){
        Console.WriteLine("Are you still here?");
        if (!bool.TryParse(Console.ReadLine(), out is_running)) {
            Console.WriteLine("Invalid input. Please enter a true or false.");
            is_running = true;
            continue; }
        if(!is_running) { break; }
        
        if(mr_vanil.waiting_list.Count == 0){ Console.WriteLine("The waiting list is empty."); }
        if(mr_vanil.workers_list.Count == 0){ Console.WriteLine("The workers list is empty."); }
        
        Console.WriteLine("what case you want to activate?\n1 - enter a parson to the waiting list,\n2 - hiring a new employee,\n3 - dismissal of an employee.");
        if (!int.TryParse(Console.ReadLine(), out cases)) {
            Console.WriteLine("Invalid input. Please enter a number.");
            continue;
        }
        switch (cases){
            case 1:
                Console.WriteLine("name:");
                string name = Console.ReadLine();
                
                bool working = false;
                while (true) {
                    Console.WriteLine("working? ");
                    if (!bool.TryParse(Console.ReadLine(), out working)) {
                        Console.WriteLine("Invalid input. Please enter a true or false.");
                    } else {
                        // Valid input provided, so break out of the loop
                        break;
                    }
                }
                if(working){
                    Console.WriteLine("you're working here.");
                    break;
                }
                
                Console.WriteLine("phone number:");
                string phone_number = Console.ReadLine();
                Human h = new Human(name,working, phone_number);
                mr_vanil.waiting_list.Enqueue(h);
                Console.WriteLine("i put you, {0}, in the waiting list.", h);
                break;
            
            case 2:
                if(mr_vanil.waiting_list.Count == 0){
                    Console.WriteLine("The waiting list is empty, you can't hire: no one");
                    break; }
                
                h = mr_vanil.waiting_list.Dequeue();
                h.working = true;
                mr_vanil.workers_list.Enqueue(h);
                Console.WriteLine("i hired you, {0}.", h);
                break;
                
            case 3:
                if(mr_vanil.workers_list.Count == 0){
                    Console.WriteLine("The workers list is empty, you can't fire: no one");
                    break; }
                
                h = mr_vanil.workers_list.Dequeue();
                h.working = false;
                mr_vanil.waiting_list.Enqueue(h);
                Console.WriteLine("i fired you, {0}.", h);
                break;
                
            default:
                Console.WriteLine("chose a case: 1 to 3");
                break;
        }
    }
    Console.WriteLine(mr_vanil);
  }
}