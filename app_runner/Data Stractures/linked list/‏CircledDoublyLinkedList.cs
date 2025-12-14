//לא עובד עדיין
public class CircledDoublyLinkedList_Node<T>
{
    public T data { get; set; }
    public CircledDoublyLinkedList_Node<T> next { get; set; }
    public CircledDoublyLinkedList_Node<T> previous { get; set; }

    //כדי לא ליצור לולאה אינ-סופית
    public CircledDoublyLinkedList_Node(T value){
        this.data = value;
        this.next = null;
        this.previous = null;
    }

    public override string ToString() {
        if (this.previous == this.next){
            return string.Format("[ | null | [ <- | {0} | null ]", this.data);
        }
        if (this.previous == null) {
            return string.Format("[ | null | {0} | {1} ]", this.data, this.next.ToString()); 
        }
        if (this.next == null) {
            return string.Format("[ <- | {0} | null ]", this.data);
        }
        else {
            return string.Format("[ <- | {0} | {1} ]", this.data, this.next.ToString());
        }
    }
}

public class CircledDoublyLinkedList<T>
{
    public CircledDoublyLinkedList_Node<T> head { get; set; }
    public CircledDoublyLinkedList_Node<T> tail { get; set; }

    public void append(T data){
        CircledDoublyLinkedList_Node<T> to_add = new CircledDoublyLinkedList_Node<T>(data);
        if (this.head == null){
            this.head = to_add;
            this.tail = to_add;
            return;
        }
        to_add.previous = this.tail;
        this.tail.next = to_add;
        this.tail = to_add;
    }

    public void add_beginning(T data){
        if (this.head == null){
            this.head = new CircledDoublyLinkedList_Node<T>(data);
            this.tail = new CircledDoublyLinkedList_Node<T>(data);
            return;
        }
        CircledDoublyLinkedList_Node<T> old_head = this.head;
        this.head = new CircledDoublyLinkedList_Node<T>(data);
        old_head.previous = this.head;
        this.head.next = old_head;
    }
    
    public void remove_first(){
        if (this.head == null){ return; }
        this.head = this.head.next;
        this.head.previous = null;
    }
    
    public void remove_end(){
        if (this.head == null){ return; }
        this.tail = this.tail.previous;
        this.tail.next = null;
    }
    
    
    public void remove(T data){
        if (this.head == null){ return; }
        if (data.Equals(this.head.data)){
            this.remove_first();
            return;}
        if (data.Equals(this.tail.data)){
            this.remove_end();
            return;}

        CircledDoublyLinkedList_Node<T> current = this.head;
        while (current.next != null){
            if (current.next.data.Equals(data)){
                current.next = current.next.next;
                /*
                data = 65, this = null <-> 6 <-> 16 <-> 65 <-> 12 <-> 8 <-> null, 
                in this enstense, it removes node 65 from the previous of node 12, and places node 16 there,
                node 12 (current.next) was node 65, but in the last line we made it skip to be node 12,
                than it updates the previous of node 12 and to node 16, (current)
                */
                current.next.previous = current;
                return;
            }
            current = current.next;
        }
    }

    public double sum()
    {
        if (this.head == null) { return 0.0; }

        double sum = 0.0;
        CircledDoublyLinkedList_Node<T> current = this.head;
        while (current != null)
        {
            // Check if T is numeric using IConvertible
            if (current.data is IConvertible)
            {
                IConvertible convertible = (IConvertible)current.data;

                // Skip non-numeric types
                if (!(convertible is int || convertible is double))
                {
                    return 0.0;
                }

                if (convertible is int)
                {
                    int intValue = (int)convertible;
                    if (intValue % 2 == 0)
                    {
                        Convert.ChangeType(intValue, typeof(T));
                    }
                    sum += intValue;
                }
                else
                {
                    double doubleValue = Convert.ToDouble(convertible);
                    if (doubleValue % 2 == 0)
                    {
                        Convert.ChangeType(doubleValue, typeof(T));
                    }
                    sum += doubleValue;
                }

            }
            current = current.next;
        }
        return sum;
    }

    public CircledDoublyLinkedList<T> only_even()
    {
        CircledDoublyLinkedList<T> even_list = new CircledDoublyLinkedList<T>();
        if (this.head == null) { return even_list; }

        CircledDoublyLinkedList_Node<T> current = this.head;
        while (current != null)
        {
            if (current.data is IConvertible)
            {
                IConvertible convertible = (IConvertible)current.data;

                // Skip non-numeric types
                if (!(convertible is int || convertible is double))
                {
                    return even_list;
                }

                // Handle int and double cases
                if (convertible is int)
                {
                    int intValue = (int)convertible;
                    if (intValue % 2 == 0)
                    {
                        even_list.add_beginning((T)Convert.ChangeType(intValue, typeof(T)));
                    }
                }
                if (convertible is double)
                {
                    double doubleValue = Convert.ToDouble(convertible);
                    if (doubleValue % 2 == 0)
                    {
                        even_list.add_beginning((T)Convert.ChangeType(doubleValue, typeof(T)));
                    }
                }
            }
            current = current.next;
        }
        return even_list;
    }

    public bool is_in(int data){
        if (this.head == null) { return false; }
        if(this.tail.data.Equals(data) || this.head.data.Equals(data)){ return true;}

        CircledDoublyLinkedList_Node<T> current = this.head;
        while (current != null){
            if(current.data.Equals(data)){return true;}
        current = current.next;
        }
        return false;
    }
    
    public CircledDoublyLinkedList<T> marge(CircledDoublyLinkedList<T> l2){
        if (this.head == null && l2.head == null){return new CircledDoublyLinkedList<T>();}
        if(this.head == null){return l2;}
        if(l2.head == null){return this;}
        
        //מעביר את הבא של זנב הנוכחי לראש של הרשימה השנייה, ולראש הרשימה השנייה לשים את זנב הנוכחית בקודם ולהחזיר את הנוכחית
        this.tail.next = l2.head;
        l2.head.previous = this.tail;
        return this;
    }
    
    public CircledDoublyLinkedList<T> revarse(){
        CircledDoublyLinkedList<T> revarsed_list = new CircledDoublyLinkedList<T>();
        if (this.head == null) { return revarsed_list; }

        /*
        עושה אותו דבר רק קל להבין לוגית
        Node current = this.tail;
        while (current != null){
            revarsed_list.append(current.data);
            current = current.previous;
        }
        */

        CircledDoublyLinkedList_Node<T> current = this.head;
        while (current != null){
            revarsed_list.add_beginning(current.data);
            current = current.next;
        }
        
        return revarsed_list;
    }
    
    

    public override string ToString(){
        if (this.head == null) {
            return "empty";
        }
        string text = "null <-> ";
        CircledDoublyLinkedList_Node<T> current = this.head;
        do{
            text += current.data + " <-> ";
            current = current.next;
        } while (current != null);
        text += "null";
        return text;
    }

}

class CircledDoublyLinkedList_presenter
{
    public static void presenter(){        
        CircledDoublyLinkedList<int> l = new CircledDoublyLinkedList<int>();
        l.append(-2);
        l.append(-3);
        l.append(-4);
        l.append(-5);
        Console.WriteLine("the list: {0}", l);
        Console.WriteLine("the head: {0}", l.head);
        Console.WriteLine("the tail: {0}", l.tail);
        
        CircledDoublyLinkedList<int> l2 = new CircledDoublyLinkedList<int>();
        l2.append(-6);
        l2.append(-7);
        l2.append(-8);
        l2.append(-9);
        Console.WriteLine("the list: {0}", l2);
        Console.WriteLine("the head: {0}", l2.head);
        Console.WriteLine("the tail: {0}", l2.tail);

        CircledDoublyLinkedList<int> l3 = l.marge(l2);
        Console.WriteLine("marged list: {0}", l3);
        Console.WriteLine("revarsed list: {0}", l.revarse());
        Console.WriteLine(l3.sum());
        Console.WriteLine(l3.only_even());
    }
}