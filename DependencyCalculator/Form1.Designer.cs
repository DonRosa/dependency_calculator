namespace DependencyCalculator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCalc = new System.Windows.Forms.Button();
            this.tBoxInterface = new System.Windows.Forms.TextBox();
            this.tBoxInjected = new System.Windows.Forms.TextBox();
            this.tBoxState = new System.Windows.Forms.TextBox();
            this.tBoxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lBoxDependency = new System.Windows.Forms.ListBox();
            this.btnDependency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(170, 414);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // tBoxInterface
            // 
            this.tBoxInterface.Location = new System.Drawing.Point(230, 90);
            this.tBoxInterface.Name = "tBoxInterface";
            this.tBoxInterface.Size = new System.Drawing.Size(35, 20);
            this.tBoxInterface.TabIndex = 2;
            this.tBoxInterface.TextChanged += new System.EventHandler(this.tBoxInterface_TextChanged);
            // 
            // tBoxInjected
            // 
            this.tBoxInjected.Location = new System.Drawing.Point(230, 127);
            this.tBoxInjected.Name = "tBoxInjected";
            this.tBoxInjected.Size = new System.Drawing.Size(35, 20);
            this.tBoxInjected.TabIndex = 3;
            this.tBoxInjected.TextChanged += new System.EventHandler(this.tBoxInjected_TextChanged);
            // 
            // tBoxState
            // 
            this.tBoxState.Location = new System.Drawing.Point(230, 165);
            this.tBoxState.Name = "tBoxState";
            this.tBoxState.Size = new System.Drawing.Size(35, 20);
            this.tBoxState.TabIndex = 4;
            this.tBoxState.TextChanged += new System.EventHandler(this.tBoxState_TextChanged);
            // 
            // tBoxResult
            // 
            this.tBoxResult.Location = new System.Drawing.Point(155, 388);
            this.tBoxResult.Name = "tBoxResult";
            this.tBoxResult.Size = new System.Drawing.Size(100, 20);
            this.tBoxResult.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Interfaces";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Injected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Static/global state";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "T(C)";
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(139, 51);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(100, 20);
            this.tBoxName.TabIndex = 13;
            this.tBoxName.TextChanged += new System.EventHandler(this.tBoxName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name of class";
            // 
            // lBoxDependency
            // 
            this.lBoxDependency.FormattingEnabled = true;
            this.lBoxDependency.Location = new System.Drawing.Point(12, 245);
            this.lBoxDependency.Name = "lBoxDependency";
            this.lBoxDependency.Size = new System.Drawing.Size(386, 108);
            this.lBoxDependency.TabIndex = 15;
            this.lBoxDependency.SelectedIndexChanged += new System.EventHandler(this.lBoxDependency_SelectedIndexChanged);
            // 
            // btnDependency
            // 
            this.btnDependency.Location = new System.Drawing.Point(84, 205);
            this.btnDependency.Name = "btnDependency";
            this.btnDependency.Size = new System.Drawing.Size(212, 23);
            this.btnDependency.TabIndex = 16;
            this.btnDependency.Text = "Add as a dependency";
            this.btnDependency.UseVisualStyleBackColor = true;
            this.btnDependency.Click += new System.EventHandler(this.btnDependency_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 474);
            this.Controls.Add(this.btnDependency);
            this.Controls.Add(this.lBoxDependency);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxResult);
            this.Controls.Add(this.tBoxState);
            this.Controls.Add(this.tBoxInjected);
            this.Controls.Add(this.tBoxInterface);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox tBoxInterface;
        private System.Windows.Forms.TextBox tBoxInjected;
        private System.Windows.Forms.TextBox tBoxState;
        private System.Windows.Forms.TextBox tBoxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lBoxDependency;
        private System.Windows.Forms.Button btnDependency;
    }
}

