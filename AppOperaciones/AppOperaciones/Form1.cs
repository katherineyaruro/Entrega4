using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppOperaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            float num1, num2, suma, resta, multiplicacion, division;
            num1 = float.Parse(txtNumero1.Text);
            num2 = float.Parse(txtNumero2.Text);
            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = num1 / num2;
            if (rdbSumar.Checked == true)
                lblResultado.Text = suma.ToString();
            if (rdbRestar.Checked == true)
                lblResultado.Text = resta.ToString();
            if (rdbMultiplicar.Checked == true)
                lblResultado.Text = multiplicacion.ToString();
            if (rdbDividir.Checked == true)
                lblResultado.Text = division.ToString();
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
