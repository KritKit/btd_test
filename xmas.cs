public class xmas {
	public static void Test() {
		//output example
		// System.Console.WriteLine("Hello borntoDev Lab");
		//input example
		string input = System.Console.ReadLine();

       string spaze = "";
       string spaze2 = "";
       string dott = "*";
       string dott2 = "*";
      string baze = "";
       string xmas_row = "";
       int xmas_number = 0;

      for (int o = 0; o < int.Parse(input); o++){
        spaze += " ";
        baze += "=";
      }
      spaze2 = spaze;
      
      for (int i = 0; i < int.Parse(input); i++){
          xmas_number++;
          System.Console.WriteLine(spaze+dott);
          for (int j = 0; j < xmas_number; j++){
              spaze2 = spaze2.Remove(0, 1);
              System.Console.WriteLine(spaze2+(dott2+="**"));
          }
          spaze2+=" ";
          dott2 = dott2.Remove(0,2);
      }
      System.Console.WriteLine(spaze+"|");
      System.Console.WriteLine(baze+"v"+baze);
        
		//input of output example
		// System.Console.WriteLine(input);
		// System.Console.WriteLine(dott+xmas_row);

		//Tips:  Run for check input format
	}
}