using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyCalculator {
    public partial class Form1 : Form {

        DepMetric depMet;
        List<Class> dependencys;
        Class theClass;
        String name;
        int interfaces;
        int injected;
        int state;


        public Form1() {
            InitializeComponent();
            dependencys = new List<Class>();
            theClass = new Class();
            setup();
        }

        private void setup() {
            tBoxInterface.Text = Convert.ToString(0);
            tBoxInjected.Text = Convert.ToString(0);
            tBoxState.Text = Convert.ToString(0);
        }

        private void tBoxName_TextChanged(object sender, EventArgs e) {
            name = tBoxName.Text;
        }

        private void tBoxInterface_TextChanged(object sender, EventArgs e) {
            try {
                interfaces = Convert.ToInt16(tBoxInterface.Text);
            } catch (Exception) {
                interfaces = 0;
            }
        }

        private void tBoxInjected_TextChanged(object sender, EventArgs e) {
            try {
                injected = Convert.ToInt16(tBoxInjected.Text);
            } catch (Exception) {
                injected = 0;
            }
        }

        private void tBoxState_TextChanged(object sender, EventArgs e) {
            try {
                state = Convert.ToInt16(tBoxState.Text);
            } catch (Exception) {
                state = 0;
            }
        }

        private void btnDependency_Click(object sender, EventArgs e) {
            collectClass();
            displayDependency();
            reset();
        }

        private void collectClass() {
            Class c = new Class();
            c.Name = name;
            c.Interfaces = interfaces;
            c.Injected = injected;
            c.State = state;
            dependencys.Add(c);
        }

        private void displayDependency() {
            lBoxDependency.DataSource = null;
            lBoxDependency.DataSource = dependencys;
            lBoxDependency.DisplayMember = "Name";
        }

        private void reset() {
            tBoxName.Text = "";
            tBoxInterface.Text = Convert.ToString(0);
            tBoxInjected.Text = Convert.ToString(0);
            tBoxState.Text = Convert.ToString(0);
        }

        private void lBoxDependency_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnCalc_Click(object sender, EventArgs e) {
            if (tBoxName.Text.Length > 0) {
                collectClass(); 
            }
            DepMetric dm = new DepMetric();
            double result = dm.calcMetric(dependencys);
            tBoxResult.Text = Convert.ToString(result);
        }

        private void lBoxDepFormat(object sender, ListControlConvertEventArgs e) {
            String name = ((Class)e.ListItem).Name;
            String cf = Convert.ToString(((Class)e.ListItem).Interfaces);
            String cj = Convert.ToString(((Class)e.ListItem).Injected);
            String cs = Convert.ToString(((Class)e.ListItem).State);

            e.Value = name + ", cf: " + cf + ", cj: " + cj + ", cs: " + cs;
        }

       

        
      
    }
}
