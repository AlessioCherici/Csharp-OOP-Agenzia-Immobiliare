using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare
    {
    public class Appartamento : Immobile
        {
        private int stanze;
        private int bagni;

        public Appartamento(string codiceImmobile, string indirizzo, string cap, string città, int metriQuadri,int stanze, int bagni) 
            : base (codiceImmobile, indirizzo, cap, città, metriQuadri)
            {
            this.stanze = stanze;
            this.bagni = bagni;
            }

        //------------------------------------------- Metodi Get -------------------------------------------

        public int getStanze()
            {
            return this.stanze;
            }

        public int getBagni()
            {
            return this.bagni;
            }

        //------------------------------------------- Metodi Set -------------------------------------------
        public void setStanze()
            {
            this.stanze = stanze;
            }

        public void setBagni()
            {
            this.bagni = bagni;
            }

        //------------------------- Metodo Stampa Immobile -------------------------

        public virtual void stampaImmobile()
            {
            Console.WriteLine("---------" + base.geti + "---------" + "\n");
            Console.WriteLine("Codice Immobile : " + this.codiceImmobile);
            Console.WriteLine("CAP: " + this.cap);
            Console.WriteLine("Città: " + this.città);
            Console.WriteLine("Metratura: " + this.metriQuadri + "m2");
            }
        }
    }
