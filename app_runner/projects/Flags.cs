class Flags {
    public static void flags_runner() {
        Dictionary<string, string> flags = new Dictionary<string, string> { { "Sunday", "" }, { "Monday", "" }, { "Tuesday", "" },
            { "Wednesday", "" }, { "Thursday", "" }, { "Friday", "" }, { "Saturday", "" } };

        int swimlessDays = 0;

        foreach (var day in flags.Keys){
            string input;
            do {
                Console.WriteLine("What colored flag (red/white/black/purple) is today - {0} in the sea?", day);
                input = Console.ReadLine();

                if (IsFlagColorValid(input)){
                    flags[day] = input;
                    if (input.Equals("black", StringComparison.OrdinalIgnoreCase) || 
                        input.Equals("purple", StringComparison.OrdinalIgnoreCase)) {
                            swimlessDays++;
                    }
                 }
                else {
                    Console.WriteLine("Bad input! Please enter 'black', 'red', 'purple' or 'white'.");
                 }
                Console.WriteLine();

            } while (!IsFlagColorValid(input));
         }

         foreach (var day in flags.Keys){
                Console.WriteLine($"{day}: {flags[day]} flag");
          }

          Console.WriteLine($"\n{swimlessDays} swimless day(s).");
     }

     static bool IsFlagColorValid(string input){
         return input.Equals("black", StringComparison.OrdinalIgnoreCase) || input.Equals("red", StringComparison.OrdinalIgnoreCase) ||
            input.Equals("white", StringComparison.OrdinalIgnoreCase) || input.Equals("purple", StringComparison.OrdinalIgnoreCase);
      }
}






