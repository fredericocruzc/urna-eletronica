using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urnaEletronica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarDigito("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarDigito("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrarDigito("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistrarDigito("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistrarDigito("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrarDigito("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegistrarDigito("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegistrarDigito("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RegistrarDigito("9");
        }

        private void buttonBranco_Click(object sender, EventArgs e)
        {
            RegistrarDigito("branco");
        }

        private void buttonCorrige_Click(object sender, EventArgs e)
        {
            RegistrarDigito("corrige");
        }

        private void buttonConfirma_Click(object sender, EventArgs e)
        {
            RegistrarDigito("confirma");
        }
        private void RegistrarDigito (string digito)
        {
            if (string.IsNullOrEmpty(txtPrefeito1.Text))
                txtPrefeito1.Text = digito;
            else
            {
                txtPrefeito2.Text = digito;
                PreencherCandidato(txtPrefeito1.Text, txtPrefeito2.Text);
            }
        }
    }
}
