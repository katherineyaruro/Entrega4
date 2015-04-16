using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppColores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "   ";
            if (chkOpcion1.Checked == true)
            {
                Text = Text + "Rosa";
            }
            if (chkOpcion2.Checked == true)
            {
                Text = Text + "Azul";
            }
            if (chkOpcion3.Checked == true)
            {
                Text = Text + "Rojo";
            }
        }
    }
}
