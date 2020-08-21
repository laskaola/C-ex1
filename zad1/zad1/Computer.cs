using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1 {
    class Computer {

        private static int counter = 0;
        private int index;
        private string name;

        public Computer() {

            index = counter++;
            name = "Computer";
        }

        public int Index {
            get {
                return index;
            }
        }

        public override string ToString() {
            return name + " " + index.ToString();
        }
    }
}
