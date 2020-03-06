using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termékek
{
    class Termek
    {
        public int Age { get; set; }
        private string cikkszam, megnevezes;
        private int beszerzesi_ar;
        private double afaKulcs, akciosKedvezmeny;
        private bool akcios_e;

        public Termek(string cikkszam, string megnevezes, int beszerzesi_ar, double afaKulcs, bool akcios_e, double akciosKedvezmeny)
        {
            this.cikkszam = cikkszam;
            this.megnevezes = megnevezes;
            this.beszerzesi_ar = beszerzesi_ar;
            this.afaKulcs = afaKulcs;
            this.akcios_e = akcios_e;
            this.akciosKedvezmeny = akciosKedvezmeny;
        }

        public bool Akcios_e
        {
            get { return akcios_e; } 
            set { akcios_e = value;}
        }
        public string Cikkszam
        {
            get { return cikkszam; }
            set { cikkszam = value; }
        }
        public string Megnevezes
        {
            get { return megnevezes; }
            set { megnevezes = value; }
        }
        

        public int Netto()
        {
            int netto = (int)Math.Round(beszerzesi_ar*1.35);
            return netto;
        }

        public int Brutto()
        {
            int brutto = Convert.ToInt32(Netto() * (afaKulcs/100 + 1));
            return brutto;
        }

        public int Kedvezmeny()
        {
            int kedvezmenyes = 0;

            if (akcios_e)
                kedvezmenyes = Convert.ToInt32(Brutto() * ((100 - akciosKedvezmeny)/100));

            return kedvezmenyes;
        }
    }
}
