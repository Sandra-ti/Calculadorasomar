using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_SIMPLES
{
    public partial class FormCalcular : Form
    {
        public FormCalcular()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTResultado_Click(object sender, EventArgs e)
        {
            int num1, num2, soma;
            num1 = Convert.ToInt16(tBNum1.Text);
            num2 = Convert.ToInt16(tBNum2.Text);
            soma = num1 + num2;
            lBResposta.Text = Convert.ToString(soma);
        }
    }
}
