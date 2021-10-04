using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraPilas
{
    public partial class Form1 : Form
    {
        Pila pila = new Pila();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pila.insertar(Int32.Parse(textBox1.Text));
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pila.eliminar();
        }
    }
}
