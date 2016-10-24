using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kazkoks_zaidimukas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
//------------------------------------------------------------------------------------
        public static bool MainMenu()
        {            
            Console.Clear();
            Console.WriteLine("Pasirink savo priesininka: ");
            Console.WriteLine("1) Kautis pries zuiki.");
            Console.WriteLine("2) Kautis pries vilka");
            Console.WriteLine("3) Kautis pries meska");
            Console.WriteLine("4) Turnyras");
            Console.WriteLine("5) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Zuikis();            
                Console.ReadLine();
                return true;
            }
            else if (result == "2")
            {
                Vilkas();              
                Console.ReadLine();
                return true;
            }
            else if (result == "3")
            {
                Meska();
                Console.ReadLine();
                return true;
            }
            else if (result == "4")
            {
                Console.WriteLine("PIRMAS Roundas");
                Console.ReadLine();
                if (Zuikis() > 0)
                {
                    Console.WriteLine("ANTRAS Roundas");
                    Console.ReadLine();
                    if (Vilkas() > 0)
                    {
                        Console.WriteLine("Paskutinis Roundas");
                        Console.ReadLine();
                        if (Meska() > 0) Console.WriteLine("LAIMEJEI TURNYRA!!!");
                        else Console.WriteLine("Prapisai Turnyra!!!");
                    }
                    else Console.WriteLine("Prapisai Turnyra!!!");
                }
                else
                {
                    Console.WriteLine("Prapisai Turnyra!!!");
                }
                Console.ReadLine();
                return true;
            }
            else if (result == "5")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
//--------------------------------------------------------------------------------------------------------
        private static int Zuikis()
        {
            int Hp = 100;
            int Hp1 = 40;
            Console.Clear();

            Console.WriteLine("Tavo HP = {0}    Zuikio HP = {1}", Hp, Hp1);
            Console.WriteLine("");

            Console.WriteLine("Kova prasideda!");
            Random myRandom = new Random();

            int Spejimai = 0;

            while (Hp > 0 && Hp1 > 0)
            {
                int randomNumber = myRandom.Next(1, 4);
                Console.WriteLine("Spek skaiciu tarp 1 ir 4: ");
                string Spejimas = Console.ReadLine();
                Spejimai++;
                if (Spejimas == randomNumber.ToString())
                {
                    Hp1 = Hp1 - 5;
                    Console.WriteLine("Atspejei!! Zuikis susilpnejo.");
                    Console.WriteLine("Tavo HP = {0}   Zuikio HP = {1}", Hp, Hp1);
                }
                else
                {
                    Hp = Hp - 5;
                    Console.WriteLine("Neatspejei ir susilpnejei.");
                    Console.WriteLine("Tavo HP = {0}   Zuikio HP = {1}", Hp, Hp1);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Kova truko {0} raundus(-u).", Spejimai);
            if (Hp > 0) Console.WriteLine("Sveikinu laimejus!!! :)");
            else Console.WriteLine("Pralosei!!! Sekmes kita karta.");
            return Hp;
        }
//--------------------------------------------------------------------------------------------------
        private static int Vilkas()
        {
            int Hp = 100;
            int Hp1 = 60;
            Console.Clear();

            Console.WriteLine("Tavo HP = {0}    Vilko HP = {1}", Hp, Hp1);
            Console.WriteLine("");

            Console.WriteLine("Kova prasideda!");
            Random myRandom = new Random();

            int Spejimai = 0;

            while (Hp > 0 && Hp1 > 0)
            {
                int randomNumber = myRandom.Next(1, 4);
                Console.WriteLine("Spek skaiciu tarp 1 ir 4: ");
                string Spejimas = Console.ReadLine();
                Spejimai++;
                if (Spejimas == randomNumber.ToString())
                {
                    Hp1 = Hp1 - 5;
                    Console.WriteLine("Atspejei!! Vilkas susilpnejo.");
                    Console.WriteLine("Tavo HP = {0}   Vilko HP = {1}", Hp, Hp1);
                }
                else
                {
                    Hp = Hp - 5;
                    Console.WriteLine("Neatspejei ir susilpnejei.");
                    Console.WriteLine("Tavo HP = {0}   Vilko HP = {1}", Hp, Hp1);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Kova truko {0} raundus(-u).", Spejimai);
            if (Hp > 0) Console.WriteLine("Sveikinu laimejus!!! :)");
            else Console.WriteLine("Pralosei!!! Sekmes kita karta.");
            return Hp;
        }
//--------------------------------------------------------------------------------------------------
        private static int Meska()
        {
            int Hp = 100;
            int Hp1 = 110;
            Console.Clear();

            Console.WriteLine("Tavo HP = {0}    Meskos HP = {1}", Hp, Hp1);
            Console.WriteLine("");

            Console.WriteLine("Kova prasideda!");
            Random myRandom = new Random();

            int Spejimai = 0;

            while (Hp > 0 && Hp1 > 0)
            {
                int randomNumber = myRandom.Next(1, 4);
                Console.WriteLine("Spek skaiciu tarp 1 ir 4: ");
                string Spejimas = Console.ReadLine();
                Spejimai++;
                if (Spejimas == randomNumber.ToString())
                {
                    Hp1 = Hp1 - 5;
                    Console.WriteLine("Atspejei!! Meska susilpnejo.");
                    Console.WriteLine("Tavo HP = {0}   Meskos HP = {1}", Hp, Hp1);
                }
                else
                {
                    Hp = Hp - 5;
                    Console.WriteLine("Neatspejei ir susilpnejei.");
                    Console.WriteLine("Tavo HP = {0}   Meskos HP = {1}", Hp, Hp1);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Kova truko {0} raundus(-u).", Spejimai);
            if (Hp > 0) Console.WriteLine("Sveikinu laimejus!!! :)");
            else Console.WriteLine("Pralosei!!! Sekmes kita karta.");
            return Hp;
        }
//--------------------------------------------------------------------------------------------------
    }
}
