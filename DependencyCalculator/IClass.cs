using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyCalculator {
    interface IClass {
        String Name { get; set; }
        int Interfaces { get; set; }
        int Injected { get; set; }
        int State { get; set; }

        


    }
}
