using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung {
    internal class Fruechtetee : Tee {
        String sorte;
        public void SetSorte(String s) {
            sorte = s;
        }
        public String GetSorte() {
            return sorte;
        }
    }
}
