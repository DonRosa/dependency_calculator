using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyCalculator {
    class Class : IClass {
        private String name;
        private int interfaces;
        private int injected;
        private int state;

        public Class() {
            
        }

        public string Name {
            get {
                return name;
            }
            set {
                this.name = value;
            }
        }

        public int Interfaces {
            get {
                return interfaces;
            }
            set {
                this.interfaces = value;
            }
        }

        public int Injected {
            get {
                return injected;
            }
            set {
                this.injected = value;
            }
        }

        public int State {
            get {
                return state;
            }
            set {
                this.state = value;
            }
        }
    }
}
