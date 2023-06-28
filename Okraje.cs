using System;
namespace Hadik
{
	public class Okraje
	{
        public static ConsoleColor BarvaOkraje = ConsoleColor.DarkBlue ;
  

        public Okraje ()
        {

        }


        public void VyklesliOkraje()
        {
            Console.ForegroundColor = BarvaOkraje;
           
            Console.WriteLine("█ Snězená potrava: {0}\t            Hra Had                                          █", Had.SnezenaPotrava);
            Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████");
            Console.BackgroundColor = ConsoleColor.White;
            for (int i=0;i<25;i++)
            {
                Console.WriteLine("██                                                                                  ██");
            }
            Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████████");

        }

        
    }
}

