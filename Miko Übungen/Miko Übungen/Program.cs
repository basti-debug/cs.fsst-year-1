using System;

namespace Übungen_für_miko
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.static public void Dreieck(int anzahl, string zeichen)
             * Bsp. für einen Aufruf: Dreieck(4,"*")
           
             * ****
             * ***
             * **
             * *
             * 
             * 2.static public double Maximum (double z1, double z2, double z3)
             * größte der drei zahlen herausfinden
             * 
             * 3.static public double Summe(double sw, double mult, int anz)
             * Bsp.: y = sume(1,2,64)       1+2+4+8+....
             *       y = summe(2,3,5)       2+6+48+54+162
             *       
             * 4.public void DrawStairs(Canvas can, double width, int count)
             * 
             * 5.public void DrawRectangles(Canvas can, double width, int count)
             * seitenlänge immer halbiert
             */

            Dreieck(10, "*");
            Enter();
            double maxvalue = maxile(1, 8, 10);
            Console.WriteLine(maxvalue);
            Enter();
            
            summe(2,3,5);
           
            Console.ReadKey();
        }



        static void Enter()
        {
            Console.WriteLine();
        }


        static void Dreieck(int anzahl, string zeichen)
        {

            for (int i = 1; i <= anzahl; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(zeichen);
                }
                Enter();
            }
        }

        static public double maxile(double z1, double z2, double z3)
        {
            double summe = z2;
            if (z1 > z2)
                summe = z1;

            if (z1 < z3)
                summe = z3;

            return summe;
        }

        static public string summe(int sw, int mult, int anz)
        {
            Console.WriteLine(sw);
            int j = sw;
            for (int i = 0; i < anz; i++)
            {
                j = j* mult;
                Console.WriteLine(j);
            }

            string jj = "good";
            return jj;
        }
    }
}
