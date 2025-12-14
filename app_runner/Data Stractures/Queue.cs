using I_O = System.Console;
using System.Collections.Generic;

class Queue_presenter{
  static Queue<int> remove_from_queue(Queue<int> q, int n){
    Queue<int> n_q = new Queue<int>();
    foreach(int same in q){
        if(same != n){
            n_q.Enqueue(same);
        }
    }
    return n_q;
  }
  
  public static void presenter() {
    Queue<int> q = new Queue<int>();
    q.Enqueue(10);
    q.Enqueue(2);
    q.Enqueue(4);
    q.Enqueue(8);
    q.Enqueue(9);
    I_O.WriteLine("before: ");
    foreach(int i in q){
        I_O.WriteLine(i);
    }
    I_O.WriteLine("after: ");
    foreach(int i in remove_from_queue(q,2)){
        I_O.WriteLine(i);
    }
  }
}