using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtN1.Text, out decimal num1) && decimal.TryParse(txtN2.Text, out decimal num2))
            {
                if(num1 > num2)
                {
                    txtMaior.Text = num1.ToString();
                    txtMenor.Text = num2.ToString();
                }
                else
                {
                    txtMaior.Text = num2.ToString();
                    txtMenor.Text = num1.ToString();
                }
            }
            else
            {
                MessageBox.Show("Valor inválido!");
            }
        }
    }
}
