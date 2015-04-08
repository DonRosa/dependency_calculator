using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyCalculator {
   public class DepMetric {

        public int cn { get; set; }
        public int cf { get; set; }
        public int cj { get; set; }
        public int cs { get; set; }
        public int n { get; set; }


        //public int CN {
        //    set { cn = value; }
        //}

        //public void setCN(int val) {
        //    cn = val;
        //}

        //public int CF {
        //    set { cf = value; }
        //}

        //public int CJ {
        //    set { cj = value; }
        //}

        //public int CS {
        //    set { cs = value; }
        //}

        //public int N {
        //    set { n = value; }
        //}

        public DepMetric() {
            cn = 0;
            cf = 0;
            cj = 0;
            cs = 0;
            n = 0;
        }

        public int calcMetric() {
            
            int csn = calcFac(cs * n);
            int temp1 = 1 + (5 * cf) + (4 * cj);
            int temp2 = 1 + (5 * cn) * Convert.ToInt16(Math.Log(cn + 1, 2)) * csn;

            return temp1/temp2; 
        }

        private int calcFac(int p) {
            int result = 0;

            for (int i = p; i > 1; i--) {
                result *= i;
            }

            return result;
        }
    }
}
