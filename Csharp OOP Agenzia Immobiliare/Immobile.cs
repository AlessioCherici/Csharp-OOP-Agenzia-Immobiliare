using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare
    {
    public class Immobile
        {
        private string codiceImmobile;
        private string indirizzo;
        private string cap;
        private string città;
        private int metriQuadri;
        
        public Immobile(string codiceImmobile, string indirizzo, string cap, string città, int metriQuadri) 
            {
            this.codiceImmobile = codiceImmobile;
            this.indirizzo = indirizzo;
            this.cap = cap;
            this.città = città;
            this.metriQuadri = metriQuadri;
            }

        //------------------------- Metodi Get -------------------------



        //------------------------- Metodo Stampa Immobile -------------------------

        public virtual void stampaImmobile()
            {
            Console.WriteLine("---------" + this.indirizzo + "---------" + "\n");
            Console.WriteLine("Codice Immobile : " + this.codiceImmobile);
            Console.WriteLine("CAP: " + this.cap);
            Console.WriteLine("Città: " + this.città);
            Console.WriteLine("Metratura: " + this.metriQuadri + "m2");
            }
        }
    }
