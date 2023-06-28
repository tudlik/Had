using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;

namespace Hadik;
class Program
{
    static void Main(string[] args)
    {
        Had had = new Had();
        DateTime casStart = DateTime.Now;
        Okraje okraje = new Okraje();


            while (had.Nazivu)
            {

                Console.Clear();


                okraje.VyklesliOkraje();
                had.Vykresli();


                had.Lez();
                Thread.Sleep(130); // prodeleva mezi další reakcí - v milisekundách
                                   // Pokud je stisknuta nějaká klávesa


                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(); // Načtení klávesy

                    // Reakce na jednotlivé klávesy
                    if (key.Key == ConsoleKey.RightArrow)
                        had.Smer = "right";
                    if (key.Key == ConsoleKey.LeftArrow)
                        had.Smer = "left";
                    if (key.Key == ConsoleKey.DownArrow)
                        had.Smer = "down";
                    if (key.Key == ConsoleKey.UpArrow)
                        had.Smer = "up";
                }
            }


 
        string zpravaKonec = "Konec hry...!";
        Console.BackgroundColor = ConsoleColor.Red;
        Console.CursorLeft = 84 / 2 - zpravaKonec.Length / 2;
        Console.CursorTop = 27 / 2;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(zpravaKonec);
        Console.ReadKey();
    }
}

