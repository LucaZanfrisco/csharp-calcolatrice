using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {

        public static int somma(int addendo1, int addendo2)
        {
            return addendo1 + addendo2;
        }
        public static double somma(double addendo1, double addendo2)
        {
            return Math.Round(addendo1 + addendo2,2);
        }

        public static int differenza(int minuendo, int sottraendo)
        {
            return minuendo - sottraendo;
        }
        public static double differenza(double minuendo, double sottraendo)
        {
            return minuendo - sottraendo;
        }

        public static int moltiplicazione(int moltiplcando, int moltiplicatore)
        {
            return moltiplcando * moltiplicatore;
        }
        public static double moltiplicazione(double moltiplicando, double moltiplicatore)
        {
            return Math.Round(moltiplicando * moltiplicatore,2);
        }

        public static int valoreAssoluto(int valore)
        {
            return Math.Abs(valore);
        }
        public static double valoreAssoluto(double valore)
        {
            return Math.Abs(valore);
        }

        public static int valoreMinimo(int valore1, int valore2)
        {
            if(valore1 < valore2)
            {
                return valore1;
            }
            else if(valore1 > valore2)
            {
                return valore2;
            }
            else
            {
                Console.WriteLine("I valori inseriri sono uguali");
                return valore1;
            }                     
        }
        public static double valoreMinimo(double valore1, double valore2)
        {
            if(valore1 < valore2)
            {
                return valore1;
            }
            else if(valore1 > valore2)
            {
                return valore2;
            }
            else
            {
                Console.WriteLine("I valori inseriri sono uguali");
                return valore1;
            }
        }

        public static int valoreMassimo(int valore1, int valore2)
        {
            if(valore1 < valore2)
            {
                return valore2;
            }
            else if(valore1 > valore2)
            {
                return valore1;
            }
            else
            {
                Console.WriteLine("I valori inseriri sono uguali");
                return valore1;
            }
        }
        public static double valoreMassimo(double valore1, double valore2)
        {
            if(valore1 < valore2)
            {
                return valore2;
            }
            else if(valore1 > valore2)
            {
                return valore1;
            }
            else
            {
                Console.WriteLine("I valori inseriri sono uguali");
                return valore1;
            }
        }

        public static double elevazionePotenza(int baseElevazione, int esponente)
        {

            if(esponente == 0)
            {
                return 1;
            }else if(esponente < 0)
            { 
                return (double)1 / baseElevazione * elevazionePotenza(baseElevazione, esponente + 1);
            }else
            {
                return baseElevazione * elevazionePotenza(baseElevazione, esponente - 1);
            }
        }

    }
}
