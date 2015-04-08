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

            //for (int i = 0; i < 10; i++) {
            //    Class c = new Class();
            //    c.Name = Convert.ToString(i);
            //    dependencys.Add(c);
            //}


            //lBoxDependency.DataSource = dependencys;
            //lBoxDependency.DisplayMember = "name";
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
            injected = Convert.ToInt16(tBoxInjected.Text);
        }

        private void tBoxState_TextChanged(object sender, EventArgs e) {
            state = Convert.ToInt16(tBoxState.Text);
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
            //lBoxDependency.Items.Add("Funkar nu !!");
            lBoxDependency.DataSource = null;
            lBoxDependency.DataSource = dependencys;
            lBoxDependency.DisplayMember = "Name";
            lBoxDependency.ValueMember = "Interfaces";
            
        }

        private void reset() {
            tBoxName.Text = "";
            tBoxInterface.Text = Convert.ToString(0);
            tBoxInjected.Text = Convert.ToString(0);
            tBoxState.Text = Convert.ToString(0);
        }

        private void lBoxDependency_SelectedIndexChanged(object sender, EventArgs e) {

        }

       

        
      
    }
}
