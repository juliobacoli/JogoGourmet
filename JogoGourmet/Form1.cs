using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace JogoGourmet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("O prato que você pensou é massa?", "Confirm", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                MessageBox.Show("O prato que você pensou é Lasanha?", "Confirm", MessageBoxButtons.YesNo);
                MessageBox.Show("Acertei de novo", "Jogo Gourmet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.GetCurrentProcess().Kill();
            }
            else if (result1 == DialogResult.No)
            {
                DialogResult result2 = MessageBox.Show("O prato que você pensou é bolo de chocolate?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    MessageBox.Show("Acertei de novo", "Jogo Gourmet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.GetCurrentProcess().Kill();
                }
                else if (result2 == DialogResult.No)
                {
                    Form2 f2 = new Form2();
                    f2.ShowDialog();

                }
            }


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
