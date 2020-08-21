using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1 {
    class Car : IAccelerate {

        private int accelerate;
        private static int counter;
        private int index;
        private string name;
        public Car() {

            index = counter++;
            name = "Car";
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
    }
}

