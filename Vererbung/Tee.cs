using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vererbung {
    internal class Tee : Getraenk {
        bool zucker;
        bool zitrone;
        bool milch;
        int ziehzeit;
        public void SetZucker(bool b) {
            zucker = b;
        }
        public bool GetZucker() {
            return zucker;
        }
        public void SetZitrone(bool b) {
            zitrone = b;
        }
        public bool GetZitrone() {
            return zitrone;
        }
        public void SetMilch(bool b) {
            milch = b;
        }
        public bool GetMilch() {
            return milch;
        }
        public void SetZiehzeit(int i) {
            ziehzeit = i;
        }
        public int GetZiehzeit() {
            return ziehzeit;
        }
    }
}
