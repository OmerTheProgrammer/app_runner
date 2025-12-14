namespace app_runner.projects
{
    class Shift
    {
        public DateTime date { get; set; }
        private DateTime[] Time_periods;

        public DateTime[] time_periods
        {
            get { return Time_periods; }
            set { if (value.Length == 2) { Time_periods = value; } }
        }
    }

    class caculetor
    {
        public static void work_caculetor_runner()
        {
            int shift_count = 1;
            double payment = 22.54;
            DateTime base_date = new DateTime(1, 1, 1, 1, 1, 1);
            bool in_glicha = true;

            Console.WriteLine("in glicha? (גליצ'ה):");
            string s_in_glicha = Console.ReadLine();
            if (s_in_glicha == "no") { in_glicha = false; }
            else
            {
                Console.WriteLine("so yes");
                in_glicha = true;
            }

            Console.WriteLine("payment:");
            string s_payment = Console.ReadLine();
            if (!double.TryParse(s_payment, out _)) { Console.WriteLine("I put it to 22.54"); }
            else { payment = double.Parse(s_payment); }

            Console.WriteLine("shift count:");
            string s_shift_count = Console.ReadLine();
            if (!int.TryParse(s_shift_count, out _)) { Console.WriteLine("I put it to 1"); }
            else { shift_count = int.Parse(s_shift_count); }
            Shift[] shifts = new Shift[shift_count];

            int i = 0;
            while (i < shift_count)
            {
                bool retry = true;

                Console.WriteLine("The date of the shift, like this: 'day.month':");
                while (retry)
                {
                    string str_date = Console.ReadLine();
                    if (DateTime.TryParseExact(str_date, "d.M", null, System.Globalization.DateTimeStyles.None, out base_date))
                    {
                        retry = false;
                    }
                    else { Console.WriteLine("Invalid input. Please enter a valid date in the 'day.month' format."); }
                }

                if (!retry)
                {
                    shifts[i] = new Shift();
                    shifts[i].date = base_date;

                    retry = true;
                    DateTime start_time = DateTime.MinValue; // Declare the start_time variable outside the loop
                    Console.WriteLine("The start time of the shift, like this: 'h/m/s':");
                    while (retry)
                    {
                        string str_s_hour = Console.ReadLine();

                        if (DateTime.TryParseExact(str_s_hour, "H/m/s", null, System.Globalization.DateTimeStyles.None, out start_time))
                        {
                            retry = false;
                            shifts[i].time_periods = new DateTime[] { start_time };
                        }
                        else { Console.WriteLine("Invalid input. Please enter a valid time in the 'h/m/s' format."); }
                    }

                    if (!retry)
                    {
                        retry = true;
                        Console.WriteLine("The end time of the shift, like this: 'h/m/s':");
                        while (retry)
                        {
                            string str_e_hour = Console.ReadLine();
                            if (DateTime.TryParseExact(str_e_hour, "H/m/s", null, System.Globalization.DateTimeStyles.None, out DateTime end_time))
                            {
                                retry = false;
                                if ((shifts[i].date.DayOfWeek == DayOfWeek.Friday || start_time.TimeOfDay > new TimeSpan(13, 30, 0)) && in_glicha)
                                {
                                    end_time = end_time.AddMinutes(-3);
                                }
                                shifts[i].time_periods = new DateTime[] { start_time, end_time };
                            }
                            else { Console.WriteLine("Invalid input. Please enter a valid time in the 'h/m/s' format."); }
                        }
                    }
                }

                i++;
            }
            double sum = 0;
            double money = 0;
            foreach (Shift shift in shifts)
            {
                Console.WriteLine("\n" + shift.date.ToString("dd.MM"));
                TimeSpan time = shift.time_periods[1] - shift.time_periods[0];
                Console.WriteLine("time: " + time);
                double durationInHours = time.Hours + time.Minutes / 60.0 + time.Seconds / 3600.0;
                Console.WriteLine("time in hours: " + durationInHours);
                if (shift.date.DayOfWeek == DayOfWeek.Saturday) { money = durationInHours * payment * 1.5 + 12; }
                else { money = durationInHours * payment + 12; }
                Console.WriteLine("money with the cash for rides: " + money);
                sum += money;
            }
            Console.WriteLine("\ntotal money: " + sum);
        }
    }
}
