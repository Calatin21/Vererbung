using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vererbung {
    internal class Milchkaffee :Kaffee {
        double milchanteil;
        bool milchschaum;
        public void SetMilchanteil(double d) {
            milchanteil = d;
        }
        public double GetMilchanteil() {
            return milchanteil;
        }
        public void SetMilchschaum(bool b) {
            milchschaum = b;
        }
        public bool GetMilchschaum() {
            return milchschaum;
        }
    }
}
