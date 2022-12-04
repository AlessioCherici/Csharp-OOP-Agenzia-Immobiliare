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

        public Appartamento(int stanze, int bagni) : base (string codiceImmobile, string indirizzo, string cap, string città, int metriQuadri)
            {
            this.stanze = stanze;
            this.bagni = bagni;
            }
        }
    }
