using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_Uge4_SimpelKlasse2
{ 
    internal class Beer
    {
        public string name;
        public int size;
        public int price;
        public Boolean alcohol;
        public double procent;

        public Beer(string name, int size, int price, Boolean alcohol, double procent)
        {
            this.name = name;
            this.size = size;
            this.price = price;
            this.alcohol = alcohol;
            this.procent = procent;
        }

        public string ToString()
        {
            return "Navn: " + name + " Størrelse: " + size + "cL. Indeholder alkohol: " + (alcohol ? "ja" : "nej") + ". Procent: " + procent + "%.";
        }

        public int GetPrice()
        {
            return price;
        }

    }

}
