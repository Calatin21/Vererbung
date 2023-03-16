using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung {
    internal class Getraenk {
        String name;
        String zustand;

        public void SetName(String s) {
            name = s;
        }
        public String GetName() {
            return name;
        }
        public void SetZustand(String s) {
            zustand = s;
        }
        public String GetZustand() {
            return zustand;
        }
    }
}
