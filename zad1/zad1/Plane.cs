using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1 {
    class Plane : IRise, IAccelerate {
        private int accelerate = 0;
        private int rise = 0;
        private static int counter;
        private int index;
        private string name;
        public Plane() {

            index = counter++;
            name = "Plane";
        }

        public int Index {
            get {
                return index;
            }
        }

        public override string ToString() {
            return name + " " + index.ToString();
        }


        public int Accelerate {
            get {
                return accelerate;
            }
            set {
                accelerate = value;
            }
        }
        public int Rise {
            get {
                return rise;
            }
            set {
                if(value > 0)
                    rise = value;
            }
        }


    }
}
