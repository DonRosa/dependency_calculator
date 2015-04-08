using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyCalculator {
   public class DepMetric {

        public DepMetric() {
           
        }

        public double calcMetric(List<Class> cList) {
            double sum = 1;

            foreach (Class c in cList) {
                int cn = cList.Count - 1;
                double csn = calcFac(c.State * cList.Count);
                double temp1 = 1 + (5 * c.Interfaces) + (4 * c.Injected);
                double temp2 = 1 + (5 * cn) * Math.Log(cn + 1, 2) * csn;
                sum *= temp1 / temp2;
            }

            //double csn = calcFac(cs * n);
            //double temp1 = 1 + (5 * cf) + (4 * cj);
            //double temp2 = 1 + (5 * cn) * Math.Log(cn + 1, 2) * csn;

            return sum; 
        }

        private int calcFac(int p) {
            int result = p;

            for (int i = p - 1; i > 1; i--) {
                result *= i;
            }

            return result;
        }
    }
}
