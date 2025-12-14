
class random_task{
    public static void task_choser(){
        bool flag = true;
        while (flag){
            Console.WriteLine("Enter the task number (1-1) or '0' to exit, your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int taskNumber)){
                    Console.WriteLine("Invalid input. Please enter a valid task number.");
            continue;}

            switch (taskNumber){
                case 0:
                    flag = false; // Exit the program
                    break;

                case 1:
                    task_1();
                    break;

                default:
                    Console.WriteLine("Invalid task number. Please enter a number between 1 and 13.");
                    break;
            }

        }
    }
    static void task_1(){
        Console.WriteLine("task:" +
            "-לקלוט מספרים עד שנקלט המספר 1-\n" +
            "להדפיס את המספר עם הכי הרבה ספרות שיש\n" +
            "במידה ויש כמה מספרים עם הכי הרבה ספרות (שזה גם הכמות הכללית הכי גדולה כמובן)\n" +
            "יודפס המספר הכי קטן מבניהם");

        int max = 0;
        List<int> big_nums = new List<int>();

        while (true){
            Console.Write("-1 is stop, your number: ");
            if (!int.TryParse(Console.ReadLine(), out int input)){
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            if (input == -1) { break; }

            if (input.ToString().Length > max.ToString().Length){
                max = input;
                big_nums.Clear();
                big_nums.Add(input);
            }
            else if (input.ToString().Length == max.ToString().Length) { big_nums.Add(input); }
        }

        if (big_nums.Count == 0) { Console.WriteLine("Max: {0}", max); }
        else { Console.WriteLine("Min of equals: {0}", big_nums.Min()); }

    }
}
