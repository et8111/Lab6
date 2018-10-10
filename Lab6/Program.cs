using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        public static void RGENERATOR(Random r, int dieSides)
        {
            int r1 = (r.Next(1, dieSides + 1));
            int r2 = (r.Next(1, dieSides + 1));

            string msg = "";
            if (r1 + r2 == 7)
                msg = "Seven! *snaps fingers*";
            else if (r1 == 1 && r2 == 1)
                msg = "SNAKE EYES.";
            else if (r1 == 6 && r2 == 6)
                msg = "BOXCAR.";
            Console.WriteLine("DICE1".PadRight(7) + "DICE2".PadRight(7));
            Console.WriteLine(r1.ToString().PadRight(7) + r2.ToString().PadRight(7)+ msg);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            string reader = "";
            Random r = new Random();
            Console.WriteLine("ENTER SIDES: ");
            int dieSides = int.Parse(Console.ReadLine());
            bool s = true;
            while (s)
            {
                RGENERATOR(r, dieSides);
                Console.Write("y to restart (Anykey to exit): ");
                reader = Console.ReadLine().ToLower();
                if (reader != "y")
                    break;
            }
        }
    }
}
