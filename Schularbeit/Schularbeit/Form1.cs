using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Schularbeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void erstAuto_Click(object sender, EventArgs e)
        {
            textBox1.Text += Marke.Text;
            textBox1.Text += comboBox1.Text;
            textBox1.Text += PS.Text;
            textBox1.Text += Tankgröße.Text;
            textBox1.Text += Verbrauch.Text;

        }

        private void Tanken_Click(object sender, EventArgs e)
        {
            progressBar1.Value += Convert.ToInt32(Liter.Text);
        }

        private void fahren_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= Convert.ToInt32(fahrenkm.Text);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.MaximumSize = Convert.(Tankgröße.Text);
        }

    }
}
