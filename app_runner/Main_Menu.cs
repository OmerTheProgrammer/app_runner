using System;
using app_runner.projects;

class Main_Menu
{
    public static int[] digit_splitters(int num){
        int starting_index = 0;
        int num_length = num.ToString().Length;
        int[] digits = new int[num_length];
        if (num < 0)
        {
            num = Math.Abs(num);
            digits[0] = -1;
            starting_index = 1;
        }

        for (int i = starting_index; i < num_length; i++){
            switch (i){
                case 0:
                    digits[i] = num / (int)Math.Pow(10, num_length - 1);
                    break;

                case int _ when i == num_length - 1:
                    digits[i] = num % 10;
                    break;

                default:
                    digits[i] = (num % (int)Math.Pow(10, num_length - i)) / (int)Math.Pow(10, num_length - (i+1));
                    break;
            }
            
        }
        return digits;
    }

    public static void prove_for_power_easy_solving()
    {
        Console.WriteLine("n^2: ");
        //num = base
        //num = -(int)Math.Sqrt(int.MaxValue), can't check negative becouse we need their starting diffrence
        int num = 0, answer = 0, diffrence = 1;
        while ( num < (int)Math.Sqrt(int.MaxValue) && Math.Pow(num, 2) == answer)
        {
            answer += diffrence;
            diffrence += 2;
            num++;
        }
        Console.WriteLine((Math.Pow(num, 2) == answer) + " for final num: " + num);


        Console.WriteLine("n^3: ");
        num = 0;
        answer = 0;
        diffrence = 1;
        while (num < (int)Math.Pow(int.MaxValue, (double)1 / 3) && Math.Pow(num, 3) == answer)
        {
            diffrence += 6 * num;
            answer += diffrence;
            num++;
        }
        Console.WriteLine((Math.Pow(num, 3) == answer) + " for final num: " + num);
    }

    public static void Main(){
        Show_menu();
    }

    public static void Show_menu()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Write("Enter the app number (1-14) or '0' to exit, '-1' to see the apps numbers,\nyour choise: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid task number.");
                continue;
            }

            switch (choice)
            {
                case -1:
                    Console.WriteLine("0. Exit\n" +
                       "1. Run Homework\n" +
                       "2. Run flags_runner\n" +
                       "3. Run Physics Calculator\n" +
                       "4. Run Shopping list\n" +
                       "5. Run work Calculator\n" +
                       "6. Run digit spliters\n" +
                       "7. Run password chaker\n" +
                       "8. Run random tasks\n" +
                       "9. the prof for power easy solving \n" +
                       "10. showing a date in names\n" +
                       "11. a Next Letter Conuter\n" +
                       "12. final poject\n" +
                       "13. classes I wrote and their presnation\n" +
                       "14. data structeres I wrote and their presnation");
                    break;
                case 0:
                    exit = true;
                    break;

                case 1:
                    Homework.task_choser();
                    break;

                case 2:
                    Flags.flags_runner();
                    break;

                case 3:
                    PhysicsCalculator_main.PhysicsCalculator_Runner();
                    break;

                case 4:
                    Shoping_list.Shoping_list_runner();
                    break;

                case 5:
                    caculetor.work_caculetor_runner();
                    break;

                case 6:
                    int num;
                    do
                    {
                        Console.Write("give me a number: ");
                    } while (!int.TryParse(Console.ReadLine(), out num));
                    int[] digits = digit_splitters(num);
                    for (int i = 0; i < digits.Length; i++) { Console.WriteLine("index: " + i + " = " + digits[i]); }
                    break;

                case 7:
                    passward_cheker.cheker();
                    break;

                case 8:
                    random_task.task_choser();
                    break;

                case 9:
                    prove_for_power_easy_solving();
                    break;

                case 10:
                    get_date.date_presnater();
                    break;

                case 11:
                    NextLetter.NextLetterConuter();
                    break;

                case 12:
                    int part;
                    do
                    {
                        Console.Write("give me (1/2) for the project part: ");
                    } while (!int.TryParse(Console.ReadLine(), out part) && !(part == 1 || part == 2));
                    switch (part)
                    {
                        case 1:
                            Task1.runner();
                            break;

                        case 2:
                            Task2.runner();
                            break;
                    }
                    break;

                case 13:
                    int class_name = 0;
                    do
                    {
                        Console.Write("give me (1->Animals/2->Circle/3->Phone/4->Store) for the project part: ");
                    } while (!int.TryParse(Console.ReadLine(), out class_name) && !(class_name >= 1 && class_name <= 4));
                    switch (class_name)
                    {
                        case 1:
                            prasnter_class.presenter();
                            break;

                        case 2:
                            circle_prasnter.presenter();
                            break;

                        case 3:
                            PhonePresenter.presenter();
                            break;

                        case 4:
                            store_presenter.presenter();
                            break;
                    }
                    break;

                case 14:
                    int data_strucher_name = 0;
                    do
                    {
                        Console.Write("give me (1->SingleLinkedList/2->CircledLinkedList/3->DoublyLinkedList/4->CircledDoubledLinkedList/5->Stack/6->Queue) for the project part: ");
                    } while (!int.TryParse(Console.ReadLine(), out data_strucher_name) && !(data_strucher_name >= 1 && data_strucher_name <= 6));
                    switch (data_strucher_name)
                    {
                        case 1:
                            SingleLinkedList_presenter.presenter();
                            break;

                        case 2:
                            CircledLinkedList_presenter.presenter();
                            break;

                        case 3:
                            DoublyLinkedList_presenter.presenter();
                            break;

                        case 4:
                            CircledDoublyLinkedList_presenter.presenter();
                            break;

                        case 5:
                            Stack_presenter.presenter();
                            break;

                        case 6:
                            Queue_presenter.presenter();
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }

    }
}
