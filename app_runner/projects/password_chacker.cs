public class passward_cheker {
  public static void cheker() {
        string str;
        int count;
        do{
            System.Console.WriteLine("enter password that's has at least 3 letters and has a length of at least 6 characters:");
            str = System.Console.ReadLine();
            count = 0;
            for(int i = 0; i < str.Length;i++){
                if(char.IsLetter(str[i])){count++;}
            }
            if(str.Length == 6 && count >= 3){
                System.Console.WriteLine("WELLCOME");
                break;}
            else{
                System.Console.WriteLine("Error!");}
        }while(true);
    
  }
}