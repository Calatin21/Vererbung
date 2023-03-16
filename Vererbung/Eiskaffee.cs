using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vererbung {
    internal class Eiskaffee: Kaffee {
        int anzahlEiskugel;
        bool sahne;
        public void SetAnzahlEiskugel(int i) {
            anzahlEiskugel = i;
        }
        public int GetAnzahlEiskugel() {
            return anzahlEiskugel;
        }
        public void SetSahne(bool b) {
            sahne = b;
        }
        public bool GetSahne() {
            return sahne;
        }
    }
}
