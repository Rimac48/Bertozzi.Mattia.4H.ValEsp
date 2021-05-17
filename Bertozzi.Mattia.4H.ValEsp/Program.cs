using System;
using System.Collections;
using System.Collections.Generic;
using Bertozzi.Mattia._4H.ValEsp.Models;

namespace Bertozzi.Mattia._4H.ValEsp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] espressione = {"3","4","5","*","+"};//(5*4)+3

            Pila p = new Pila();

            Console.WriteLine(Operazione(espressione));
        }
        
        static int Operazione(string[]espressione)
        {
            Pila pila = new Pila();
            for(int i=0;i<espressione.Length;i++)
            {
                //rileva se epressione[i] è un numero,se lo è, esegue il push(inserisce nella pila),altrimenti va a fare i calcoli
                if (int.TryParse(espressione[i],out int n))
                {
                    pila.Push(espressione[i]);
                }
                else
                {
                    int ris = FaiCalcolo(pila,espressione[i]);//espressione conterrà l'operando
                    pila.Push(ris.ToString());
                }
            }
            return Convert.ToInt32(pila.Pop());
        }

        static int FaiCalcolo(Pila pila,string espressione)
        {
            int Risultato = 0;

            int op1 = Convert.ToInt32(pila.Pop());
            int op2 = Convert.ToInt32(pila.Pop());

            switch (espressione)
            {
                case "+":
                    Risultato = op1 + op2;
                    break;
                case "-":
                    Risultato = op1 - op2;
                    break;
                case "*":
                    Risultato = op1 * op2;
                    break;
                case "/":
                    Risultato = op1 / op2;
                    break;
            }

            return Risultato;
        }
    }
}
