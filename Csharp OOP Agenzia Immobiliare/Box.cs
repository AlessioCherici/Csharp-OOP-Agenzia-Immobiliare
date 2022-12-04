using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare
    {
    public class Box : Immobile
        {
        private int postiAuto;

        public Box(string codiceImmobile, string indirizzo, string cap, string città, int metriQuadri, int postiAuto)
            : base(codiceImmobile, indirizzo, cap, città, metriQuadri)
            {
            this.postiAuto = postiAuto;
            }
        //------------------------------------------- Metodi Get -------------------------------------------

        public int getPostiAuto()
            {
            return this.postiAuto;
            }

        //------------------------------------------- Metodi Set -------------------------------------------
        public void setPostiAuto()
            {
            this.postiAuto = postiAuto;
            }

        //------------------------- Metodo Stampa Immobile -------------------------

        public virtual void stampaImmobile()
            {
            Console.WriteLine("---------" + base.getIndirizzo() + "---------" + "\n");
            Console.WriteLine("Codice Immobile : " + base.getCodiceImmobile());
            Console.WriteLine("CAP: " + base.getCap());
            Console.WriteLine("Città: " + base.getCittà());
            Console.WriteLine("Metratura: " + base.getMetriQuadri() + "m2");
            Console.WriteLine("Numero posti auto: " + this.getPostiAuto());
            }
        }
    }
