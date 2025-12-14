using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Globalization;
using System.Net.Sockets;
using System.Xml.Linq;
//using Newtonsoft.Json.Linq;
//לשאלה 13

class Homework
{

    private static void DisplayTaskList()
    {
        Console.WriteLine("the tasks:\n" +
             "1. task 1 in second paper\n" +
             "2. task 2 in second paper\n" +
             "3. task 3 in second paper\n" +
             "4. task 4 in second paper\n" +
             "5. task 5 in second paper\n" +
             "6. task 6 in second paper\n" +
             "7. task 7 in second paper\n" +
             "8. task 8 in second paper\n" +
             "9. task 9 in second paper\n" +
             "10. task 10 in second paper\n" +
             "11. task 11 in second paper\n" +
             "12. task 12 in second paper\n" +
             "13. task 13 in second paper\n" +
             "14. task 5 in book 1 page 59\n" +
             "15. task 6 in book 1 page 59\n" +
             "16. task 7 in book 1 page 59\n" +
             "17. task 8 in book 1 page 59\n" +
             "18. task 9 in book 1 page 59\n" +
             "19. task 10 in book 1 page 59\n" +
             "20. task 1 in math_class.docx \n" +
             "21. task 2 in math_class.docx\n" +
             "22. task 3 in math_class.docx\n" +
             "4 wasn't a program\n" +
             "23. task 5 in math_class.docx\n" +
             "24. task 6 in math_class.docx\n" +
             "25. task 7 in math_class.docx\n" +
             "26. task 8 in math_class.docx\n" +
             "27. task 9 in math_class.docx\n" +
             "28. task 10 in math_class.docx \n" +
             "29. task 11 in math_class.docx \n" +
             "30. task 5 in book 1 page 70 \n" +
             "31. task 6 in book 1 page 70\n" +
             "32. task 7 in book 1 page 70\n" +
             "33. task 8 in book 1 page 70\n" +
             "34. chacking the term (num == 0) && ( (num > 0) || (num == -5) )\n" +
             "35. task 9 in book 1 page 70\n" +
             "36. task 10 in book 1 page 71\n" +
             "37. task 11 in book 1 page 71\n" +
             "38. task 12 in book 1 page 71\n" +
             "39. task 13 in book 1 page 71\n" +
             "40. task 14 in book 1 page 71\n" +
             "41. task 15 in book 1 page 72\n" +
             "42. task 16 in book 1 page 72\n" +
             "43. task 1 in third paper \n" +
             "44. task 2 in third paper \n" +
             "45. task 3 in third paper \n" +
             "46. task 4 in third paper\n" +
             "47. task 5 in third paper\n" +
             "48. task 25 in book 1 page 80\n" +
             "49. task 26 in book 1 page 80\n" +
             "50. task 28 in book 1 page 80\n" +
             "51. task 29 in book 1 page 81\n" +
             "52. task 30 in book 1 page 81\n" +
             "53. task 31 in book 1 page 81\n" +
             "54. task 36 in book 1 page 84\n" +
             "55. task 37 in book 1 page 84\n" +
             "56. task 40 in book 1 page 85\n" +
             "57. task 41 in book 1 page 85\n" +
             "58. task 42 in book 1 page 85\n" +
             "59. task 43 in book 1 page 85\n" +
             "60. task 44 in book 1 page 85\n" +
             "61. task 6 in book 1 page 106\n" +
             "62. task 7 in book 1 page 106\n" +
             "63. task 8 in book 1 page 106\n" +
             "64. task 9 in book 1 page 106\n" +
             "65. task 10 in book 1 page 107\n" +
             "66. task 8 in book 1 page 117\n" +
             "67. task 9 in book 1 page 117\n" +
             "68. task 10 in book 1 page 117\n" +
             "69. task 11 in book 1 page 117\n" +
             "70. task 12 in book 1 page 117\n" +
             "71. task 13 in book 1 page 117\n" +
             "72. task 14 in book 1 page 118\n" +
             "73. task 15 in book 1 page 118\n" +
             "74. task 16 in book 1 page 118\n" +
             "75. task 17 in book 1 page 118\n" +
             "76. task 18 in book 1 page 118\n" +
             "77. task 19 in book 1 page 118\n" +
             "78. task 20 in book 1 page 124\n" +
             "79. task 21 in book 1 page 124\n" +
             "80. task 22 in book 1 page 124\n" +
             "81. task 23 in book 1 page 124\n" +
             "82. task 24 in book 1 page 124\n" +
             "83. task 25 in book 1 page 124\n" +
             "84. task 28 in book 1 page 125\n" +
             "85. task 32 in book 1 page 132\n" +
             "86. task 33 in book 1 page 132\n" +
             "87. task 34 in book 1 page 132\n" +
             "88. task 35 in book 1 page 132\n" +
             "89. task 36 in book 1 page 132\n" +
             "90. task 37 in book 1 page 132\n" +
             "91. task 38 in book 1 page 133\n" +
             "92. task 39 in book 1 page 133\n" +
             "93. task 42 in book 1 page 136\n" +
             "94. task 44 in book 1 page 136\n" +
             "95. task 45 in book 1 page 137\n" +
             "96. task 46 in book 1 page 137\n" +
             "97. task 47 in book 1 page 137\n" +
             "98. task 48 in book 1 page 137\n" +
             "99. task 49 in book 1 page 137\n" +
             "100. task 50 in book 1 page 137\n" +
             "101. task 51 in book 1 page 137\n" +
             "102. task 52 in book 1 page 138\n" +
             "103. task 53 in book 1 page 138\n" +
             "104. task 54 in book 1 page 138\n" +
             "105. task 55 in book 1 page 138\n" +
             "106. \n" +
             "107. \n" +
             "108. \n" +
             "109. \n" +
             "110. \n" +
             "111. \n" +
             "112. \n");
    }

    private static bool ExecuteTask(int taskNumber)
    {
        switch (taskNumber)
        {
            case -1:
                DisplayTaskList();
                break;

            case 0:
                return false; // Exit the program

            case 1:
                task_1();
                break;

            case 2:
                task_2();
                break;

            case 3:
                task_3();
                break;

            case 4:
                task_4();
                break;

            case 5:
                task_5();
                break;

            case 6:
                task_6();
                break;

            case 7:
                task_7();
                break;

            case 8:
                task_8();
                break;

            case 9:
                task_9();
                break;

            case 10:
                task_10();
                break;

            case 11:
                float[] peremater_and_area = task_11();
                Console.WriteLine("his peremater: {0}", peremater_and_area[0]);
                Console.WriteLine("him area: {0}", peremater_and_area[1]);
                break;

            case 12:
                task_12();
                break;

            case 13:
                //task_13();
                break;

            case 14:
                task_14();
                break;

            case 15:
                task_15();
                break;

            case 16:
                task_16();
                break;

            case 17:
                task_17();
                break;

            case 18:
                task_18();
                break;

            case 19:
                task_19();
                break;

            case 20:
                Console.WriteLine("paramter: {0}", task_20());
                break;

            case 21:
                task_21();
                break;

            case 22:
                task_22();
                break;

            case 23:
                Console.WriteLine("volume: {0}", task_23());
                break;

            case 24:
                double[] P_and_A = task_24();
                Console.WriteLine("parameter: {0}", P_and_A[0]);
                Console.WriteLine("area: {0}", P_and_A[1]);
                Console.WriteLine("diffrence: {0}", Math.Abs(P_and_A[0] - P_and_A[1]));
                break;

            case 25:
                task_25();
                break;

            case 26:
                task_26();
                break;

            case 27:
                task_27();
                break;

            case 28:
                task_28();
                break;

            case 29:
                task_29();
                break;

            case 30:
                task_30();
                break;

            case 31:
                task_31();
                break;

            case 32:
                task_32();
                break;

            case 33:
                task_33();
                break;

            case 34:
                task_34();
                break;

            case 35:
                task_35();
                break;

            case 36:
                task_36();
                break;

            case 37:
                task_37();
                break;

            case 38:
                task_38();
                break;

            case 39:
                task_39();
                break;

            case 40:
                task_40();
                break;

            case 41:
                task_41();
                break;

            case 42:
                task_42();
                break;

            case 43:
                task_43();
                break;

            case 44:
                task_44();
                break;

            case 45:
                task_45();
                break;

            case 46:
                task_46();
                break;

            case 47:
                task_47();
                break;

            case 48:
                task_48();
                break;

            case 49:
                task_49();
                break;

            case 50:
                task_50();
                break;

            case 51:
                task_51();
                break;

            case 52:
                task_52();
                break;

            case 53:
                task_53();
                break;

            case 54:
                task_54();
                break;

            case 55:
                task_55();
                break;

            case 56:
                task_56();
                break;

            case 57:
                task_57();
                break;

            case 58:
                task_58();
                break;

            case 59:
                task_59();
                break;

            case 60:
                task_60();
                break;

            case 61:
                task_61();
                break;

            case 62:
                task_62();
                break;

            case 63:
                task_63();
                break;

            case 64:
                task_64();
                break;

            case 65:
                task_65();
                break;

            case 66:
                task_66();
                break;

            case 67:
                task_67();
                break;

            case 68:
                task_68();
                break;

            case 69:
                task_69();
                break;

            case 70:
                task_70();
                break;

            case 71:
                task_71();
                break;

            case 72:
                task_72();
                break;

            case 73:
                task_73();
                break;

            case 74:
                task_74();
                break;

            case 75:
                task_75();
                break;

            case 76:
                task_76();
                break;

            case 77:
                task_77();
                break;

            case 78:
                task_78();
                break;

            case 79:
                task_79();
                break;

            case 80:
                task_80();
                break;

            case 81:
                task_81();
                break;

            case 82:
                task_82();
                break;

            case 83:
                task_83();
                break;

            case 84:
                task_84();
                break;

            case 85:
                task_85();
                break;

            case 86:
                task_86();
                break;

            case 87:
                task_87();
                break;

            case 88:
                task_88();
                break;

            case 89:
                task_89();
                break;

            case 90:
                task_90();
                break;

            case 91:
                task_91();
                break;

            case 92:
                task_92();
                break;

            case 93:
                task_93();
                break;

            case 94:
                task_94();
                break;

            case 95:
                task_95();
                break;

            case 96:
                task_96();
                break;

            case 97:
                task_97();
                break;

            case 98:
                task_98();
                break;

            case 99:
                task_99();
                break;

            case 100:
                task_100();
                break;

            case 101:
                task_101();
                break;

            case 102:
                task_102();
                break;

            case 103:
                task_103();
                break;

            case 104:
                task_104();
                break;

            case 105:
                task_105();
                break;

            case 106:
                task_106();
                break;

            case 107:
                task_107();
                break;

            case 108:
                task_108();
                break;

            case 109:
                task_109();
                break;

            case 110:
                task_110();
                break;

            default:
                Console.WriteLine("Invalid task number. Please enter a number between 1 and 110.");
                return true;
        }

        return true; // so if task is finished, reshow menu
    }


    public static void task_choser()
    {
        bool flag = true;
        while (flag)
        {
            Console.Write("Enter the task number (1-110) or '0' to exit or '-1' to see the tasks numbers,\nyour choice: ");

            if (!int.TryParse(Console.ReadLine(), out int taskNumber) || taskNumber < -1 || taskNumber > 110)
            {
                Console.WriteLine("Invalid input. Please enter a valid task number.");
                continue;
            }

            flag = ExecuteTask(taskNumber);
        }
    }

    static void task_1()
    {
        float sum = 0;
        float[] prices = new float[3];
        string[] str_products = { "bread", "milk", "margerita" };

        for (int i = 0; i < 3; i++)
        {
            do
            {
                Console.WriteLine("Enter the price of {0}:", str_products[i]);
            } while (!float.TryParse(Console.ReadLine(), out prices[i]) || prices[i] <= 0);
            sum += prices[i];
        }
        Console.WriteLine("sum: {0}", sum);
    }

    static void task_2()
    {
        int shirt_num;
        const int butten_num = 6;
        do
        {
            Console.WriteLine("the amout of shirt that had been made:");
        } while (!int.TryParse(Console.ReadLine(), out shirt_num) || shirt_num < 0);

        Console.WriteLine("the amount of buttens needed: {0}", butten_num * shirt_num);
    }

    static void task_3()
    {
        int score;
        Dictionary<string, int> sport_gropes = new Dictionary<string, int>();
        foreach (string name in new string[] { "macabi tel aviv", "hapoal galil alion" })
        {
            do
            {
                Console.WriteLine("who many points for {0}:", name);
            } while (!int.TryParse(Console.ReadLine(), out score) || score < 0);
            sport_gropes[name] = score;
        }

        Console.WriteLine("The diffrence betwenn {0} and {1} : {2}",
        sport_gropes.First(x => x.Value == sport_gropes.Max(y => y.Value)).Key,
        sport_gropes.First(x => x.Value == sport_gropes.Min(y => y.Value)).Key,
        sport_gropes.Max(y => y.Value) - sport_gropes.Min(y => y.Value));
    }

    static void task_4()
    {
        float soft_cover_book_price;
        do
        {
            Console.WriteLine("what's soft cover book's price:");
        } while (!float.TryParse(Console.ReadLine(), out soft_cover_book_price) || soft_cover_book_price <= 0);
        Console.WriteLine("hard cover book's price: {0}", soft_cover_book_price * 1.08);
    }

    static void task_5()
    {
        float[] pencil_packs_amounts = new float[2];
        const float red_pencil_pack_price = 5.0F;
        const float green_pencil_pack_price = 6.9F;
        string[] texts = { "what's the amount of red pencil packs you bought:", "what's the amount of green pencil packs you bought:" };

        for (int i = 0; i < 2; i++)
        {
            do
            {
                Console.WriteLine(texts[i]);
            } while (!float.TryParse(Console.ReadLine(), out pencil_packs_amounts[i]) || pencil_packs_amounts[i] < 0);
        }

        Console.WriteLine("you need to pay: {0}", pencil_packs_amounts[0] * red_pencil_pack_price +
        pencil_packs_amounts[1] * green_pencil_pack_price);

        Console.WriteLine("there is 10% off so you need to pay: {0}", pencil_packs_amounts[0] * red_pencil_pack_price +
        pencil_packs_amounts[1] * green_pencil_pack_price * 0.9);
    }

    static void task_6()
    {
        int phone_call_amount;
        const float phone_call_price = 0.3F;
        do
        {
            Console.WriteLine("who many phone calls have you made this month:");
        } while (!int.TryParse(Console.ReadLine(), out phone_call_amount) || phone_call_amount < 0);

        Console.WriteLine("you need to pay: {0}", phone_call_price * phone_call_amount);
    }

    static void task_7()
    {
        const int baget = 10000;
        string[] texts = { "what's the price of a table:", "what's the price of a cabinet:", "what's the price of a chair:" };
        float[] prices = new float[3];

        for (int i = 0; i < 3; i++)
        {
            do
            {
                Console.WriteLine(texts[i]);
            } while (!float.TryParse(Console.ReadLine(), out prices[i]) || prices[i] <= 0);
        }

        float cost = 8 * prices[2] + prices[1] + prices[0];
        Console.WriteLine("you need to pay: {0}", cost);
        if (baget - cost > 0)
        {
            Console.WriteLine("you remain with: {0}", baget - cost);
        }
        else if (baget - cost == 0)
        {
            Console.WriteLine("you have the perfect amount");
        }
        else if (baget - cost < 0)
        {
            Console.WriteLine("you don't have enuoght");
        }
    }

    static void task_8()
    {
        string[] texts = { "Enter the length of side 'a': ", "Enter the length of side 'b': " };
        float[] sides = new float[2];

        for (int i = 0; i < 2; i++)
        {
            do
            {
                Console.WriteLine(texts[i]);
            } while (!float.TryParse(Console.ReadLine(), out sides[i]) || sides[i] <= 0);
        }
        Console.WriteLine("The length of the hypotenuse 'c' is: {0}", Math.Sqrt(sides[0] * sides[0] + sides[1] * sides[1]));
    }

    static void task_9()
    {
        int number;
        do
        {
            Console.WriteLine("give me a number:");
        } while (!int.TryParse(Console.ReadLine(), out number));
        Console.WriteLine("his sqrure: {0}", Math.Sqrt(number));
        Console.WriteLine("him sqrured: {0}", Math.Pow(number, 2));
        Console.WriteLine("him to th sevest power: {0}", Math.Pow(number, 7));
    }

    static void task_10()
    {
        int height;
        Dictionary<string, int> mountins_to_hights = new Dictionary<string, int>();
        foreach (string name in new string[] { "grizim", "arbel" })
        {
            do
            {
                Console.WriteLine("the height of the mountin {0}:", name);
            } while (!int.TryParse(Console.ReadLine(), out height) || height <= 0);
            mountins_to_hights[name] = height;
        }

        Console.WriteLine("The diffrence betwenn {0} and {1} : {2}",
        mountins_to_hights.First(x => x.Value == mountins_to_hights.Max(y => y.Value)).Key,
        mountins_to_hights.First(x => x.Value == mountins_to_hights.Min(y => y.Value)).Key,
        mountins_to_hights.Max(y => y.Value) - mountins_to_hights.Min(y => y.Value));
    }

    static float[] task_11()
    {
        int radius;
        do
        {
            Console.WriteLine("give me a radius:");
        } while (!int.TryParse(Console.ReadLine(), out radius) || radius <= 0);
        return new float[] { 2 * (float)Math.PI * radius, (float)Math.PI * radius * radius };
    }

    static void task_12()
    {
        Dictionary<string, float[]> circles_to_P_and_A = new Dictionary<string, float[]>();
        float[] P_and_A = new float[2];
        for (int i = 0; i < 2; i++)
        {
            P_and_A = Homework.task_11();
            circles_to_P_and_A[$"circle(r={P_and_A[0] / (float)Math.PI / 2})"] = P_and_A;
        }

        string[] texts = { "perimeter", "area" };
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("The difference between {0}'s and {1}'s {2} is: {3}",
            circles_to_P_and_A.First(pair => pair.Value[i] == circles_to_P_and_A.Max(perimeter => perimeter.Value[i])).Key,
            circles_to_P_and_A.First(pair => pair.Value[i] == circles_to_P_and_A.Min(perimeter => perimeter.Value[i])).Key,
            texts[i],
            circles_to_P_and_A.Max(pair => pair.Value[i]) - circles_to_P_and_A.Min(pair => pair.Value[i]));
        }
    }

    /*static void task_13() {
        float dollar_amount;

        // Get the real-time exchange rate from an API (Open Exchange Rates in this example)
        float dollar_rate = GetRealTimeDollarRate(); // Replace with your chosen API

        do
        {
            Console.WriteLine("How many dollars to convert to shekels:");
            if (float.TryParse(Console.ReadLine(), out dollar_amount) && dollar_amount > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }
        } while (true);

        try
        {
            float shekelAmount = dollar_amount * dollar_rate;
            Console.WriteLine("The amount in shekels: {0}", shekelAmount.ToString("C", CultureInfo.GetCultureInfo("he-IL")));
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    // Function to get the real-time dollar rate from an API
    static float GetRealTimeDollarRate()
    {
        try
        {
            string apiKey = "YOUR_API_KEY"; // Replace with your API key
            string url = $"https://openexchangerates.org/api/latest.json?app_id={apiKey}&base=USD";

            WebClient webClient = new WebClient();
            string response = webClient.DownloadString(url);

            // Parse the JSON response to get the exchange rate
            JObject data = JObject.Parse(response);
            float dollarRate = (float)data["rates"]["ILS"];

            return dollarRate;
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while fetching the exchange rate: " + ex.Message);
            // You can handle the error accordingly, e.g., provide a default rate.
            return 3.81f; // Default exchange rate
        }
    }*/

    static void task_14()
    {
        // àé àôùø ìäùúîù áîùúðä ùäåà ðåöø áìåìàä ìëï, öøéê ìäöäéø òìéå ìôðé ëãé ùðåëì ìäùúîù áå
        int minutes;
        do
        {
            Console.WriteLine("time in minutes: ");
            // ÷ìéèä ùì äîùúðä ã÷åú, åäâðä îî÷øé ÷öä ùì ã÷åú ùìéìéåú åúååéí ìà îñôøééí
        } while (!int.TryParse(Console.ReadLine(), out minutes) || minutes < 0);
        // çéùåáéí åäãôñä, ìà öøéê àåúí áäîùê åìëï ìà àùîåø àåúí
        Console.WriteLine("hours: {0}, minutes: {1}", minutes / 60, minutes % 60);
    }

    static void task_15()
    {
        // àé àôùø ìäùúîù áîùúðä ùäåà ðåöø áìåìàä ìëï, öøéê ìäöäéø òìéå ìôðé ëãé ùðåëì ìäùúîù áå
        int initialParticipants;
        do
        {
            Console.WriteLine("Enter the initial number of participants: ");
            // ÷ìéèä ùì äîùúðä îñôø îùúîùéí, åäâðä îî÷øé ÷öä ùì  îñôø îùúîùéí ùìéìé åúååéí ìà îñôøééí
        } while (!int.TryParse(Console.ReadLine(), out initialParticipants) || initialParticipants < 0);
        int goneAfterFirstRound = 0; // îàôñ àú îñôø äîùúúôéí ùòæáå

        for (int i = 1; i <= initialParticipants; i++)
        { //áåã÷ àú ëì äîùúúôéí
            if (i % 7 == 0 || i.ToString().Contains("7"))
            { // äàí îúçì÷éí á7 àå ëôåìä ùì 7 
                Console.WriteLine(i); //îãôéñ àú àìå ùéöàå
                goneAfterFirstRound++; // ú÷ãí àú îñôø àìå ùéöàå
            }
        }

        // çéùåáéí åäãôñä, ìà öøéê àåúí áäîùê åìëï ìà àùîåø àåúí
        Console.WriteLine("are out.\nNumber of participants leaving in the first round: " + goneAfterFirstRound);
        // îçñø àú ñäê äîùúôéí îîñôø àìå ùòæáå
        Console.WriteLine("Number of participants remaining after the first round: {0}", initialParticipants - goneAfterFirstRound);
    }

    static void task_16()
    {
        char[] c_digits = new char[2]; // ùåîø 2 úååéí
        for (int i = 0; i < 2; i++)
        {
            do
            {
                Console.Write("Give me a digit: ");
            } while (!char.TryParse(Console.ReadLine(), out c_digits[i]) || !char.IsDigit(c_digits[i])); // îååãà ùäúååéí éäéå îñôøéí
        }

        int[] numbers = new int[2]; // äîñôøéí ìôúøåï
        numbers[0] = int.Parse(c_digits[0].ToString() + c_digits[1]); // îñôø éùø
        numbers[1] = int.Parse(c_digits[1].ToString() + c_digits[0]); // îñôø äôåê

        Console.WriteLine("the numbers: ");
        foreach (int num in numbers)
        {
            Console.WriteLine("the {0} number: {1}", Array.IndexOf(numbers, num) + 1, num); // îöéâ àú 2 äîñôøéí
        }
        Console.WriteLine("Sum: {0}", numbers[0] + numbers[1]); // çéùåáéí åäãôñä, ìà öøéê àåúí áäîùê åìëï ìà àùîåø àåúí
        Console.WriteLine("int devide: {0}", numbers[0] / numbers[1]);
        Console.WriteLine("remanider: {0}", numbers[0] % numbers[1]);
    }


    static void task_17()
    {
        int num;
        do
        {
            Console.WriteLine("Enter a 2 digit num: ");
        } while (!int.TryParse(Console.ReadLine(), out num) || num < 0 || num.ToString().Length != 2);

        Console.WriteLine(num + num % 10 * 100);
    }
    static void task_18()
    {
        // àé àôùø ìäùúîù áîùúðä ùäåà ðåöø áìåìàä ìëï, öøéê ìäöäéø òìéå ìôðé ëãé ùðåëì ìäùúîù áå
        int days;
        do
        {
            Console.WriteLine("Enter the days count: ");
            // ÷ìéèä ùì äîùúðä îñôø éîéí, åäâðä îî÷øé ÷öä ùì îñôø éîéí ùìéìé åúååéí ìà îñôøééí
        } while (!int.TryParse(Console.ReadLine(), out days) || days < 0);

        int years = days / 365; //îñôø äùðéí
        days -= 365 * years; //ëãé ìòãëï àú äùàøéú
        Console.WriteLine("years: {0}", years);
        int months = days / 30; //îñôø äçåãùéí
        days -= 30 * months;//ëãé ìòãëï àú äùàøéú
        Console.WriteLine("months: {0}", months);
        int weeks = days / 7; //îñôø äùáåòåú
        Console.WriteLine("weeks: {0}", weeks);
        days -= 7 * weeks;//ëãé ìòãëï àú äùàøéú
        Console.WriteLine("days: {0}", days);//äùàøéú äéà äéîéí
    }
    static void task_19()
    {
        // àé àôùø ìäùúîù áîùúðä ùäåà ðåöø áìåìàä ìëï, öøéê ìäöäéø òìéå ìôðé ëãé ùðåëì ìäùúîù áå
        int num;
        do
        {
            Console.WriteLine("Enter the num: ");
            // ÷ìéèä ùì äîùúðä îñôø, åäâðä îî÷øé ÷öä ùì îñôø áàåøê ùåðä î3 åúååéí ìà îñôøééí
        } while (!int.TryParse(Console.ReadLine(), out num) || num.ToString().Length != 3);
        int[] digits = Main_Menu.digit_splitters(num);
        Console.WriteLine("sum: {0}", digits[0] + digits[1] + digits[2]); //çéùåáéí åäãôñåú
        Console.WriteLine("{0} + {1} + {2} = {3}", digits[0] * 100, digits[1] * 10, digits[2], num);
        Array.Reverse(digits); //äåôê àú äîòøê = äåôê àú äîñôø
        Console.Write("reversed: ");
        for (int i = 0; i < num.ToString().Length; i++)
        {
            Console.Write(digits[i]); // äãôñú äñôøåú
        }
        Console.WriteLine();
    }

    static double task_20()
    {
        // àé àôùø ìäùúîù áîùúðä ùäåà ðåöø áìåìàä ìëï, öøéê ìäöäéø òìéå ìôðé ëãé ùðåëì ìäùúîù áå
        double area;
        do
        {
            Console.WriteLine("Enter the area: ");
            // ÷ìéèä ùì äîùúðä äé÷ó, åäâðä îî÷øé ÷öä ùì äé÷ó ùìéìé åúååéí ìà îñôøééí
        } while (!double.TryParse(Console.ReadLine(), out area) || area < 0);

        return Math.Sqrt(area) * 4;
    }

    static void task_21()
    {
        // àé àôùø ìäùúîù áîùúðä ùäåà ðåöø áìåìàä ìëï, öøéê ìäöäéø òìéå ìôðé ëãé ùðåëì ìäùúîù áå
        double num;
        do
        {
            Console.WriteLine("Enter the num: ");
            // ÷ìéèä ùì äîùúðä îñôø, åäâðä îî÷øé ÷öä ùì îñôø ùìéìé åúååéí ìà îñôøééí
        } while (!double.TryParse(Console.ReadLine(), out num) || num < 0);

        Console.WriteLine(Math.Pow(num, 3)); // çéùåáéí åäãôñä, ìà öøéê àåúí áäîùê åìëï ìà àùîåø àåúí
        Console.WriteLine(Math.Pow(num, 5));
        Console.WriteLine(Math.Pow(num, 7));
    }

    static void task_22()
    {
        // àé àôùø ìäùúîù áîùúðä ùäåà ðåöø áìåìàä ìëï, öøéê ìäöäéø òìéå ìôðé ëãé ùðåëì ìäùúîù áå
        int hours;
        do
        {
            Console.WriteLine("the amount of hours: ");
            // ÷ìéèä ùì äîùúðä ùòåú, åäâðä îî÷øé ÷öä ùì ùòåú ùìéìéåú åúååéí ìà îñôøééí
        } while (!int.TryParse(Console.ReadLine(), out hours) || hours < 0);

        int[] routes = { 300 + hours * 45, hours * 22 + 1000 }; // packing the routes
        foreach (int route in routes)
        {
            //ùéîåù áArray.IndexOf ëãé ìîöåà àéæä îé÷åí äòøê
            Console.WriteLine("the {0} route: {1}", Array.IndexOf(routes, route) + 1, route); //äãôñä
        }

        Console.WriteLine("the best route is route {0}, and it yeilds: {1}: ",
            Array.IndexOf(routes, Math.Max(routes[0], routes[1])) + 1, Math.Max(routes[0], routes[1])); // îöéàú äî÷ñéîåí
    }

    static double task_23()
    {
        // àé àôùø ìäùúîù áîùúðä ùäåà ðåöø áìåìàä ìëï, öøéê ìäöäéø òìéå ìôðé ëãé ùðåëì ìäùúîù áå
        double side;
        do
        {
            Console.WriteLine("Enter the cube side: ");
            // ÷ìéèä ùì äîùúðä îñôø, åäâðä îî÷øé ÷öä ùì îñôø ùìéìé åúååéí ìà îñôøééí
        } while (!double.TryParse(Console.ReadLine(), out side) || side < 0);

        return Math.Pow(side, 3);
    }

    static double[] task_24()
    {
        double raduis;
        do
        {
            Console.WriteLine("Enter the raduis: ");
            // ÷ìéèä ùì äîùúðä îñôø, åäâðä îî÷øé ÷öä ùì îñôø ùìéìé åúååéí ìà îñôøééí
        } while (!double.TryParse(Console.ReadLine(), out raduis) || raduis < 0);

        return new double[] { 2 * raduis * Math.PI, Math.Pow(raduis, 2) * Math.PI };
    }

    static double task_25()
    {
        char c = 'c';
        do
        {
            Console.Write("A or B?");
        } while (!char.TryParse(Console.ReadLine(), out c) || (char.ToUpper(c) != 'A' && char.ToUpper(c) != 'B'));

        double[] sides = new double[3];

        if (char.ToUpper(c) == 'A')
        {
            Console.WriteLine("This is task 7.a in math_class.docx");
            Console.WriteLine("Give me 2 triangle sides: ");

            for (int i = 0; i < 2; i++)
            {
                do
                {
                    Console.Write("Give me a side: ");
                } while (!double.TryParse(Console.ReadLine(), out sides[i]) || sides[i] < 0);
            }

            // Calculate and print the hypotenuse
            double hypotenuse = Math.Sqrt(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2));
            Console.WriteLine($"c = {hypotenuse}");
            return hypotenuse;
        }
        else if (char.ToUpper(c) == 'B')
        {
            Console.WriteLine("This is task 7.ב in math_class.docx");

            do
            {
                Console.Write("Give me the hypotenuse: ");
            } while (!double.TryParse(Console.ReadLine(), out sides[0]) || sides[0] < 0);

            do
            {
                Console.Write("Give me a triangle side: ");
            } while (!double.TryParse(Console.ReadLine(), out sides[1]) || sides[1] < 0);

            // Check if the sides form a valid triangle
            if (sides[0] <= sides[1])
            {
                Console.WriteLine("Invalid input. The hypotenuse must be greater than the other side.");
                return -1; // Or any other value to indicate an error
            }

            // Calculate and print the other side
            double otherSide = Math.Sqrt(Math.Pow(sides[0], 2) - Math.Pow(sides[1], 2));
            Console.WriteLine($"a = {otherSide}");
            return otherSide;
        }

        // Add a default return statement or handle the case when neither 'A' nor 'B' is selected.
        Console.WriteLine("Invalid input. Please select either A or B.");
        return -1; // Or any other value to indicate an error
    }

    static double[] task_26()
    {
        double[] prameters = new double[3];//àøéæú äôøîèøéí
        for (int i = 0; i < 3; i++) //÷éöåø 
        {
            do
            {
                Console.Write("Give me a parameter: ");
            } while (!double.TryParse(Console.ReadLine(), out prameters[i])); // îååãà ùäúååéí éäéå îñôøéí 
        }
        double[] xs = new double[2]; //àøéæú äôúøåðåú
        //x1 = -b+sqrt(b^2-4ac)/2a
        xs[0] = (-prameters[1] + Math.Sqrt(Math.Pow(prameters[1], 2) - 4 * prameters[0] * prameters[2])) / (2 * prameters[0]);
        //x2 = -b-sqrt(b^2-4ac)/2a
        xs[1] = (-prameters[1] - Math.Sqrt(Math.Pow(prameters[1], 2) - 4 * prameters[0] * prameters[2])) / (2 * prameters[0]);

        foreach (double x in xs)
        { //äãôñä
            Console.WriteLine("solution {0}: {1}", Array.IndexOf(xs, x) + 1, x);
        }

        return xs;
    }

    static void task_27()
    {
        double number;
        do
        {
            Console.Write("Give me a number you think is the soultion to this function - y = 3a^5 - 4a^3 + 10: ");
        } while (!double.TryParse(Console.ReadLine(), out number)); // îååãà ùäúååéí éäéå îñôøéí 
        //3*a^5 - 4*a^3 + 10
        double result = 3 * Math.Pow(number, 5) - 4 * Math.Pow(number, 3) + 10;
        if (result < 0) { Console.WriteLine("this point is negative"); }
        else if (result > 0) { Console.WriteLine("this point is positive"); }
        else { Console.WriteLine("{0} is a solution for y = 3a^5 - 4a^3 + 10", result); }
    }

    static void task_28()
    {
        char c;
        do
        {
            Console.Write("A or B?");
        } while (!char.TryParse(Console.ReadLine(), out c) && (c == 'A' || c == 'B' || c == 'a' || c == 'b')); // îååãà ùäúååéí éäéå à' àå á'.
        if (c == 'A' || c == 'a')
        {
            Console.WriteLine("this is task 10.a in math_class.docx");
            double[] numbers = new double[3];//àøéæú äôøîèøéí
            for (int i = 0; i < 3; i++) //÷éöåø 
            {
                do
                {
                    Console.Write("Give me a number: ");
                } while (!double.TryParse(Console.ReadLine(), out numbers[i])); // îååãà ùäúååéí éäéå îñôøéí 
            }

            Console.WriteLine(Math.Min(numbers[0], Math.Min(numbers[1], numbers[2])));
        }
        else if (c == 'B' || c == 'b')
        {
            Console.WriteLine("this is task 10.b in math_class.docx");
            // äééúé òåùä àçøú àí àáì æä äéä îàôùø ìãøê ùìà îçæéø òøê
            double[] numbers = new double[5];//àøéæú äôøîèøéí
            for (int i = 0; i < 5; i++) //÷éöåø 
            {
                do
                {
                    Console.Write("Give me a number: ");
                } while (!double.TryParse(Console.ReadLine(), out numbers[i])); // îååãà ùäúååéí éäéå îñôøéí 
            }

            Console.WriteLine(Math.Max(numbers[0], Math.Max(numbers[1], Math.Max(numbers[2], Math.Max(numbers[3], numbers[4])))));
        }

    }

    static void task_29()
    {
        char c = 'c';
        do
        {
            Console.Write("A or B?");
            Console.WriteLine(c == 'A' || c == 'B' || c == 'a' || c == 'b');
        } while (!char.TryParse(Console.ReadLine(), out c) && (c == 'A' || c == 'B' || c == 'a' || c == 'b')); // îååãà ùäúååéí éäéå à' àå á'.
        if (c == 'A' || c == 'a')
        {
            Console.WriteLine("this is task 11.à in math_class.docx");
            double[] grades = { 0, 49, 64, 81, 100 }; //àøéæú äòøëéí
            for (int i = 0; i < grades.Length; i++) //÷éöåø
            {
                grades[i] = 10 * Math.Sqrt(grades[i]);
                Console.WriteLine("the grade's factor: {0}", grades[i]);
            }
        }
        else if (c == 'B' || c == 'b')
        {
            Console.WriteLine("this is task 11.á in math_class.docx");
            double grade;
            do
            {
                Console.Write("Give me a number: ");
            } while (!double.TryParse(Console.ReadLine(), out grade) || !(0 <= grade && grade <= 100)); // îååãà ùäúååéí éäéå îñôøéí åáéï 0 òã 100
            Console.WriteLine("the grade's factor: {0}", 10 * Math.Sqrt(grade));
        }

    }

    static void task_30()
    {
        int[] numbers = new int[2]; //àøéæú îùúðéí
        for (int i = 0; i < 2; i++) // øéöä òìéäí
        {
            do
            {
                Console.Write("Give me a number: ");
            } while (!int.TryParse(Console.ReadLine(), out numbers[i]));//ווידוי שהוא חיובי
        }
        if (Math.Max(numbers[0], numbers[1]) == numbers[0])
        {
            Console.WriteLine("acending order: {0}{1}", numbers[1], numbers[0]); // קטן - גדול
            Console.WriteLine("decending order: {0}{1}", numbers[0], numbers[1]); // גדול - קטן
        }
        else
        {
            Console.WriteLine("acending order: {0}{1}", numbers[0], numbers[1]); // קטן - גדול
            Console.WriteLine("decending order: {0}{1}", numbers[1], numbers[0]); // גדול - קטן
        }
        Console.WriteLine(Math.Abs(numbers[0] - numbers[1]));
    }

    static void task_31()
    {
        int width, length;
        do
        {
            Console.Write("Give me width: ");
        } while (!int.TryParse(Console.ReadLine(), out width) || width <= 0);

        do
        {
            Console.Write("Give me length: ");
        } while (!int.TryParse(Console.ReadLine(), out length) || length <= 0);

        Console.WriteLine("area: {0}, paremter: {1}", width * length, 2 * (width + length));
        if (width != length)
        { //יותר מקרים שהוא לא ריבוע
            Console.WriteLine("it's not a squre, his sides diffrene is: {0}", Math.Abs(width - length));
        }
        else { Console.WriteLine("it's a squre!"); }

    }
    static void task_32()
    {
        int starting_height_position, ending_height_position;
        do
        {
            Console.Write("Give me the starting height: ");
        } while (!int.TryParse(Console.ReadLine(), out starting_height_position));// מוודא שהם מספרים
        do
        {
            Console.Write("Give me the ending height: ");
        } while (!int.TryParse(Console.ReadLine(), out ending_height_position));// מוודא שהם מספרים

        if (starting_height_position > ending_height_position) { Console.WriteLine("decending"); }
        else if (starting_height_position == ending_height_position) { Console.WriteLine("didn't move"); }
        else { Console.WriteLine("acending"); }

    }

    static void task_33()
    {
        double rate, missing_time, worked_time;
        do
        {
            Console.Write("your rate: ");
        } while (!double.TryParse(Console.ReadLine(), out rate) || rate < 0); // קליטת ערך ווידוי שהוא חיובי

        do
        {
            Console.Write("the amount of hours you missed: ");
        } while (!double.TryParse(Console.ReadLine(), out missing_time) || missing_time < 0); // קליטת ערך ווידוי שהוא חיובי

        do
        {
            Console.Write("the amount of hours you worked: ");
        } while (!double.TryParse(Console.ReadLine(), out worked_time) || worked_time < 0); // קליטת ערך ווידוי שהוא חיובי

        if (missing_time < 3.5) { rate *= 1.1; }

        Console.WriteLine("worker's paycheak: {0}", rate * worked_time);
    }

    static void task_34()
    {
        long num = long.MinValue;
        int with_print = -1;
        bool flag = with_print != 0;
        while (flag)
        {
            Console.WriteLine("do you want to leave?, write 0\n" +
                "do you want the answer?, write 1\n" +
                "do you want the to look like a programer?, write 2\n");

            if (!int.TryParse(Console.ReadLine(), out with_print))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            switch (with_print)
            {
                case 0:
                    flag = false; // Exit the program
                    break;

                case 1:
                    while (!((num == 0) && ((num > 0) || (num == -5))) && num != long.MaxValue) { num++; }
                    Console.Write(num);
                    break;
                case 2:
                    while (!((num == 0) && ((num > 0) || (num == -5))) && num != long.MaxValue)
                    {
                        Console.Write(num);
                        num++;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    break;
            }
        }
    }

    static void task_35()
    {
        int sold_packs, bought_packs;
        do
        {
            Console.Write("how many choclate packs you bought? ");
        } while (!int.TryParse(Console.ReadLine(), out bought_packs) || bought_packs < 0); // קליטת ערך ווידוי שהוא חיובי

        do
        {
            Console.Write("how many choclate packs you sold? ");
        } while (!int.TryParse(Console.ReadLine(), out sold_packs) || sold_packs < 0); // קליטת ערך ווידוי שהוא חיובי

        int blance = -5 * bought_packs + sold_packs * 10;
        if (blance > 0)
        {
            Console.WriteLine("made profit of " + blance);
        }
        else
        {
            Console.WriteLine("lost " + Math.Abs(blance));
        }
    }

    static void task_36()
    {
        int[] classes = new int[3];
        for (int i = 0; i < 3; i++)
        {
            do
            {
                Console.Write("how many were in class " + (i + 1) + "? ");
            } while (!int.TryParse(Console.ReadLine(), out classes[i]) || classes[i] < 0); // קליטת ערך ווידוי שהוא חיובי
        }
        Console.WriteLine("bus amonut: " + Math.Ceiling((double)classes.Sum() / 40));
    }

    static void task_37()
    {
        string id;
        do
        {
            Console.Write("what's your id? ");
            id = Console.ReadLine();
        } while (!(id.All(char.IsNumber) && id.Length == 9)); //  קליטת ערך ווידוי שאורכו הוא 9 ולבדוק שכולם מספרים

        int speed, alowed_speed;
        do
        {
            Console.Write("what's your speed? ");
        } while (!int.TryParse(Console.ReadLine(), out speed) || speed <= 0); // קליטת ערך ווידוי שהוא לא שלילי
        do
        {
            Console.Write("what's the alowed speed? ");
        } while (!int.TryParse(Console.ReadLine(), out alowed_speed) || alowed_speed < 20); // קליטת ערך ווידוי שהוא לא שלילי

        if (speed <= alowed_speed)
        {
            Console.WriteLine("good job");
        }
        else
        {
            Console.WriteLine("ID: " + id + " amount to pay: " + (30 * Math.Abs(speed - alowed_speed)));
        }

    }

    static void task_38()
    {
        char sign;
        int[] numbers = new int[2];
        for (int i = 0; i < 2; i++)
        {
            do
            {
                Console.Write("give me a number? ");
            } while (!int.TryParse(Console.ReadLine(), out numbers[i])); // קליטת ערך
        }
        do
        {
            Console.Write("give me the sign( \'+\' or \'-\' )? ");
        } while (!char.TryParse(Console.ReadLine(), out sign) || (sign != '+' && sign != '-')); // קליטת ערך ווידוי שהוא: + או -

        if (sign == '+') { Console.WriteLine(numbers[0] + " " + sign + " " + numbers[1] + " = " + (numbers[0] + numbers[1])); }
        //- בגלל שוידאתי שלא יהיה תו שהוא לא - או +, אז אם זה לא + זה חייב להיות
        else { Console.WriteLine(numbers[0] + " " + sign + " " + numbers[1] + " = " + (numbers[0] - numbers[1])); }
    }

    static void task_39()
    {
        int[] numbers = new int[3];
        for (int i = 0; i < 3; i++)
        {
            do
            {
                Console.Write("give me a number? ");
            } while (!int.TryParse(Console.ReadLine(), out numbers[i])); // קליטת ערך
        }

        if (Math.Abs(numbers[0] - numbers[1]) == Math.Abs(numbers[1] - numbers[2])) { Console.WriteLine(numbers[0] + ", " + numbers[1] + ", " + numbers[2] + " is a mathmatic series"); }
        else { Console.WriteLine(numbers[0] + ", " + numbers[1] + ", " + numbers[2] + " is a not mathmatic series"); }
    }

    static void task_40()
    {
        int num;
        do
        {
            Console.WriteLine("Enter a 3 digit num: ");
        } while (!int.TryParse(Console.ReadLine(), out num) || num < 0 || num.ToString().Length != 3); //מוודא שיש רק 3 ספרות
        if (num % 10 == num / 100) { Console.WriteLine("is a palandrom"); }
        else { Console.WriteLine("is not a palandrom"); }
    }

    static void task_41()
    {
        int right_answers_num, grade = 0;
        do
        {
            Console.WriteLine("how many right answers? ");
        } while (!int.TryParse(Console.ReadLine(), out right_answers_num) || right_answers_num < 0 || right_answers_num > 14); //מוודא שזה מספר חיובי
        if (right_answers_num <= 10)
        {//אם הוא קטן או שווה ל10 אז צריך לתת לו 8 על כל 1
            grade = 8 * right_answers_num;
        }
        else
        { //אחרת תוסיף לו את הנקודות של 10*8 ואת כמות הנקודות של שאר השאלות(כמות כל התשובות הנכונות-האלו שהחשבנו(10) )*5
            grade = 80 + 5 * (right_answers_num - 10);
        }
        Console.WriteLine("final grade: " + grade);
    }

    static void task_42()
    {
        int num;
        do
        {
            Console.WriteLine("Enter a 2 digit num: ");
        } while (!int.TryParse(Console.ReadLine(), out num) || num < 0 || num.ToString().Length != 2); // לוודא שדו ספרתי חיובי
        if (num % 2 == 0) { Console.WriteLine("new number: " + (num % 10 + 1 + 10 * (((num - (num % 10)) / 10) + 1))); }
        else { Console.WriteLine("new number: " + (num % 10 - 1 + 10 * (((num - (num % 10)) / 10) - 1))); }
        /*
        //תנאי מורכב
        if (num % 10 == 0 || num % 10 == 2 || num % 10 == 4 || num % 10 == 6 || num % 10 == 8) { Console.WriteLine("new number: " + (num % 10 + 1 + 10 * (((num - (num % 10)) / 10) + 1))); }
        else { Console.WriteLine("new number: " + (num % 10 - 1 + 10 * (((num - (num % 10)) / 10) - 1))); }
        */
    }

    static void task_43()
    {
        double price;
        do
        {
            Console.WriteLine("give me a price for a week: ");
        } while (!double.TryParse(Console.ReadLine(), out price)); // קולט את המחיר מטיפוס double - מוודא שהוא לא תו ולא null
        if (price < 150)
        {
            Console.WriteLine("great price!");
        }
        else
        {
            if (price >= 150 && price <= 250)
            {
                Console.WriteLine("normal price");
            }
            else
            {
                if (price > 250)
                {
                    Console.WriteLine("expensive but good");
                }
            }
        }
        Console.WriteLine("thanks for using david's and itata's checing Program");
    }


    static void task_44()
    {
        int p_amount;
        do
        {
            Console.WriteLine("how many, pepoule came?");
        } while (!int.TryParse(Console.ReadLine(), out p_amount)); // קולט את כמות אנשים מטיפוס int - מוודא שהוא לא תו ולא null
        if (p_amount < 10)
        {
            Console.WriteLine("heed more pepole");
        }
        else
        {
            if (p_amount < 20)
            {
                Console.WriteLine("normal sumbers");
            }
            else
            {
                if (p_amount < 30)
                {
                    Console.WriteLine("biggest numbers in place");
                }
                else
                {
                    if (p_amount > 30)
                    {
                        Console.WriteLine("you are great leaders!");
                    }
                }
            }
        }
        Console.WriteLine("youth program - to create a working and learning sosicety");
    }

    static void task_45()
    {
        int ticket_n;
        do
        {
            Console.WriteLine("how many tickets?");
        } while (!int.TryParse(Console.ReadLine(), out ticket_n)); // קולט את כמות אנשים מטיפוס int - מוודא שהוא לא תו ולא null
        int sum = 0;
        if (ticket_n > 100)
        {
            sum = ticket_n * 43;
        }
        else
        {
            sum = ticket_n * 48;
        }
        Console.WriteLine("the total price: " + sum);
    }

    static void task_46()
    {
        Console.WriteLine("give me your name: ");
        string name = Console.ReadLine();
        int count;
        do
        {
            Console.WriteLine("how many parts?");
        } while (!int.TryParse(Console.ReadLine(), out count)); // קולט את כמות אנשים מטיפוס int - מוודא שהוא לא תו ולא null
        int sum = 0;
        if (count > 8)
        {
            sum = count * 30 - 10;
        }
        else
        {
            sum = count * 30;
        }
        Console.WriteLine("your name: " + name + " the price you pay: " + sum);
    }

    static void task_47()
    {
        int[] grade_points = new int[2]; // שומר את הנקודות 10 - 11 , ניתן לראות את זה לפי הטקסטים ב:texts
        string[] texts = new string[2] { "give me the points for 10 grade: ", "give the the points for 11 grade: " };
        for (int i = 0; i < 2; i++) //מפעיל פעמיים
        {
            do
            {
                Console.WriteLine(texts[i]); //הדפסת הטקסט המתאים למי שרוצים לקלוט בסדר 10 - 11 
            } while (!int.TryParse(Console.ReadLine(), out grade_points[i]) && grade_points[i] > 0); // קליטת 2 הנקודות
            // i = 0 = grade_10, i = 1 = grade_11
        }

        if (grade_points[0] > grade_points[1]) // grade_10 > grade_11 ?
        {
            Console.WriteLine("10 won: " + grade_points[0]);
        }
        else
        {
            if (grade_points[1] > grade_points[0]) // grade_11 > grade_10 ?
            {
                Console.WriteLine("11 won: " + grade_points[1]);
            }
        }
        Console.WriteLine("diffrence: " + Math.Abs(grade_points[0] - grade_points[1])); // | grade_10 - grade_11 |
    }

    static void task_48()
    {
        int num;
        do
        {
            Console.WriteLine("give me a single digit number: ");
        } while (!int.TryParse(Console.ReadLine(), out num));

        if (num > -10 && num < 10)
        {
            Console.WriteLine(num + " is a single digit number");
        }
    }

    static void task_49()
    {
        int[] parmters = new int[2];
        string[] texts = new string[2] { "give me your expirence in years: ", "give me your age in years:" };
        for (int i = 0; i < 2; i++)
        {
            do
            {
                Console.WriteLine(texts[i]);
            } while (!int.TryParse(Console.ReadLine(), out parmters[i]));
        }

        if (parmters[0] >= 3)
        {
            if ((parmters[1] >= 35))
            {
                if (parmters[1] <= 45)
                {
                    Console.WriteLine("you passed the test!");
                    return;
                }
                Console.WriteLine("too old");
                return;
            }
            Console.WriteLine("too young");
        }
        else
        {
            Console.WriteLine("not enughth expirence");
        }
    }

    static void task_50()
    {
        int num;
        do
        {
            Console.WriteLine("give me a number for  shoshe's class count: ");
        } while (!int.TryParse(Console.ReadLine(), out num));

        if (num % 2 == 1 && num % 3 == 1 && num % 4 == 1)
        {
            Console.WriteLine(num + " can be shoshe's class count");
        }

    }

    static void task_51()
    {
        Console.WriteLine("give me the thrio(a,b,c no other order): ");
        int[] sides = new int[3];
        for (int i = 0; i < 3; i++)
        {
            do
            {
                Console.WriteLine("here: ");
            } while (!int.TryParse(Console.ReadLine(), out sides[i]));
        }

        if (sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2])
        {
            Console.WriteLine("is a pathagirian thrio");
        }
        else
        {
            Console.WriteLine("isn't a pathagirian thrio");
        }
    }

    static void task_52()
    {
        int parson_1_age, parson_2_age;
        char parson_1_gender, parson_2_gender;
        do
        {
            Console.WriteLine("parson1's age: ");
        } while (!int.TryParse(Console.ReadLine(), out parson_1_age));
        do
        {
            Console.WriteLine("parson1's gender (in F, M): ");
        } while (!char.TryParse(Console.ReadLine(), out parson_1_gender) && !(parson_1_gender == 'M' || parson_1_gender == 'F')); //מכריח להיות התווים האלו
        do
        {
            Console.WriteLine("parson2's age: ");
        } while (!int.TryParse(Console.ReadLine(), out parson_2_age));
        do
        {
            Console.WriteLine("parson2's gender (in F, M): ");
        } while (!char.TryParse(Console.ReadLine(), out parson_2_gender) && !(parson_2_gender == 'M' || parson_2_gender == 'F')); //מכריח להיות התווים האלו

        if (parson_1_gender != parson_2_gender) //יכול להיות רק 2 התווים המוגדרים
        {
            if (Math.Abs(parson_1_age - parson_2_age) <= 5)
            {
                Console.WriteLine("you fit with each other!");
                return;
            }
            else
            {
                Console.WriteLine("too big of a age gap");
                return;
            }
        }
        else { Console.WriteLine("the requesters "); }
    }

    static void task_53()
    {
        Console.WriteLine("give me the sides: ");
        double[] sides = new double[3];
        for (int i = 0; i < 3; i++)
        {
            do
            {
                Console.WriteLine("here: ");
            } while (!double.TryParse(Console.ReadLine(), out sides[i]) || sides[i] <= 0);
        }
        if (sides[0] + sides[1] >= sides[2] && sides[0] + sides[2] >= sides[1] && sides[1] + sides[2] >= sides[0])
        {
            Console.WriteLine("is a triangle");
        }
    }

    static void task_54()
    {
        Console.WriteLine("give me 2 numbers: ");
        int[] numbers = new int[2];
        for (int i = 0; i < 2; i++)
        {
            do
            {
                Console.WriteLine("here: ");
            } while (!int.TryParse(Console.ReadLine(), out numbers[i]));
        }
        if (numbers[0] < numbers[1])// האם מספר 1 קטן יותר?
        {
            Console.WriteLine(numbers[1] + " is bigger then: " + numbers[0]);
            Console.WriteLine(numbers[0] + ", " + numbers[1]);
        }
        else if (numbers[1] < numbers[0]) //האם מספר 2 קטן יותר?
        {
            Console.WriteLine(numbers[0] + " is bigger then: " + numbers[1]);
            Console.WriteLine(numbers[1] + ", " + numbers[0]);
        }
        else //אם לא גדול או לא קטן חייב להיות שווה
        {
            Console.WriteLine(numbers[1] + " is: " + numbers[0]);
        }
    }

    static void task_55()
    {
        double amount;
        do
        {
            Console.WriteLine("how much do you have in the bank acount yossi? ");
        } while (!double.TryParse(Console.ReadLine(), out amount));

        if (amount > 0)
        {
            Console.WriteLine("you have enguth money");
        }
        else if (amount < 0)
        {
            Console.WriteLine("you are in debt");
        }
        else //אם לא גדול או לא קטן חייב להיות שווה ל0
        {
            Console.WriteLine("you are perfectly balanced");
        }
    }

    static void task_56()
    {
        int[] grades = new int[2];
        string[] texts = new string[2] { "give me your pcicomatry grade: ", "give me your bagrot grade:" };
        for (int i = 0; i < 2; i++)
        {
            do
            {
                Console.WriteLine(texts[i]);
            } while (!int.TryParse(Console.ReadLine(), out grades[i]));
        }
        if (grades[0] >= 600)
        {
            if (grades[1] >= 90)
            {
                Console.WriteLine("you're a fit");
            }
            else
            {
                Console.WriteLine("good pcicomatry grade but not good engoth in bagrot");
            }
        }
        else if (grades[1] >= 90)
        {
            Console.WriteLine("good bagrot grade but not good engoth in pcicomatry, do it again");
        }
        else { Console.WriteLine("you aren't a fit"); }
    }

    static void task_57()
    {
        int[] ages = new int[2];
        char[] genders = new char[2];
        char[] groups = new char[2];
        for (int i = 0; i < 2; i++) //בודק ושומר את הערכים לשניהם
        {
            do
            {
                Console.WriteLine("age of player " + (i + 1) + ": ");
            } while (!int.TryParse(Console.ReadLine(), out ages[i]));
            do
            {
                Console.WriteLine("gender of player " + (i + 1) + ": ");
            } while (!char.TryParse(Console.ReadLine(), out genders[i]) || !(genders[i] == 'M' || genders[i] == 'F'));
            //מההתחלה עד פה שומר ערכים

            if (ages[i] < 8)
            {
                Console.WriteLine("you'er ( " + i + " )in group A");
                groups[i] = 'A';
            }
            else if (ages[i] >= 8 && ages[i] < 13)
            {
                Console.WriteLine("you'er ( " + i + " )in group B");
                groups[i] = 'B';
            }
            else if (ages[i] >= 13 && ages[i] < 17)
            {
                Console.WriteLine("you'er ( " + i + " ) in group C");
                groups[i] = 'C';
            }
            else
            {
                Console.WriteLine("you'er ( " + i + " ) to old to fight");
            }
            //חילוק לקבוצות
        }
        if (groups[0] == groups[1])
        {
            if (genders[0] == genders[1])
            {
                Console.WriteLine("you can fight!");
            }
            else { Console.WriteLine("you can't fight becouse of gender"); }
        }
        else { Console.WriteLine("you can't fight becouse of age group"); }

    }

    static void task_58()
    {
        int max = int.MinValue;
        int[] bets = new int[4];
        for (int i = 0; i < 4; i++) //בודק ושומר את הערכים לשניהם
        {
            do
            {
                Console.WriteLine("bet number " + (i + 1) + ": ");
            } while (!int.TryParse(Console.ReadLine(), out bets[i]));

            max = Math.Max(max, bets[i]);
        }

        Console.WriteLine("max bet is: " + max);
    }


    static void task_59()
    {
        int zela1 = 3, zela2 = 3, zela3 = 3;
        if (zela1 == zela2 && zela1 == zela3)
        {
            Console.WriteLine("equilateral triangle");
        }
        else if (zela1 == zela2 || zela2 == zela3 || zela1 == zela3)
        {
            Console.WriteLine("icocles triangle");
        }
        else { Console.WriteLine("diffrent sides triangles"); }
    }

    static void task_60()
    {
        /*להחליף במציאת מינמלי מקסימלי, ואז השונה בניהם
         * int max = Math.Max(niv_points, Math.Max(dana_points, naama_points);
         * int min = Math.Min(niv_points, Math.Min(dana_points, naama_points); 
         * והשוואה לערכי מקור למציאת מקום ראשון
         */
        Console.WriteLine("niv's, and then dana's, and then naama's points:");
        int niv_points = int.Parse(Console.ReadLine());
        int dana_points = int.Parse(Console.ReadLine());
        int naama_points = int.Parse(Console.ReadLine());

        if (niv_points == Math.Max(niv_points, Math.Max(dana_points, naama_points))) // בודק האם ניב ראשון
        {
            Console.WriteLine("first place niv!!!\n with " + niv_points + " points!");
            if (dana_points == Math.Max(dana_points, naama_points)) // בודק מי מקום שני מבין הנשארים
            {
                Console.WriteLine("secound place dana!!!\n with " + dana_points + " points!");
                Console.WriteLine("third place naama!!!\n with " + naama_points + " points!");
            }
            else
            {
                Console.WriteLine("secound place namaa!!!\n with " + naama_points + " points!");
                Console.WriteLine("third place dana!!!\n with " + dana_points + " points!");
            }
        }
        else if (dana_points == Math.Max(niv_points, Math.Max(dana_points, naama_points))) // בודק האם לא ניב האם דנה
        {
            Console.WriteLine("first place danna!!!\n with " + dana_points + " points!");
            if (niv_points == Math.Max(niv_points, naama_points))// בודק מי מקום שני מבין הנשארים
            {
                Console.WriteLine("secound place niv!!!\n with " + niv_points + " points!");
                Console.WriteLine("third place naama!!!\n with " + naama_points + " points!");
            }
            else
            {
                Console.WriteLine("secound place namaa!!!\n with " + naama_points + " points!");
                Console.WriteLine("third place niv!!!\n with " + niv_points + " points!");
            }
        }
        else //בהכרח נעמה
        {
            Console.WriteLine("first place naama!!!\n with " + naama_points + " points!");
            if (niv_points == Math.Max(niv_points, dana_points))// בודק מי מקום שני מבין הנשארים
            {
                Console.WriteLine("secound place niv!!!\n with " + niv_points + " points!");
                Console.WriteLine("third place dana!!!\n with " + dana_points + " points!");
            }
            else
            {
                Console.WriteLine("secound place dana!!!\n with " + dana_points + " points!");
                Console.WriteLine("third place niv!!!\n with " + niv_points + " points!");
            }
        }

    }

    static void task_61()
    {
        double[] lengths = new double[3];
        for (int i = 0; i < 3; i++) //בודק ושומר את הערכים לאורכי הצלעות
        {
            do
            {
                Console.WriteLine("length" + (i + 1) + ": ");
            } while (!double.TryParse(Console.ReadLine(), out lengths[i]) || lengths[i] < 0);
        }

        double p, a;
        p = 0.5 * lengths.Sum(); //סוכם את כל המשתנים, שכום אורך הצלעות זה ההיקף
        a = Math.Sqrt(p * (p - lengths[0]) * (p - lengths[1]) * (p - lengths[2])); //
        Console.WriteLine("paramter: " + (p * 2) + " area: " + a);
    }

    static void task_62()
    {
        double money;
        do
        {
            Console.WriteLine("money amount(up to 4 digits after the dot): ");
        } while (!double.TryParse(Console.ReadLine(), out money) || money < 0);
        int shekels;
        double agorot;
        shekels = (int)money;
        agorot = (money % 1) * 100;
        Console.WriteLine(shekels + " shekels and " + agorot + " agorot.");
    }

    static void task_63()
    {
        int num;
        do
        {
            Console.WriteLine("number: ");
        } while (!int.TryParse(Console.ReadLine(), out num) || !(num > 0 && num.ToString().Length == 3) && !(num < 0 && num.ToString().Length == 4));
        // כל עוד זה מספר, שכאשר לא (חיובי וארוכו במחרוזת 3), ולא (שלילי ואורכו במחרוזת 4)

        if (Math.Pow(num % 10, 3) + Math.Pow((num / 10) % 10, 3) + Math.Pow(num / 100, 3) == num)
        {
            Console.WriteLine("a perfect number.");
        }
        else
        {
            Console.WriteLine("not a perfect number.");
        }
    }

    static void task_64()
    {
        double grade;
        do
        {
            Console.WriteLine("grade: ");
        } while (!double.TryParse(Console.ReadLine(), out grade) || grade < 0);
        int rounded_garde = (int)Math.Round(grade);
        Console.WriteLine("rounded_garde: " + rounded_garde + " reamin: " + Math.Round(grade - rounded_garde, 2));
    }

    static void task_65()
    {
        double num;
        do
        {
            Console.WriteLine("num: ");
        } while (!double.TryParse(Console.ReadLine(), out num) || num < 0);
        Console.WriteLine(Math.Round(num, 1));
    }

    static void task_66()
    {
        for (char c = 'a'; c <= 'z'; c += (char)2)
        {
            Console.WriteLine(c);
        }
    }
    static void task_67()
    {
        for (int i = 5; i <= 100; i += 5)
        {
            Console.WriteLine(i);
        }
    }

    static void task_68()
    {
        double current_weight, wanted_weight, weight_to_lose;
        string name;
        for(int i = 1; i <= 34; i++)
        {
            Console.WriteLine("name: ");
            name = Console.ReadLine();
            do
            {
                Console.WriteLine("current weight: ");
            } while (!double.TryParse(Console.ReadLine(), out current_weight) || current_weight < 0); //קליטת משקל נוכחי וודוי שחיובי ומספר
            do
            {
                Console.WriteLine("wanted weight: ");
            } while (!double.TryParse(Console.ReadLine(), out wanted_weight) || wanted_weight < 0 || current_weight < wanted_weight);//קליטת משקל רצוי וודוי שחיובי ומספר, וקטן ממשקל נוכחי
            weight_to_lose = (current_weight - wanted_weight);
            Console.WriteLine("hey " + name + ", so you want to lose " + weight_to_lose + "kg.\n let me check...");
            if(weight_to_lose > current_weight * 0.12){
                Console.WriteLine("thats unhealthy, you must set a smaller goal.");
            }
        }
    }

    static void task_69()
    {
        int num;
        int[] digits;
        for(int i = 1; i <= 50; i++)
        {
            do{
                Console.WriteLine("num: ");
            } while (!int.TryParse(Console.ReadLine(), out num) || !(num > 0 && num.ToString().Length == 3) && !(num < 0 && num.ToString().Length == 4));

            digits = Main_Menu.digit_splitters(num); //מחזיר מערך של ספרות, 1- במקום הראשון אם שלילי
            if (digits[0] == -1) { //-מעלים את המיקום הראשון של 1
                digits[0] = digits[1];
                digits[1] = digits[2];
                digits[2] = digits[3];
            }

            if(digits[0] == digits[1] && digits[1] == digits[2])
            {
                Console.WriteLine(num);
            }
        }
    }

    static void task_70()
    {
        Console.WriteLine("task 12.a in book 1 page 117 best viersion is task 12.b, so this i it:");
        int starting_num, ending_num;
        do
        {
            Console.WriteLine("first num: ");
        } while (!int.TryParse(Console.ReadLine(), out starting_num));
        do
        {
            Console.WriteLine("second num: ");
        } while (!int.TryParse(Console.ReadLine(), out ending_num) || !(ending_num > starting_num) ); //מוודא שמספר סופי גדול מההתחלתי
        for (int i = starting_num+1; i <= ending_num; i++) { Console.WriteLine(i); }
    }

    static void task_71()
    {
        int num;
        int[] digits;
        for (int i = 0; i < 25; i++)
        {
            do
            {
                Console.WriteLine("num: ");
            } while (!int.TryParse(Console.ReadLine(), out num) || !(num > 0 && num.ToString().Length == 2) && !(num < 0 && num.ToString().Length == 3));

            digits = Main_Menu.digit_splitters(num);
            if (digits[0] % 2 == 0 && digits[1] % 2 == 0)
            {
                Console.WriteLine("both even");
            }
            else if (digits[0] % 2 == 1 && digits[1] % 2 == 1)
            {
                Console.WriteLine("both odd");
            }
            else
            {
                Console.WriteLine("one odd and one even");
            }
        }
    }

    static void task_72()
    {
        int num;
        do
        {
            Console.WriteLine("num: ");
        } while (!int.TryParse(Console.ReadLine(), out num) || num < 10 || num > 20);
        int rnd_num;
        Random rnd = new Random();
        for (int i = 0; i < 30; i++)
        {
            rnd_num = rnd.Next(10,21);
            if(Math.Abs(rnd_num - num) <= 4 )
            {
                Console.WriteLine(rnd_num);
            }
        }
    }

    static void task_73()
    {
        char c = 'c';
        do
        {
            Console.Write("A or B?");
        } while (!char.TryParse(Console.ReadLine(), out c) || (char.ToUpper(c) != 'A' && char.ToUpper(c) != 'B'));

        if (char.ToUpper(c) == 'A')
        {
            Console.WriteLine("This is task 15.a in page 118 in book 1");
            int number_of_numbers, num;
            do
            {
                Console.WriteLine("number of numbers: ");
            } while (!int.TryParse(Console.ReadLine(), out number_of_numbers) || number_of_numbers < 0);
            for (int i = 0; i < number_of_numbers; i++)
            {
                do
                {
                    Console.WriteLine("number: ");
                } while (!int.TryParse(Console.ReadLine(), out num) || num < 0 || num.ToString().Length != 2);
                Console.WriteLine(num);
                Console.WriteLine(Main_Menu.digit_splitters(num).Sum());
            }

        }
        else if (char.ToUpper(c) == 'B')
        {
            Console.WriteLine("This is task 15.b in page 118 in book 1");
            int number_of_numbers, num;
            int[] digits;
            do
            {
                Console.WriteLine("number of numbers: ");
            } while (!int.TryParse(Console.ReadLine(), out number_of_numbers) || number_of_numbers < 0);
            for (int i = 0; i < number_of_numbers; i++)
            {
                do
                {
                    Console.WriteLine("number: ");
                } while (!int.TryParse(Console.ReadLine(), out num) || num < 0 || num.ToString().Length != 2);
                digits = Main_Menu.digit_splitters(num);
                if (digits[0] != digits[1])
                {
                    Console.WriteLine(num);
                    Console.WriteLine(digits.Sum());
                }
            }
        }
    }

    static void task_74()
    {
        int num1, num2;
        for (int i = 1; i <= 35; i++)
        {
            do
            {
                Console.WriteLine("first num: ");
            } while (!int.TryParse(Console.ReadLine(), out num1)); //קליטת מספר ראשון
            do
            {
                Console.WriteLine("secound num: ");
            } while (!int.TryParse(Console.ReadLine(), out num2) || num1 == num2);//קליטת מספר שני ווידאוי שהם שונים (כל עוד שווים תקלוט אחר)
            if (num2 < num1)
            {
                Console.WriteLine((num2+1) + "," + (num1-1));
            }
            else //כי לא יכולים להיות שווים אז נשאר רק: num1 < num2
            {
                Console.WriteLine((num1 + 1) + "," + (num2 - 1));
            }
        }
    }

    static void task_75()
    {
        double math_g, pysics_g, computer_sience_g, avg;
        for (int i = 1; i <= 58; i++)
        {
            do
            {
                Console.WriteLine("math grade: ");
            } while (!double.TryParse(Console.ReadLine(), out math_g) || math_g < 0 || math_g > 100); //קולט ציון ומוודא שבתחום של ציון 
            do
            {
                Console.WriteLine("pysics grade: ");
            } while (!double.TryParse(Console.ReadLine(), out pysics_g) || pysics_g < 0 || pysics_g > 100); //קולט ציון ומוודא שבתחום של ציון 
            do
            {
                Console.WriteLine("computer_sience grade: ");
            } while (!double.TryParse(Console.ReadLine(), out computer_sience_g) || computer_sience_g < 0 || computer_sience_g > 100); //קולט ציון ומוודא שבתחום של ציון 

            avg = (computer_sience_g + pysics_g + math_g) / 3;
            if (avg > 92 && math_g > 90 && pysics_g > 90  && computer_sience_g > 90)
            {
                Console.WriteLine("student " + i + " is in stage 2 and his avgrage is: " + avg);
            }
        }

    }

    static void task_76()
    {
        int goal_sum;
        for (int i = 0; i < 20; i++)
        {
            do
            {
                Console.WriteLine("the sum of goals you did in 3 last games: ");
            } while (!int.TryParse(Console.ReadLine(), out goal_sum) || goal_sum < 0); //קליטת סכום השערים שעה ב3 המספרים ווידוי שחיובי

            Console.WriteLine("player " + i + "has an avrage of " + (goal_sum/3) + "goals in 3 last games.");
            if (goal_sum == 0)
            {
                Console.WriteLine("not scores.");
            }
            else if (goal_sum >= 5) //בודק אם הif יוצא false 
            {
                Console.WriteLine("great player.");
            }
        }
    }

    static void task_77()
    {
        List<int> currect_days = new List<int>(); //עשיתי על מנת שהמספרי הימים הנכונים יוכלו להיות מודפסים ביחד בסוף
        int temparure, last_day_temparure = 0;
        for (int day = 1; day <= 7; day++, last_day_temparure = temparure)
        {
            do
            {
                Console.WriteLine("temparure today: ");
            } while (!int.TryParse(Console.ReadLine(), out temparure)); //קולט את הטמפרטורה

            if (temparure > last_day_temparure && day > 1) //האם חם יותר ואתה לא באיטרציה הראשונה?
            {
                currect_days.Add(day); // שומר את מספרי הימים כדי להדפיס את כולם בסוף ביחד
            }
        }

        //מדפיס בסטייל:
        if (currect_days.Count > 0) // מוודא שיש ימים
        {
            // מדפיס את כולם חוץ מהאחרון עם פסיקים בניהם
            Console.Write(string.Join(", ", currect_days.Take(currect_days.Count - 1)));
            if (currect_days.Count > 1) { Console.Write(", "); } //מוסיף פסיק אם יש יותר מיום אחד
            // מדפיס את האחרון עם נקודה
            Console.WriteLine(currect_days.Last() + ". ");
        }

    }

    static void task_78()
    {
        int count = 0;
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("tmperture today: ");
            int tmper = int.Parse(Console.ReadLine());

            if(tmper > 16)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }

    static void task_79()
    {
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine("positive houle humber: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }

    static void task_80()
    {
        int count = 0;
        for (int i = 1;i <= 300; i++)
        {
            if (Math.Sqrt(i) % 1 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }

    static void task_81()
    {
        int count = 0;
        for (int i = 0; i < 25; i++)
        {
            Console.WriteLine("write 3 numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int avg = (num3 + num2 + num1) / 3;

            Console.WriteLine("avg: " + avg);
            if (avg > 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }

    static void task_82()
    {
        int g_count = 0, m_count = 0, f_count = 0;
        for(int i = 0; i < 20; i++)
        {
            Console.WriteLine("the 2 grades: ");
            int grade1 = int.Parse(Console.ReadLine());
            int grade2 = int.Parse(Console.ReadLine());

            if(grade1 == -1 || grade2 == -1) //you have a missed job
            {
                if(grade1 != -1 || grade2 != -1) //you have a missed job + good job
                {
                    m_count++;
                }
                else //you have a missed 2 jobs
                {
                    f_count++;
                }
            }
            else //no other option then not -1 && not -1
            {
                g_count++;
            }
        }

        Console.WriteLine("there are " + g_count + " good students");
        Console.WriteLine("there are " + m_count + " mediocre students");
        Console.WriteLine("there are " + f_count + " bad students");
    }

    static void task_83()
    {
        Console.WriteLine("a houle positive number: ");
        int num = int.Parse(Console.ReadLine());
        int passed = 0;
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine("write the amount of sign mistakes: ");
            int sign_mistakes = int.Parse(Console.ReadLine());
            Console.WriteLine("write the amount of other mistakes: ");
            int other_mistakes = int.Parse(Console.ReadLine());

            if(sign_mistakes == 0 && other_mistakes <= 3)
            {
                passed++;
            }
        }
        Console.WriteLine(passed);
    }

    static void task_84()
    {
        int guide_num, age1_num = 0, age2_num = 0;
        double age; //kids could be stupid and want 12.3 or something
        for (int i = 1; i <= 11; i++)
        {
            Console.WriteLine("kid number " + i + "'s age: ");
            age = double.Parse(Console.ReadLine());
            if (age > 8 && age <= 11)
            {
                age1_num++;
            }
            else //no other groups
            {
                age2_num++;
            }
        }

        //convert to type for func, and back to int so if there is reamin add one
        guide_num = (int)Math.Ceiling((decimal)age1_num / 7) + (int)Math.Ceiling((decimal)age2_num / 4);
        // same as:
        /*
            guide_num = age1_num / 7;
            if (age1_num % 7 != 0)
            {
                guide_num++;
            }
            guide_num = guide_num + age2_num / 4;
            if (age2_num % 4 != 0)
            {
                guide_num++;
            }
        */

        Console.WriteLine("amount of kids in group 1: " + age1_num);
        Console.WriteLine("amount of kids in group 2: " + age2_num);
        Console.WriteLine("the amount of needed guides are: " + guide_num);
    }

    static void task_85()
    {
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("donation: ");
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }

    static void task_86()
    {
        int sum = 0;
        for (int i = 0; i < 30; i++)
        {
            Console.WriteLine("number: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0 && (num >= 10 && num <= 99) )
            {
                sum += num;
            }
        }
        Console.WriteLine(sum);
    }

    static void task_87()
    {
        Console.WriteLine("number: ");
        int num = int.Parse(Console.ReadLine());
        int answer = 1; //1 to get an answer not 0
        for (int i = 2; i <= num; i++) //1 can be skipped
        {
            answer *= i;
        }
        Console.WriteLine(answer);
    }

    static void task_88()
    {
        Console.WriteLine("a whole positive number: ");
        int n = int.Parse(Console.ReadLine());
        int sum_odds = 0, sum_evens = 0;
        //way 0
        //n+1 to incolde n
        for (int i = 0; i < n + 1; i++)
        {
            if (i % 2 == 0)
            {
                sum_evens += i;
            }
            else
            {
                sum_odds += i;
            }
        }
        Console.WriteLine("odds sum: " + sum_odds);
        Console.WriteLine("evens sum: " + sum_evens);
        //way 1
        sum_odds = 0;
        sum_evens = 0;

        //sum = ? = sumer
        //sum_odds = sum - sum_evens;
        Console.WriteLine("odds sum: " + sum_odds);
        Console.WriteLine("evens sum: " + sum_evens);
        //way 2
        sum_odds = 0;
        sum_evens = 0;
        //n+1 to incolde n
        for (int i = 0; i < n + 1; i += 2)
        {
            if (i % 2 == 0)
            {
                sum_evens += i;
            }
        }
        //sum = ?
        //sum_odds = sum - sum_evens;
        Console.WriteLine("odds sum: " + sum_odds);
        Console.WriteLine("evens sum: " + sum_evens);
        //way 3
        /*
         * num of piars * ( pair value + 1)
         * (n / 2)*1 = חציון - לכן יש + 1 בסוגריים
         * (n / 2) * (n + 1) = sum of nums up to n
         * n*n/4 = sum of odds num up to n when n is even
         * n*n/4 + n/2 = sum of evens num up to n when n is even
         */
        if (n % 2 == 1) { n++; } //if n odd makes n even to fix cocualtion
        sum_odds = n * n / 4;
        sum_evens = n * n / 4 + n / 2;
        Console.WriteLine("odds sum: " + sum_odds);
        Console.WriteLine("evens sum: " + sum_evens);
    }

    static void task_89()
    {
        Console.WriteLine("starting number: ");
        int start_n = int.Parse(Console.ReadLine());
        Console.WriteLine("ending number: ");
        int end_n = int.Parse(Console.ReadLine());
        int sum = 0, molipication = 1; // 1 to get non 0 answer
        for (int i = start_n; i <= end_n; i++)
        {
            sum += i;
            molipication *= i;
        }
        Console.WriteLine("sum: " + sum);
        Console.WriteLine("molipication: " + molipication);
    }

    static void task_90()
    {
        int tico_counter = 0, total_roey_points = 0, total_tal_points = 0, roey_wins = 0,tal_wins = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("roey's points in game number " + i + ": ");
            int roey_points = int.Parse(Console.ReadLine());
            Console.WriteLine("tal's points in game number " + i + ": ");
            int tal_points = int.Parse(Console.ReadLine());

            if (roey_points > tal_points)
            {
                Console.WriteLine("roey won! \nfor this (" + i + ") game.");
                roey_wins++;
            }
            else if(tal_points > roey_points)
            {
                Console.WriteLine("tal won! \nfor this (" + i + ") game.");
                tal_wins++;
            }
            else
            {
                tico_counter++;
            }
            total_roey_points += roey_points;
            total_tal_points += tal_points;
        }

        if (total_roey_points > total_tal_points)
        {
            Console.WriteLine("roey won! \noverall.");
        }
        else if (total_tal_points > total_roey_points)
        {
            Console.WriteLine("tal won! \noverall.");
        }

        Console.WriteLine("roey won " + roey_wins + " games overall.");
        Console.WriteLine("tal won " + tal_wins + " games overall.");
        Console.WriteLine("tico ampunt: " + tico_counter);

    }

    static void task_91()
    {
        Console.WriteLine("base: ");
        int base1 = int.Parse(Console.ReadLine());
        Console.WriteLine("power: ");
        int power = int.Parse(Console.ReadLine());

        int answer = 1;
        for(int i = 0; i < power; i++)
        {
            answer *= base1;
        }
        Console.WriteLine(answer);
    }

    static void task_92()
    {
        Console.WriteLine("num: ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        string expression = num + " = ";
        for (int i = 1; i < num; i++)// < so num is unincluded
        {
            if(num % i == 0)
            {
                sum += i;
                if (i != num / 2)
                {
                    expression += i + " + ";
                }
                else
                {
                    expression += i;
                }
            }
        }
        if (sum == num){
            Console.WriteLine("it's a perfect number");
            Console.WriteLine(expression);
        }
        else {
            Console.WriteLine("it isn't a perfect number");
        }
        
    }

    static void task_93()
    {
        int corect_i = 0, max = 0;
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine("hight of student number " + i + ": ");
            int num = int.Parse(Console.ReadLine());

            if (num > max)
            {
                max = num;
                corect_i = i;
            }
        }
        Console.WriteLine("student number " + corect_i + " got max hight: " + max);
    }

    static void task_94()
    {
        double smallest_positive = double.MaxValue, biggest_negative = double.MinValue;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("num: ");
            double num = double.Parse(Console.ReadLine());

            if (num > 0 && num < smallest_positive)
            {
                smallest_positive = num;
            }
            if(num < 0 && num > biggest_negative)
            {
                biggest_negative = num;
            }
        }

        Console.WriteLine("smallest positive: " + smallest_positive);
        Console.WriteLine("biggest negative: " + biggest_negative);
    }

    static void task_95()
    {
        int bigger, smallest = int.MaxValue, corect_i = 0;
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("first num: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("second num: ");
            int num2 = int.Parse(Console.ReadLine());

            bigger = Math.Max(num1, num2);
            if (bigger < smallest)
            {
                smallest = bigger;
                corect_i = i;
            }
        }
        Console.WriteLine("smallest of the biggers: " + smallest + " is in pair number " + corect_i);
    }

    static void task_96()
    {
        Console.WriteLine("number of cars: ");
        int num = int.Parse(Console.ReadLine());
        double winner_t = double.MaxValue, secound_place_t = double.MaxValue;

        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine("time to finish the race: ");
            double time = double.Parse(Console.ReadLine());

            if (Math.Min(winner_t, time) < winner_t)
            {
                secound_place_t = winner_t;
                winner_t = Math.Min(winner_t, time);
            }
            else if (secound_place_t > time)
            {
                secound_place_t = time;
            }
        }
        Console.WriteLine("winner time: " + winner_t);
        Console.WriteLine("second place: " + secound_place_t);
    }

    static void task_97()
    {
        Console.WriteLine("a houle positive number: ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0; // for article b
        for (int i = 2; i <= num; i += 2, sum += i) // for article b, מתרחש בסוף
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("sum of numbers:" + sum); // for article b
    }

    static void task_98()
    {
        int count = 0;
        for (int i = 0; i <= 50; i++)
        {
            Console.WriteLine("a three digit number:");
            int num = int.Parse(Console.ReadLine());

            if (num % 10 == (num / 10) % 10 || num % 10 == num / 100 || num / 100 == (num / 10) % 10)
            {
                Console.WriteLine(num);
                count++;
            }
        }
    }

    static void task_99()
    {
        for (int num = 100; num <= 999; num++)
        {
            if (num % (num % 10 + (num / 10) % 10 + num / 100) == 0)
            {
                Console.WriteLine(num);
            }
        }
    }

    static void task_100()
    {
        int sum = 0;
        Console.WriteLine("a houle positive number: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine("sum of numbers 1 to " + n + "is: " + sum);
    }

    static void task_101()
    {
        int sum = 0, num;
        Console.WriteLine("price: "); // for article b
        int price = int.Parse(Console.ReadLine()); // for article b
        for (int i = 1; i <= 10; i++, sum += num)  //חייב להתרחש בסוף
        {
            Console.WriteLine("amount on notebooks kid number" + i + " bought: ");
            num = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("amount og bought notebooks: " + sum);
        Console.WriteLine(sum * price); // for article b
    }

    static void task_102()
    {
        int count = 0;
        for (int num = 1000; num <= 9999; num++)
        {
            //thousends + heundreds == tens + singels
            if (num / 100 == num % 100)
            {
                Console.WriteLine(num);
                count++;
            }
        }
    }

    static void task_103()
    {
        double sum = 0, time;
        int count = 0;
        for (int i = 0; i < 40; i++, sum += time) //חייב להתרחש בסוף
        {
            Console.WriteLine("lisence number: ");
            int lisence_num = int.Parse(Console.ReadLine());
            Console.WriteLine("time: ");
            time = double.Parse(Console.ReadLine());

            //300s = 5min
            if (time > 300)
            {
                Console.WriteLine("car number " + lisence_num + ", you didn't pass the level. ");
            }
            //240s = 4min
            if (time < 240)
            {
                Console.WriteLine("car number " + lisence_num + ", you did it in less than 4 minutes. ");
                count++;
            }

        }
        //מדפיס בסוף רק את המספור כי אני לא יכול לשמור במערך את מספרי המכוניות, כדי להדפיס ביחד בסוף , אז מדפיס בפנים
        Console.WriteLine("under 4 minutes num: " + count);
        Console.WriteLine("the avrage speed is: " + (sum / 40));
    }

    static void task_104()
    {
        Console.WriteLine("a houle positive number: ");
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        //7 כדי להיפטר גם במקרה הכי נמוך
        int num, counter_8 = 0, counter_9 = 0, counter_10 = 0, sum = 0, max_num = 7;
        for (int i = 0; i < n; i++, sum += num) //חייב להתרחש בסוף
        {
            num = rnd.Next(8, 11); //to incld 10
            max_num = Math.Max(max_num, num);

            if (num == 8) { counter_8++; }
            else if (num == 9) { counter_9++; }
            else { counter_10++; }
        }
        Console.WriteLine("avg: " + (sum/n));
        Console.WriteLine("max num rolled: " + max_num);

        int max_counter = Math.Max(Math.Max(counter_8, counter_9), counter_10);
        if (max_counter == counter_8)
        {
            Console.WriteLine("8 was roled most times");
        }
        if (max_counter == counter_9) //no else to show the cases that more than 1 counter is same.
        {
            Console.WriteLine("9 was roled most times");
        }
        if (max_counter == counter_10) //no else to show the cases that more than 1 counter is same.
        {
            Console.WriteLine("10 was roled most times");
        }
    }

    static void task_105()
    {
        Console.WriteLine("a houle positive odd number: ");
        int n = int.Parse(Console.ReadLine()), sum = 0, num, last_num = 0, smallest_diffrence = int.MaxValue, middle_num = 0; //the int.MaxValue to change in first iteration
        for (int i = 0; i < n; i++, last_num = num, sum += num) //חייב להתרחש בסוף
        {
            Console.WriteLine("a number in rising order: ");
            num = int.Parse(Console.ReadLine());

            smallest_diffrence = Math.Min(smallest_diffrence, num - last_num);

            if(i == n/2){ middle_num = num; }
        }
        Console.WriteLine("avg: " + sum / n);
        Console.WriteLine("smallest diffrence: " + smallest_diffrence);
        Console.WriteLine("middle num: " + middle_num);
    }

    static void task_106()
    {
        bool isnt_over = true;
        do
        {
            int type;
            do
            {
                Console.WriteLine("for type (1-13), 0 to stop: ");
            } while (!int.TryParse(Console.ReadLine(), out type) || !(type >= 0 && type <= 13));
            if (type == 0)
            {
                return;
            }
            int len;
            do
            {
                Console.WriteLine("give me the len: ");
            } while (!int.TryParse(Console.ReadLine(), out len) || !(len > 0));
            int wid, m;

            switch (type)
            {
                case 0:
                    isnt_over = false;
                    break;

                case 1:
                    do
                    {
                        Console.WriteLine("give me the width: ");
                    } while (!int.TryParse(Console.ReadLine(), out wid) || !(wid > 0));
                    for (int i = 0; i < len; i++)
                    {
                        for (int k = 0; k < wid; k++)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    do
                    {
                        Console.WriteLine("give me the width: ");
                    } while (!int.TryParse(Console.ReadLine(), out wid) || !(wid > 0));
                    for (int i = 1; i <= len; i++)
                    {
                        for (int k = 1; k <= wid; k++)
                        {
                            Console.Write(i);
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    do
                    {
                        Console.WriteLine("give me the width: ");
                    } while (!int.TryParse(Console.ReadLine(), out wid) || !(wid > 0));
                    for (int i = 1; i <= len; i++)
                    {
                        for (int k = 1; k <= wid; k++)
                        {
                            Console.Write(k);
                        }
                        Console.WriteLine();
                    }
                    break;

                case 4:
                    do
                    {
                        Console.WriteLine("give me the width: ");
                    } while (!int.TryParse(Console.ReadLine(), out wid) || !(wid > 0));
                    for (int i = 1; i <= len; i++)
                    {
                        for (int k = wid; k >= 1; k--)
                        {
                            Console.Write(k);
                        }
                        Console.WriteLine();
                    }
                    break;

                case 5:
                    do
                    {
                        Console.WriteLine("give me the width: ");
                    } while (!int.TryParse(Console.ReadLine(), out wid) || !(wid > 0));
                    for (int i = 1; i <= len; i++)
                    {
                        for (int k = i; k <= wid + i; k++)
                        {
                            Console.Write(k);
                        }
                        Console.WriteLine();
                    }
                    break;

                case 6:
                    for (int i = 1; i <= len; i++)
                    {
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }
                    break;

                case 7:
                    for (int i = 1; i <= len; i++)
                    {
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write(i);
                        }
                        Console.WriteLine();
                    }
                    break;

                case 8:
                    m = 0;
                    for (int i = 1; i <= len; i++)
                    {
                        m = i;
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(m);
                            m++;
                        }
                        Console.WriteLine();
                    }
                    break;

                case 9:
                    do
                    {
                        Console.WriteLine("give me the width: ");
                    } while (!int.TryParse(Console.ReadLine(), out wid) || !(wid > 0));
                    for (int i = len; i >= 1; i--)
                    {
                        for (int j = wid; j >= i; j--)
                        {
                            Console.Write(j);
                        }
                        Console.WriteLine();
                    }
                    break;

                case 10:
                    do
                    {
                        Console.WriteLine("give me the width: ");
                    } while (!int.TryParse(Console.ReadLine(), out wid) || !(wid > 0));
                    for (int i = len; i > 0; i--)
                    {
                        for (int k = 1; k <= wid; k++)
                        {
                            if(k < i)
                            {
                                Console.Write(' ');
                            }
                            else
                            {
                                Console.Write('*');
                            }
                        }
                        Console.WriteLine();
                    }
                    break;

                case 11:
                    do
                    {
                        Console.WriteLine("give me the width: ");
                    } while (!int.TryParse(Console.ReadLine(), out wid) || !(wid > 0));
                    for (int i = 1; i <= len; i++)
                    {
                        for (int k = 1; k <= wid; k++)
                        {
                            if (k <= wid - i)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write(k - (wid - i));
                            }
                        }
                        Console.WriteLine();
                    }
                    break;

                case 12:
                    for (int i = len; i > 0; i--)
                    {
                        for (int k = 0; k < i; k++)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }
                    break;

                case 13:
                    do
                    {
                        Console.WriteLine("give me the width: ");
                    } while (!int.TryParse(Console.ReadLine(), out wid) || !(wid > 0));
                    for (int i = 1; i <= len; i++)
                    {
                        for (int j = wid; j >= i; j--)
                        {
                            Console.Write(j);
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }while (isnt_over);
    }

    static void task_107()
    {

    }

    static void task_108()
    {

    }

    static void task_109()
    {

    }

    static void task_110()
    {

    }
}