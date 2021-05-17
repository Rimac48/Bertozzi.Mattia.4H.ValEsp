using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bertozzi.Mattia._4H.ValEsp.Models
{
    class Pila
    {
        int lunghezza=0;
        List<string> pila;

        //crea la lista pila
        public Pila()
        {
            pila = new();
        }

        //inserisce il numero dell'espressione nella pila
        public void Push(string num)
        {
            pila.Add(num);
            lunghezza++;
        }

        //restituisce il primo numero in fondo alla pila e rimuove uno spazio
        public string Pop()
        {
            if(lunghezza!=0)
            {
                string num = pila[lunghezza - 1];
                pila.RemoveAt(lunghezza - 1);
                lunghezza--;
                return num;
            }
            return "";
        }
    }
}
