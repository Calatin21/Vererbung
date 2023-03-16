using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vererbung {
    internal class Espresso : Kaffee{
        bool doppel;
        public void SetDoppel(bool b) {
            doppel = b;
        }
        public bool GetDoppel() {
            return doppel;
        }
    }
}
