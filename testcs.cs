using System.Collections.Generic;
public class Hello {
	public static void Main() {
        Console.WriteLine("Choice : \n");
        Console.WriteLine("1. Delete aeiou\n");
        Console.WriteLine("2. Christmas Tree\n");
		string input = Console.ReadLine();
        
        choice(int.Parse(input));
	}
    public static void choice(int choice){
        switch (choice){
            case 1:
                del_aeiou();
                break;
            case 2:
                xmas();
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
    public static void del_aeiou(){
        Console.WriteLine("Choice 1 : Delete aeiou\nInput : ");
        string input = Console.ReadLine();
        List<string> list = new List<string>();
        int stack = 0;
        foreach (char x in input){ 
            stack++;        
        }
        for (int i = 0; i < stack; i++){
            if (!"aeiou".Contains(input[i]) && !"AEIOU".Contains(input[i])){ 
                list.Add(input[i].ToString());
            }
        }
		Console.WriteLine("สิ่งที่พิมพ์มาคือ : "+string.Join("",list));
    }

    public static void xmas(){
       Console.WriteLine("Choice 2 : Christmas Tree\nInput : ");
	   string input = System.Console.ReadLine();

       string spaze = "";
       string spaze2 = "";
       string dott = "*";
       string dott2 = "*";
       string baze = "";
       int xmas_number = 0;
       int cdot = 0;
       int cspaze = 0;

      for (int o = 0; o < int.Parse(input); o++){
        spaze += " ";
        baze += "=";
      }
   
      for (int i = 0; i < int.Parse(input); i++){
          xmas_number++;
          spaze2 = spaze.Remove(0,1);
          System.Console.WriteLine(spaze+dott);
          for (int j = 0; j < xmas_number; j++){
              spaze2 = spaze2.Remove(0,cspaze);
              System.Console.WriteLine(spaze2+(dott2+="**"));
              cdot++;   
              cspaze++;
              if(j > 0){
               for (int k = 0; k < j;k++){spaze2+=" ";}
              }           
          }
          dott2 = "*";
          cspaze = 0; 
      }
      System.Console.WriteLine(spaze+"|");
      System.Console.WriteLine(baze+"V"+baze);
    }
}