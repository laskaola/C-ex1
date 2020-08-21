using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1 {
    class Submarine : iDive, IAccelerate {

        private int accelerate;
        private int dive;
        private static int counter;
        private int index;
        private string name;
        public Submarine() {

            index = counter++;
            name = "Submarine";
        }

        public int Index {
            get {
                return index;
            }
        }

        public override string ToString() {
            return name + " " + index.ToString();
        }
        public int Dive {
            get {
                return dive;
            }
            set {
                dive = value;
            }
        }
        public int Accelerate {
            get {
                return accelerate;
            }
            set {
                accelerate = value;
            }
        }
    }
}
