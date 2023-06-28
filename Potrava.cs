using System;
namespace Hadik
{
	public class Potrava
	{
		public Had had;
	
		public static ConsoleColor BarvaPotravy = ConsoleColor.DarkBlue;
		private ConsoleColor barvaPotravy;
		public int potravaX { get; private set; }
		public int potravaY { get; private set; }

        public Potrava(int x, int y,ConsoleColor barva )
		{
			barvaPotravy = barva;
			potravaX = x;
			potravaY = y;

		}

		public void VyklesliPotravu()
		{

                Console.CursorLeft = this.potravaX;
                Console.CursorTop = this.potravaY;
                Console.ForegroundColor = this.barvaPotravy;
                Console.CursorVisible = false;
                Console.Write("██");

        }
		
		public void NastavSouradnicePotravy(int x, int y)
		{
			this.potravaX = x;
			this.potravaY = y;
		}
	}
}

