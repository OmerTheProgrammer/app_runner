using I_O = System.Console;
using System.Collections.Generic;
class Stack_presenter{
  public static void presenter() {
    I_O.WriteLine("write an mathematical expression:");
    string expression = I_O.ReadLine();
    
    Stack<char> last_open = new Stack<char>();
    bool start_end_same = false;
    char removed = ' ';
    
    foreach(char c in expression){
        switch(c){ case '{':
                last_open.Push('{');
                break;
            case '[':
                last_open.Push('[');
                break;
            case '(':
                last_open.Push('(');
                break;
            default:
                break;}
        
        if(last_open.Count != 0){
            switch(c){ case '}':
                removed = last_open.Pop();
                break;
            case ']':
                removed = last_open.Pop();
                break;
            case ')':
                removed = last_open.Pop();
                break;
            default:
                break;}
            //הסוגריים ליופי
            start_end_same = ((removed == '{') && (c == '}')) || ((removed == '[') && (c == ']')) || ((removed == '(') && (c == ')'));
        }
    }
    //מדפיס האם: כל סוגר מתואם להתחלתו, המחסנית ריקה, 
    I_O.WriteLine(last_open.Count == 0 && start_end_same);
  }
}