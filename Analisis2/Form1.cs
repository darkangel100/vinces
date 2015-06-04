using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analisis2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            Registro regis = new Registro();
            regis.ShowDialog();
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

        }

     
    }
}
