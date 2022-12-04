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

        public int ggetPostiAuto()
            {
            return this.postiAuto;
            }

        //------------------------------------------- Metodi Set -------------------------------------------
        public void setPostiAuto()
            {
            this.postiAuto = postiAuto;
            }
        }
    }
