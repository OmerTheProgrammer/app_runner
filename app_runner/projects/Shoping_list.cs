public class Shoping_list
{
	public static void Shoping_list_runner()
	{
		float price;
		string name;
		bool flag = true;
		float sum = 0;
		string str_flag = "";
		IDictionary<string, float> prodect_to_price = new Dictionary<string, float>();
		
		while(flag){
			if (flag){
			    Console.WriteLine("do you have more prodects?");
			    str_flag = Console.ReadLine();
			    if(str_flag == "yes"){
			        flag = true;
			    }
			    else if(str_flag == "no"){
			        flag = false;
			        continue;
			    }
			    else{
			        Console.WriteLine("not yes or no");
			        continue;
			    }
			}
			Console.WriteLine("prodact:");
			name = Console.ReadLine();
			do{
                Console.WriteLine("price:");
            } while (!float.TryParse(Console.ReadLine(), out price));
            
			if (price >= 0){
			    if (prodect_to_price.ContainsKey(name)){
			        Console.WriteLine("you wrote this one already!");
			        continue;
			    }
				prodect_to_price.Add(new KeyValuePair<string, float>(name,price));
			}
			else{
			    Console.WriteLine("thats a negative price!");
			    continue;
			}
			sum += prodect_to_price[name];
		}
		
		if(str_flag == "no"){
    		Console.WriteLine("\nyour shoping list:\n");
    		foreach (var i in prodect_to_price) { Console.WriteLine("{0} costs: {1}", i.Key, i.Value); }
            Console.WriteLine("\nsum:{0}",sum);
		}

	}
}