using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare
    {
    public class Villa : Immobile
        {
        private int stanze;
        private int bagni;
        private int metriQuadriGiardino;

        public Villa(string codiceImmobile, string indirizzo, string cap, string città, int metriQuadri, int stanze, int bagni, int metriQuadriGiardino)
            : base(codiceImmobile, indirizzo, cap, città, metriQuadri)
            {
            this.stanze = stanze;
            this.bagni = bagni;
            this.metriQuadriGiardino = metriQuadri;
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

        public int getMetriQuadri()
            {
            return this.metriQuadriGiardino;
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

        public void setGiardino()
            {
            this.metriQuadriGiardino = metriQuadriGiardino;
            }
        }
    }
