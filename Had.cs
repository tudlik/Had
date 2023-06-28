using System;
namespace Hadik
{
    public class Had
    {
        Random random;
        Potrava potrava;

       
        public bool Nazivu { get; private set; }

        public int X { get; private set; }
        public int Y { get; private set; }
        private ConsoleColor barvaTela;
        public static int SnezenaPotrava { get; private set; } = 0;
        public static List<Had> TeloHada { get; set; } = new List<Had>();

        private static ConsoleColor barvaHada = ConsoleColor.DarkGreen;
        private string dilekHada = "";
        public string Smer { get; set; }

        public Had()
        {
            Nazivu = true;
  
            TeloHada.Add(new Had(10, 10, barvaHada));
            TeloHada.Add(new Had(9,10, barvaHada));
            TeloHada.Add(new Had(8,10, barvaHada));

            potrava = new Potrava(14, 14, Potrava.BarvaPotravy);
            dilekHada = "██";
            Smer = "right";
            X = TeloHada[0].X;// nastaveni hlavy hada podle prvniho dilku
            Y = TeloHada[0].Y;
        }

        public Had(int x, int y, ConsoleColor barva)
        {
            X = x;
            Y = y;
            barvaTela = barva;
            dilekHada = "██";
        }

        public void Vykresli()
        {

            Console.CursorVisible = false;

            foreach (Had h in TeloHada)
            {
                Console.CursorLeft = h.X;
                Console.CursorTop = h.Y;
                Console.ForegroundColor = h.barvaTela;
                Console.CursorVisible = false; // nefunguje, asi smazat
                Console.Write(h.dilekHada);
               
            }
            
                Console.CursorVisible = false;// nefunguje, asi smazat
                potrava.VyklesliPotravu();

        }


        public void Lez()
        {
            NastavSmer();
            TeloHada.Insert(0, new Had(X, Y, ConsoleColor.DarkRed));
            TeloHada[1].barvaTela=barvaHada;
            KolizeHada();
            if(!NajedlSe())
            {

                TeloHada.RemoveAt(TeloHada.Count - 1);
            }

        }


        private void NastavSmer()
        {

            switch (Smer)
            {
                case "left":
                    X -= 2;
                    break;
                case "right":
                    X += 2;
                    break;
                case "up":
                    Y -= 1;
                    break;
                case "down":
                    Y += 1;
                    break;
            }
        }


        public bool NajedlSe()
        {
            if (TeloHada[0].X == potrava.potravaX && TeloHada[0].Y == potrava.potravaY)
            {
                PresunPotravu();
                SnezenaPotrava++;
                return true;
            }
            else
            {
                return false;
            }
        }


        public void PresunPotravu()
            {
            random = new Random();
            bool vtelehada = true;
            int x=0;
            int y=0;
            while (vtelehada)
            {
                vtelehada = false;
                x = random.Next(1, 41)*2; // Náhodně generovaná pozice jídla
                y = random.Next(2, 27);
                foreach (Had h in TeloHada)
                {
                    if (h.X == x && h.Y == y)
                    {
                        vtelehada = true;
                        break;
                    }
                }
            }
            potrava.NastavSouradnicePotravy(x ,y) ;
        }







        private void KolizeHada()
        {
            for (int i=1; i<TeloHada.Count; i++) // kolize hada se svým tělem
            {
                if (TeloHada[0].X == TeloHada[i].X && TeloHada[0].Y== TeloHada[i].Y)
                {
                    Nazivu = false;
                }
            }

            if (TeloHada[0].X==0 || TeloHada[0].X>=84 || TeloHada[0].Y == 1 || TeloHada[0].Y==27) // kolize hada s terminálem - okraji
            {
                Nazivu = false;
            }
        }

        

	}
}

