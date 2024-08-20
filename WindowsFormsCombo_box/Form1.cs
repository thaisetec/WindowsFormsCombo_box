using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCombo_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboLista.Items.Add(txtTexto.Text);
            lblqtde.Text=cboLista.Items.Count.ToString();
            txtTexto.Clear();
            txtTexto.Select();
            

        

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cboLista.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cboLista.SelectedIndex != -1) 
            {txtConteudo.Text
        }
    }
}
