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


        public Form1() {
            InitializeComponent();
            depMet = new DepMetric();
            textBox1.Text = Convert.ToString(0);
            textBox2.Text = Convert.ToString(0);
            textBox3.Text = Convert.ToString(0);
            textBox4.Text = Convert.ToString(0);
            textBox6.Text = Convert.ToString(0);

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            try {
                depMet.cn = Convert.ToInt16(textBox1.Text);
            } catch(FormatException) {
                depMet.cn = 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            try {
                depMet.cf = Convert.ToInt16(textBox2.Text);
            } catch {
                depMet.cf = 0;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {
            try {
                depMet.cj = Convert.ToInt16(textBox3.Text);
            } catch {
                depMet.cj = 0;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {
            try {
                depMet.cs = Convert.ToInt16(textBox4.Text);
            } catch {
                depMet.cs = 0;
            }
        }


        private void textBox6_TextChanged(object sender, EventArgs e) {
            try {
                depMet.n = Convert.ToInt16(textBox6.Text);
            } catch {
                depMet.n = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            textBoxResult.Text = Convert.ToString(depMet.calcMetric());
            textBox1.Text = Convert.ToString(depMet.cn);
            textBox2.Text = Convert.ToString(depMet.cf);
            textBox3.Text = Convert.ToString(depMet.cj);
            textBox4.Text = Convert.ToString(depMet.cs);
            textBox6.Text = Convert.ToString(depMet.n);
        }

        private void button2_Click(object sender, EventArgs e) {

        }
        
      
    }
}
