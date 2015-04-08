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

        public DepMetric() {
            cn = 0;
            cf = 0;
            cj = 0;
            cs = 0;
            n = 0;
        }

        public double calcMetric() {
            
            double csn = calcFac(cs * n);
            double temp1 = 1 + (5 * cf) + (4 * cj);
            double temp2 = 1 + (5 * cn) * Math.Log(cn + 1, 2) * csn;

            System.Windows.Forms.MessageBox.Show(Convert.ToString(csn));
            return temp1 / temp2; 
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
