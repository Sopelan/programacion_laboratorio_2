using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Para este formulario desarrollar una aplicación capaz de, dado un cierto texto, mostrarle al usuario:
    1. Cantidad de palabras (muestra en lblCantPalabras).
    2. Cantidad de palabras finalizadas con subcadena “la” (letra A seguida por un espacio) (muestra en lblCantAEspacio). 
    3. Las primeras 20 palabras (muestra en txtResultado) 
    4. Las primeras 100 letras (muestra en txtResultado)
    5. Programar un método llamado buscarPalabraFinalizadaEn(string, short) que reciba como parámetros con que cadena finalizan las palabras a encontrar y cuántas de ellas se desea obtener; siendo capaz de:
        1. Encontrar las primeras 3 palabras finalizadas con “a ” (letra A seguida por un espacio) (muestra en txtResultado). 
        2. Encontrar las primeras 3 palabras finalizadas con “o ” (letra O seguida por un espacio) (muestra en txtResultado). */
namespace clase_06
{
    public partial class cuadro : Form
    {
        public cuadro()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool flag = true;
            int cantPalabras = 0;
            for (int i = 0; i < txtResultado.Text.Length; i++)
            {
                if (i == 0 && txtResultado.Text[i] != ' ')
                {
                    cantPalabras = 1;
                    continue;
                }

                if (flag == true)
                {
                    if (txtResultado.Text[i] == ' ')
                    {
                        flag = false;
                    }

                }
                else
                {
                    if (txtResultado.Text[i] != ' ')
                    {
                        cantPalabras++;
                        flag = true;
                    }
                }
                if (cantPalabras == 21)
                {
                    break;
                }
                sb.Append(txtResultado.Text[i]);
            }
            rtxtTexto.Items.Clear();
            rtxtTexto.Items.Add(sb);
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            int cantPalabras = 0;
            bool flag2 = true ;
            for (int i = 0; i < txtResultado.Text.Length; i++)
            {
                if (i == 0 && txtResultado.Text[i] != ' ')
                {
                    cantPalabras = 1;
                    continue;
                }
                if (flag2 == true)
                {
                    if (txtResultado.Text[i] == ' ')
                    {
                        flag2 = false;
                    }

                }
                else
                {
                    if (txtResultado.Text[i] != ' ')
                    {
                        cantPalabras++;
                        flag2 = true;
                    }
                }   
            }
                lblCantPalabras.Text = cantPalabras.ToString();
        
            int cant = 0;
            bool flag = false;
            for(int i = 0; i < txtResultado.Text.Length; i++)
            {
                if (flag == true)
                {
                    if (txtResultado.Text[i] == ' ')
                        cant++;
                    else
                        flag = false;
                }
                if (txtResultado.Text[i] == 'a')
                {
                    flag = true;
                }
                if(txtResultado.Text[i] == 'A')
                {
                    flag = true;
                }
               
            }
            lblCantFinalizaLA.Text = cant.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < txtResultado.Text.Length; i++)
            {
                if (i == 100)
                {
                    break;
                }
                sb.Append(txtResultado.Text[i]);
            }
            rtxtTexto.Items.Clear();
            rtxtTexto.Items.Add(sb);
        }
        private string buscarPalabras(string str,short s)
        {
            StringBuilder sb = new StringBuilder();
            bool flag = true;
            int cantPalabras = 0;
            for (int i = 0; i < txtResultado.Text.Length; i++)
            {
                if (i == 0 && txtResultado.Text[i] != ' ')
                {
                    cantPalabras = 1;
                    continue;
                }

                if (flag == true)
                {
                    if (txtResultado.Text[i] == ' ')
                    {
                        flag = false;
                    }

                }
                else
                {
                    if (txtResultado.Text[i] != ' ')
                    {
                        cantPalabras++;
                        flag = true;
                    }
                }
                sb.Append(txtResultado.Text[i]);
            }
            rtxtTexto.Items.Clear();
            rtxtTexto.Items.Add(sb);

            return sb.ToString();
        }
    
    }
}
