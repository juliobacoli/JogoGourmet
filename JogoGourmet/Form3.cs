using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoGourmet
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string parametro) : this()
        {
            label1.Text = parametro;
        }

        public string Parametro
        {
            get { return textBox1.Text; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{textBox1.Text} é ____________ mas Bolo de Chocolate não.", "Complete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
