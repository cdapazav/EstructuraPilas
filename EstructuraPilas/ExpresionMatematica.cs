using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraPilas
{
    class ExpresionMatematica
    {
        public void evaluar_Parentesis(string expresion)
        {
            Pila pila = new Pila();
            int contadorAbre = 0;
            int contadorCierra = 0;

            for(int i=0; i<=expresion.Length-1;i++)
            {
                if(expresion.Substring(i,1)=="(")
                {
                    pila.insertar(Convert.ToChar(expresion.Substring(i, 1)));
                    contadorAbre++;
                }
                else
                {
                    if(expresion.Substring(i,1)==")")
                    {
                        pila.eliminar();
                        contadorCierra++;
                    }
                }
            }
            if (pila.vacia() && contadorAbre == contadorCierra)
                MessageBox.Show("La expresion evaluada es correcta");
            else
                MessageBox.Show("La expresion evaluada es incorrecta");
        }
    }
}
