using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung {
    internal class Bier : Getraenk {
        String hopfensorte;
        String hefesorte;
        double alkoholgehalt;
        public void SetHopfensorte(String s) {
            hopfensorte = s;
        }
        public String GetHopfensorte() {
            return hefesorte;
        }
        public void SetHefesorte(String s) {
            hefesorte = s;
        }
        public String GetHefesorte() {
            return hopfensorte;
        }
        public void SetAlkoholgehalt(Double d) {
            alkoholgehalt = d;
        }
        public Double GetAlkoholgehalt() {
            return alkoholgehalt;
        }
    }
}
