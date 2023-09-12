using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public class GenericsCalcoliHelper
    {
        public static T Somma<T>(T addendo1, T addendo2)
        {
            dynamic a = addendo1;
            dynamic b = addendo2;
            return a + b;
        }

        public static T Differenza<T>(T minuendo, T sottraendo)
        {
            dynamic a = minuendo;
            dynamic b = sottraendo;
            return a - b;
        }

        public static T Moltiplicazione<T>(T moltiplicando, T moltiplicatore)
        {
            dynamic a = moltiplicando;
            dynamic b = moltiplicatore;
            return a * b;
        }

        public static T ValoreAssoluto<T>(T  valoreAssoluto)
        {
            dynamic a = valoreAssoluto;
            return Math.Abs(a);
        }

        public static T ValoreMinimo<T>(T valore1 , T valore2)
        {
            dynamic a = valore1;
            dynamic b = valore2;
            if(a < b)
            {
                return a;
            }
            else if(a > b)
            {
                return b;
            }
            else
            {
                Console.WriteLine("I valori inseriri sono uguali");
                return a;
            }
        }

        public static T ValoreMassimo<T>(T valore1, T valore2)
        {
            dynamic a = valore1;
            dynamic b = valore2;
            if(a < b)
            {
                return b;
            }
            else if(a > b)
            {
                return a;
            }
            else
            {
                Console.WriteLine("I valori inseriri sono uguali");
                return a;
            }
        }

    }
}
