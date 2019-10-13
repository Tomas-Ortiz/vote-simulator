using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_voto_electrónico
{
    class Excepcion
    {
        public static int error_vacio;  //atributo para llevar la cuenta la cantidad de errores  
        public static int error_formato;

        public Excepcion()
        {

        }

        public static void controlar(TextBox texto, string tipo)
        {

            if (texto.Text == "")   //si está vacio entonces
            {
                error_vacio++;
                texto.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                switch (tipo)
                {
                    case "int":
                        try
                        {
                            Convert.ToInt32(texto.Text);
                            texto.BackColor = System.Drawing.Color.White;
                        }
                        catch (FormatException) //si no se puede convertir entonces
                        {
                            error_formato++;
                            texto.BackColor = System.Drawing.Color.Red;
                        }

                        break;

                    case "string":

                        try
                        {
                            Convert.ToString(texto.Text);
                            texto.BackColor = System.Drawing.Color.White;

                        }
                        catch (FormatException)
                        {
                            error_formato++;
                            texto.BackColor = System.Drawing.Color.Red;
                        }

                        break;
                }
            }
        }

        public static void mostrarErrores() //muestra el popup con los errores en sus determinados campos
        {
            if(error_vacio>0 && error_formato==0)
            {
                MessageBox.Show("Rellene los campos marcados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(error_vacio == 0 && error_formato>0)
            {
                MessageBox.Show("Ingrese un formato válido para los campos marcados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(error_vacio>0 && error_formato>0)
            {
                MessageBox.Show("Campos marcados en rojo: ingrese un formato válido.\n Campos marcados en amarillo: ingrese un número. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
     }
}

