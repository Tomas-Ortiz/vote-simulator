using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Simulador_voto_electrónico
{
    public partial class Principal : Form
    {
        //estos atributos son globales ya que se utilizan en varios métodos
        public ArrayList votantes = new ArrayList(); //arraylist que pertenece a la clase Votante
        public static ArrayList votos = new ArrayList();  //arraylist que pertenece a la clase Candidato
        public static int votantes_total = 0;
        public static string[] cand = new string[3]; 
        public static int id;
        Candidato c = new Candidato();
        Voto v = new Voto();
        public  int votantes_mendoza, votantes_bs, votantes_cord;

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
   
        private void BotSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //salir de la aplicación
        }

        private void BotGenerar_Click(object sender, EventArgs e)
        {

            int valor_porcentaje = 0; //valor del porcentaje
            borrar();   //se borran los registros anteriores, para generar nuevos resultados

            Excepcion.controlar(Texto1, "int"); //se controlan las excepciones de todos los textbox
            Excepcion.controlar(Texto2, "int");
            Excepcion.controlar(Texto3, "int");
            Excepcion.controlar(Cand1, "string");
            Excepcion.controlar(Cand2, "string");
            Excepcion.controlar(Cand3, "string");
            Excepcion.mostrarErrores(); //si existe algún error se muestra

            if (Excepcion.error_vacio == 0 && Excepcion.error_formato == 0)  //si no hay errores, entonces continua con la ejecución
                {

                    int  i;
                    string provincia, sexo, candidato;
                    int edad, votanteID;
                    string[] sexos = new string[2] { "M", "F" };

                    votantes_mendoza = Convert.ToInt32(Texto1.Text);
                    votantes_bs = Convert.ToInt32(Texto2.Text);   //votantes por provincia
                    votantes_cord = Convert.ToInt32(Texto3.Text);

                    votantes_total = votantes_bs + votantes_cord + votantes_mendoza; //total de votantes

                    cand[0] = Cand1.Text;
                    cand[1] = Cand2.Text;   //candidatos
                    cand[2] = Cand3.Text;


                    var seed = Environment.TickCount;//Metodo para obtener una semilla, basándose en los milisegundos del sistema
                    Random rand = new Random(seed); //seed es un entero de 32 bits (máx) que contiene los milisegundos

                    valor_porcentaje += (votantes_mendoza * 100 / votantes_total);

                    //los for se repiten según la canditdad de votantes por provincia
                    for (i = 0; i < votantes_mendoza; i++)  //Se sitúa fuera de los for para que no utilice la misma semilla
                    {
                        provincia = "Mendoza";  

                        edad = rand.Next(18, 71);
                        sexo = sexos[rand.Next(0, 2)]; //al num max se le suma uno, para que lo incluya
                        votanteID = id++;
                        candidato = cand[rand.Next(0, 3)];  //el id es secuencial y único para cada votante
                        Votante v = new Votante(provincia, sexo, edad);  //se instancia en cada ciclo, para crear espacios de memoria diferente

                        v.agregarVoto(votanteID, candidato);
                        votantes.Add(v);   //los objetos se van almacenando en el array, para después mostrarlos

                        c = new Candidato(votanteID, candidato, provincia);
                       
                        votos.Add(c); 
                        //se crea una instancia de la clase Candidato y un array para almacenar los votos de los candidatos 
                       //se pueden acceder a los votos mediante la clase Candidato o la clase Votante
                      //si se borra el objeto de la clase Votante o el objeto de la clase Candidato se borran los votos
                    }

                    //modifica el progreso de la barra
                    Barra_progreso.Value = valor_porcentaje;
                    System.Threading.Thread.Sleep(votantes_mendoza); //el programa se frena para mostrar el progeso de la barra

                    valor_porcentaje += (votantes_bs * 100 / votantes_total);

                    for (i = 0; i < votantes_bs; i++)
                    {
                        provincia = "Buenos Aires";

                        edad = rand.Next(18, 71);
                        sexo = sexos[rand.Next(0, 2)]; 
                        votanteID = id++;
                        candidato = cand[rand.Next(0, 3)];

                        Votante v = new Votante(provincia, sexo, edad);
                        v.agregarVoto(votanteID, candidato);

                        votantes.Add(v);

                        c = new Candidato(votanteID, candidato, provincia);

                        votos.Add(c);
                    }

                    Barra_progreso.Value = valor_porcentaje;
                    System.Threading.Thread.Sleep(votantes_bs);

                    for (i = 0; i < votantes_cord; i++)
                    {          
                        provincia = "Córdoba";

                        edad = rand.Next(18, 71);
                        sexo = sexos[rand.Next(0, 2)];
                        votanteID = id++;
                        candidato = cand[rand.Next(0, 3)];

                        Votante v = new Votante(provincia, sexo, edad);
                        v.agregarVoto(votanteID, candidato);

                        votantes.Add(v);

                        c = new Candidato(votanteID, candidato, provincia); 

                        votos.Add(c);
                    }

                    Barra_progreso.Value = 100;

                    if (Barra_progreso.Value == 100)  
                    {
                        Votante.mostrarVoto(votantes, ListaResultados);  //Al finalizar la generación de votantes, se muestran en la ListView                    
                    }         
              }
         }
        

        private void BotBorrar_Click(object sender, EventArgs e)
        {

            Texto1.Clear();
            Texto2.Clear();
            Texto3.Clear(); //se borran los textbox
            Cand1.Clear();
            Cand2.Clear();
            Cand3.Clear();

            borrar();   //se borran los demás elementos
        }


        private void BotOrdenar_sexo(object sender, EventArgs e)

        {
            ListaResultados.Items.Clear();  //se limpia la lista, para mostrarla después ordenada
            Votante.Prioridad_sexo(votantes,ListaResultados);   //metodo para ordenar el arraylist

            //La prioridad se establece según el sexo
        }

        private void BotOrdenar_edad(object sender, EventArgs e)
        {
            ListaResultados.Items.Clear();  
            Votante.Prioridad_edad(votantes, ListaResultados);  

            //La prioridad se establece según la edad
        }

        private void BotOrdenar_provincia(object sender, EventArgs e)
        {
            ListaResultados.Items.Clear();  
            Votante.Prioridad_provincia(votantes, ListaResultados);  

            //La prioridad se establece según la provincia
        }


        public void VotosCandidato_Click(object sender, EventArgs e)
        {
            if (votos.Count == 0)    //si el array está vacío entonces
            {
                MessageBox.Show("Primero debe generar los resultados.", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                c.votosPorCandidato(votos,cand); //se invoca el método para contar los votos por candidato
            }                                      
        }

        private void VotosTotales_Click(object sender, EventArgs e)
        {
            if (votantes.Count == 0)
            {
                MessageBox.Show("Primero debe generar los resultados.", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Voto.votosTotales(votantes,votantes_total);   //se cuentan los votos totales y los votos por sexo
            }
        }

        private void CandidatoGanador_Click(object sender, EventArgs e)
        {
            if (votantes.Count == 0)
            {
                MessageBox.Show("Primero debe generar los resultados.", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                c.candidatoGanador(cand); //se establece el candidato ganador, junto con sus votos
            }
        }

        private void BotCandidatoxProvincia_Click(object sender, EventArgs e)
        {
            if (votos.Count == 0)
            {
                MessageBox.Show("Primero debe generar los resultados.", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                c.candidatoPorProvincia(votos, cand);    //se cuentan los votos de cada candidato por provincia
            }

        }

        private void BotOrdenar_candidato_Click(object sender, EventArgs e)
        {
            ListaResultados.Items.Clear();
            Votante.Prioridad_candidato(votantes, ListaResultados);

            //La prioridad se establece según el candidato
        }

        private void verGrafico_Click(object sender, EventArgs e)
        {

            if (votantes.Count!=0)
            {
                //se crea una instancia de graficos y se le pasa por parámetros los datos necesarios

                Graficos a = new Graficos(votantes_total, cand);

                a.Show();   //muestra la ventana donde se encuentra el gráfico
            }
            else {
                MessageBox.Show("Primero debe generar los resultados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void borrar()
        {
            Texto1.BackColor = Color.White;
            Texto2.BackColor = Color.White;
            Texto3.BackColor = Color.White;
            Cand1.BackColor = Color.White;  //se borran algunos elementos necesarios al generar nuevos resultados
            Cand2.BackColor = Color.White;
            Cand3.BackColor = Color.White;

            ListaResultados.Items.Clear();
            votantes.Clear();
            votos.Clear();
            Excepcion.error_vacio = 0;
            Excepcion.error_formato = 0;
            Candidato.flag = false;
            votantes_total = 0;
            Barra_progreso.Value = 0;
            id = 0;

        }
    }
}
