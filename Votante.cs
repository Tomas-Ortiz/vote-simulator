using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_voto_electrónico
{
    class Votante      //Composición y dependencia con voto
    {
        private int edad;
        private String provincia, sexo; //atributos de cada votante
        private Voto voto;

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }   //getter y setter para utilizar estos atributos en otras clases

        public string Provincia
        {
            get
            {
                return provincia;
            }

            set
            {
                provincia = value;
            }
        }

        internal Voto Voto
        {
            get
            {
                return voto;
            }

            set
            {
                voto = value;
            }
        }

        //se setean los atributos de cada votante mediante el constructor
        public Votante(string provincia, string sexo, int edad)
        {
            this.provincia = provincia;
            this.sexo = sexo;
            this.edad = edad;  
        }

        public Votante(string provincia)
        {
            this.provincia = provincia;
        }

        public Votante()
        {

        }

        public void agregarVoto( int votanteID, string candidato)
        {
            Voto = new Voto(votanteID, candidato);  //se crea el voto del votante
        }

        //métodos estáticos ya que no se requiere almacenar ningún dato en el objeto
        public static void mostrarVoto(ArrayList votantes, ListView lista)
        {
            for (int i = 0; i < votantes.Count; i++)
            {

                        ListViewItem l = new ListViewItem("#" + ((Votante)votantes[i]).Voto.Votante_id);
                        l.SubItems.Add(((Votante)votantes[i]).Voto.Candidato);
                        l.SubItems.Add(((Votante)votantes[i]).Sexo);    //Se agregan los datos de cada votante
                        l.SubItems.Add(Convert.ToString(((Votante)votantes[i]).edad));
                        l.SubItems.Add(((Votante)votantes[i]).Provincia);
                                                
                        lista.Items.Add(l); //se agrega el objeto de listviewitem a la lista de la interfaz    
                }
            }


        public static void Prioridad_edad(ArrayList votantes, ListView lista)
        {
            if (votantes.Count == 0)
            {
                MessageBox.Show("Primero debe generar los resultados."," Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else { 
            //ordenado es una variable local que recibe el arreglo ordenado
            //El array se castea solo para objetos de tipo Votante
            //Se ordena de forma descendiente, el de mayor edad al principio de la lista
            var ordenado = votantes.Cast<Votante>().OrderByDescending(c => c.edad);   //c es un objeto de la clase Votante

            foreach (Votante c in ordenado) //el array ordenado se recorre con un foreach
            {
                ListViewItem l = new ListViewItem("#" + c.Voto.Votante_id);
                l.SubItems.Add(c.Voto.Candidato);
                l.SubItems.Add(c.Sexo);
                l.SubItems.Add(Convert.ToString(c.edad)); //se agrega los atributos como subitems a la lista
                l.SubItems.Add(c.Provincia);

                lista.Items.Add(l);
            }
          }
        }

        public static void Prioridad_sexo(ArrayList votantes, ListView lista)
        {
            if (votantes.Count == 0)
            {
                MessageBox.Show("Primero debe generar los resultados.", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var ordenado = votantes.Cast<Votante>().OrderBy(c => c.Sexo); 

                foreach (Votante c in ordenado)
                {
                    ListViewItem l = new ListViewItem("#" + c.Voto.Votante_id);
                    l.SubItems.Add(c.Voto.Candidato);
                    l.SubItems.Add(c.Sexo);
                    l.SubItems.Add(Convert.ToString(c.edad));
                    l.SubItems.Add(c.Provincia);

                    lista.Items.Add(l);
                }
            }
        }


        public static void Prioridad_provincia(ArrayList votantes, ListView lista)
        {
            if (votantes.Count == 0)
            {
                MessageBox.Show("Primero debe generar los resultados.", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var ordenado = votantes.Cast<Votante>().OrderBy(c => c.Provincia); 

                foreach (Votante c in ordenado)
                {
                    ListViewItem l = new ListViewItem("#" + c.Voto.Votante_id);
                    l.SubItems.Add(c.Voto.Candidato);
                    l.SubItems.Add(c.Sexo);
                    l.SubItems.Add(Convert.ToString(c.edad));
                    l.SubItems.Add(c.Provincia);

                    lista.Items.Add(l);
                }
            }
        }

        public static void Prioridad_candidato(ArrayList votantes, ListView lista)
        {

            if (votantes.Count == 0)
            {
                MessageBox.Show("Primero debe generar los resultados.", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var ordenado = votantes.Cast<Votante>().OrderBy(c => c.Voto.Candidato);  

                foreach (Votante c in ordenado)
                {
                    ListViewItem l = new ListViewItem("#" + c.Voto.Votante_id);
                    l.SubItems.Add(c.Voto.Candidato);
                    l.SubItems.Add(c.Sexo);
                    l.SubItems.Add(Convert.ToString(c.edad));
                    l.SubItems.Add(c.Provincia);

                    lista.Items.Add(l);
                }
            }


        }


    }
}
