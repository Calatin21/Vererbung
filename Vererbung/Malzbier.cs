using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung {
    internal class Malzbier: Bier {
        int stammwuerzegehalt;
        public void SetStammwuerzegehalt(int i) {
            stammwuerzegehalt = i;
        }
        public int GetStammwuerzegehalt() {
            return stammwuerzegehalt;
        }     
    }
}
