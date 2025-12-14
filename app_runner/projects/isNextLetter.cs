using I_O = System.Console;
class NextLetter
{
  public static void NextLetterConuter()
  {
    const int SIZE = 3;
    int count = 0;
    char[] letters = new char[SIZE];
    
    I_O.WriteLine("enter a {0} following letters: ",SIZE);
    for (int i = 0; i < SIZE; i++){
        letters[i] = char.Parse(I_O.ReadLine());}
    
    for (int i = 0; i < SIZE-1; i++){
        if((int)letters[i]+1 == (int)letters[i+1]){
            count++;}
        }
    I_O.WriteLine(count + " letters are following");
  }
}