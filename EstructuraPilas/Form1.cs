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
        public void mostrarPila()
        {
            listView1.Clear();
            for(int i=0; i<=pila.tope; i++)
            {
                listView1.Items.Add(pila.lista[i].ToString());
            }
        }

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
            mostrarPila();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pila.eliminar();
            mostrarPila();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExpresionMatematica expresionMatematica = new ExpresionMatematica();
            expresionMatematica.evaluar_Parentesis(textBox2.Text);
        }
    }
}
