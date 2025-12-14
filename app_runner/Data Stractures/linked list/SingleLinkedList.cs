public class SingleLinkedList_Node<T> where T : IComparable
{
    public T data { get; set; }
    public SingleLinkedList_Node<T> next { get; set; }

    public SingleLinkedList_Node(T value)
    {
        this.data = value;
        this.next = null;
    }

    public override string ToString()
    {
        if (this.next == null)
        {
            return "[ " + this.data.ToString() + "| null |]";
        }
        return "[ " + this.data.ToString() + " | " + this.next.ToString() + " |]";
    }
}

public class SingleLinkedList<T> where T : IComparable
{
    public SingleLinkedList_Node<T> head { get; set; }

    public void append(T data){
        if (this.head == null){
            this.head = new SingleLinkedList_Node<T>(data);
        }
        else{
            SingleLinkedList_Node<T> current = head;
            while (current.next != null){
                current = current.next;
            }
            current.next = new SingleLinkedList_Node<T>(data);
        }
    }

    public void add_beginning(T data){
        SingleLinkedList_Node<T> old_head = this.head;
        this.head = new SingleLinkedList_Node<T>(data);
        this.head.next = old_head;
    }

    public void remove_first(){
        if (this.head != null){
            this.head = this.head.next;
        }
    }

    public void remove_end(){
        SingleLinkedList_Node<T> current = this.head;
        while (current.next.next != null){
            current = current.next;
        }
        current.next = null;
    }

    public void remove(T data){
        if (this.head == null) { return; }

        if (this.head.data.Equals(data)){
            this.remove_first();
            return;
        }

        SingleLinkedList_Node<T> current = this.head;
        while (current.next != null){
            if (current.next.data.Equals(data)){
                current.next = current.next.next;
                return;
            }
            current = current.next;
        }
    }

    //עובד לint וdouble
    public double sum()
    {
        if (this.head == null) { return 0.0; }

        double sum = 0.0;
        SingleLinkedList_Node<T> current = this.head;
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


    //עובד לint וdouble
    public SingleLinkedList<T> only_even()
    {
      SingleLinkedList<T> even_list = new SingleLinkedList<T>();
      if (this.head == null) { return even_list; }

      SingleLinkedList_Node<T> current = this.head;
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
                if(convertible is double)
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

    public bool is_in(T data){
        if (this.head == null) { return false; }
        if (this.head.data.Equals(data)) { return true; }

        SingleLinkedList_Node<T> current = this.head;
        while (current != null){
            if(current.data.Equals(data)) {return true;}
        current = current.next;
        }
        return false;
    }
    
    public override string ToString(){
        string text = "";
        if (this.head == null) { return text; }
        SingleLinkedList_Node<T> current = this.head;
        while (current.next != null)
        {
            text += current.data + " -> ";
            current = current.next;
        }
        text += current.data + " -> null";
        return text;
    }
}

class SingleLinkedList_presenter
{
    public static void presenter(){
        
        SingleLinkedList<int> l = new SingleLinkedList<int>();
        l.append(16);
        l.append(65);
        l.add_beginning(12);
        l.add_beginning(8);
        Console.WriteLine("the list: {0}", l);
        Console.WriteLine("the head: {0}", l.head);
        Console.WriteLine("the second node in the list: {0}", l.head.next);
        Console.WriteLine(l.sum());
        Console.WriteLine(l.only_even());
        Console.WriteLine();

        SingleLinkedList<double> l2 = new SingleLinkedList<double>();
        l2.append(16.7);
        l2.append(65.2);
        l2.add_beginning(54.7);
        l2.add_beginning(8);
        Console.WriteLine("the list: {0}", l2);
        Console.WriteLine("the head: {0}", l2.head);
        Console.WriteLine("the second node in the list: {0}", l2.head.next);
        Console.WriteLine(l2.sum());
        Console.WriteLine(l2.only_even());
        Console.WriteLine();

        SingleLinkedList<string> l3 = new SingleLinkedList<string>();
        l3.append("553");
        l3.append("jy");
        l3.add_beginning(",.;po");
        l3.add_beginning("9kiy");
        Console.WriteLine("the list: {0}", l3);
        Console.WriteLine("the head: {0}", l3.head);
        Console.WriteLine("the second node in the list: {0}", l3.head.next);
        Console.WriteLine(l3.sum());
        Console.WriteLine(l3.only_even());

    }
}