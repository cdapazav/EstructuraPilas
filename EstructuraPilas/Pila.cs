using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraPilas
{
    class Pila
    {
        static int maxpila = 5;
        public int tope;
        public int[] lista;

        public Pila() 
        {
            tope = -1;
            lista = new int[maxpila];
        }

        private bool vacia()
        {
            if (tope == -1)
                return true;
            else
                return false;
         }
        
        private bool llena() 
        {
            if (tope == maxpila - 1)
                return true;
            else
                return false;
        }

        public void insertar(int elemento)
        {
            if (llena())
                MessageBox.Show("La pila esta llena, no se puede insertar mas elementos");
            else
            {
                tope++;
                lista[tope] = elemento;
            }
        }

        public void eliminar()
        {
            if (vacia())
                MessageBox.Show("La pila esta vacia, no se puede eliminar elementos");
            else
            {
                MessageBox.Show("Elemento eliminado es: " + lista[tope]);
                tope--;
            }
        }
    }
}
