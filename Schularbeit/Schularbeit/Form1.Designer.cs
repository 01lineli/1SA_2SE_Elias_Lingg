namespace Schularbeit
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Marke = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.erstAuto = new System.Windows.Forms.Button();
            this.Verbrauch = new System.Windows.Forms.TextBox();
            this.PS = new System.Windows.Forms.TextBox();
            this.Tankgröße = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.Tanken = new System.Windows.Forms.Button();
            this.Liter = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.fahrenkm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fahren = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Marke
            // 
            this.Marke.Location = new System.Drawing.Point(49, 42);
            this.Marke.Name = "Marke";
            this.Marke.Size = new System.Drawing.Size(100, 20);
            this.Marke.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.erstAuto);
            this.groupBox1.Controls.Add(this.Verbrauch);
            this.groupBox1.Controls.Add(this.PS);
            this.groupBox1.Controls.Add(this.Tankgröße);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Marke);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 312);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neues Auto erstellen";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rot",
            "Schwarz",
            "Grün",
            "Orange",
            "Blau",
            "Grau",
            "Weiß"});
            this.comboBox1.Location = new System.Drawing.Point(49, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // erstAuto
            // 
            this.erstAuto.Location = new System.Drawing.Point(170, 112);
            this.erstAuto.Name = "erstAuto";
            this.erstAuto.Size = new System.Drawing.Size(87, 23);
            this.erstAuto.TabIndex = 10;
            this.erstAuto.Text = "Auto erstellen";
            this.erstAuto.UseVisualStyleBackColor = true;
            this.erstAuto.Click += new System.EventHandler(this.erstAuto_Click);
            // 
            // Verbrauch
            // 
            this.Verbrauch.Location = new System.Drawing.Point(321, 69);
            this.Verbrauch.Name = "Verbrauch";
            this.Verbrauch.Size = new System.Drawing.Size(100, 20);
            this.Verbrauch.TabIndex = 9;
            // 
            // PS
            // 
            this.PS.Location = new System.Drawing.Point(49, 95);
            this.PS.Name = "PS";
            this.PS.Size = new System.Drawing.Size(100, 20);
            this.PS.TabIndex = 8;
            // 
            // Tankgröße
            // 
            this.Tankgröße.Location = new System.Drawing.Point(321, 39);
            this.Tankgröße.Name = "Tankgröße";
            this.Tankgröße.Size = new System.Drawing.Size(100, 20);
            this.Tankgröße.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tankgröße:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Verbrauch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "PS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Farbe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marke:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Tanken);
            this.groupBox2.Controls.Add(this.Liter);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 79);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tanken";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 45);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(251, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "liter";
            // 
            // Tanken
            // 
            this.Tanken.Location = new System.Drawing.Point(182, 17);
            this.Tanken.Name = "Tanken";
            this.Tanken.Size = new System.Drawing.Size(75, 23);
            this.Tanken.TabIndex = 12;
            this.Tanken.Text = "Tanken";
            this.Tanken.UseVisualStyleBackColor = true;
            this.Tanken.Click += new System.EventHandler(this.Tanken_Click);
            // 
            // Liter
            // 
            this.Liter.Location = new System.Drawing.Point(6, 19);
            this.Liter.Name = "Liter";
            this.Liter.Size = new System.Drawing.Size(100, 20);
            this.Liter.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fahren);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.fahrenkm);
            this.groupBox3.Location = new System.Drawing.Point(12, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 80);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fahren";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(275, 164);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 134);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // fahrenkm
            // 
            this.fahrenkm.Location = new System.Drawing.Point(6, 32);
            this.fahrenkm.Name = "fahrenkm";
            this.fahrenkm.Size = new System.Drawing.Size(100, 20);
            this.fahrenkm.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "km";
            // 
            // fahren
            // 
            this.fahren.Location = new System.Drawing.Point(182, 30);
            this.fahren.Name = "fahren";
            this.fahren.Size = new System.Drawing.Size(75, 23);
            this.fahren.TabIndex = 16;
            this.fahren.Text = "fahren";
            this.fahren.UseVisualStyleBackColor = true;
            this.fahren.Click += new System.EventHandler(this.fahren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 349);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Marke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button erstAuto;
        private System.Windows.Forms.TextBox Verbrauch;
        private System.Windows.Forms.TextBox PS;
        private System.Windows.Forms.TextBox Tankgröße;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Liter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Tanken;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button fahren;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fahrenkm;
    }
}

