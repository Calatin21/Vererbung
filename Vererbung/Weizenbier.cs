using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung {
    internal class Weizenbier: Bier {
        double weizenmalzgehalt;
        public void SetWeizenmalzgehalt(double d) {
            weizenmalzgehalt = d;
        }
        public double GetWeizenmalzgehalt() {
            return weizenmalzgehalt;
        }
    }
}
