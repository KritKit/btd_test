using System.Collections.Generic;
public class Hello {
	public static void Main() {
        Console.WriteLine("Choice : \n");
        Console.WriteLine("1. Delete aeiou\n");
        Console.WriteLine("2. Christmas Tree\n");
        Console.WriteLine("3. ATM Cut Number\n");
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
            case 3:
                atm_cut();
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

    public static void atm_cut() {
        Console.WriteLine("Choice 3 : ATM Cut Number\nInput : ");
           string input = System.Console.ReadLine();
            string innp = "";
            double numberz = 0;
            double sumz = 0;
            string sshow = "";

        for (int i = 0; i < input.Length; i++){
            if("1234567890".Contains(input[i])){
                innp += input[i];
            }else{
                if(innp != ""){
                  numberz = double.Parse(innp);
                  sumz += numberz;
                  innp = "";
                }
            }
        }
            if(innp != ""){
              numberz = double.Parse(innp);
              sumz += numberz;
              innp = "";
            }
            if( sumz < 1000){
              sshow += "0";
                if(sumz < 100){
                  sshow += "0";
                }
            }     
            sshow += sumz.ToString();
            System.Console.WriteLine(sshow);
    
    }
}