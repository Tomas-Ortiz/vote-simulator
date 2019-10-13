using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Simulador_voto_electrónico
{
    class Candidato //composición con voto
    {
        private int[] VotosxCandidato = new int[3]; //se almacenan los votos de cada candidato
        private int[] candMendoza = new int[3];
        private int[] candBuenosAires = new int[3]; //se almacenan los votos de cada candidato por provincia
        private int[] candCordoba = new int[3];
        int[] votosProvincia = new int[9];  //bandera utilizada para el contador de votos de cada votante x provincia
        
        private string CandidatoGanador;    //se alamcena el candidato ganador
        public static bool flag = false;
        private Voto voto;
        private Votante votante;

        public Candidato()
        {

        }
 
        public Candidato(int votanteid, string candidato, string Provincia)
        {
            Voto = new Voto(votanteid, candidato);  //se establece el id del votante y el candidato que votó
            votante = new Votante(Provincia);   //se establece la provincia a la que pertenece el votante
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

        public void borrarDatos()  //se reincian los datos 
        {
            for (int j = 0; j < 3; j++)
            {
                VotosxCandidato[j] = 0;
                candMendoza[j] = 0;
                candBuenosAires[j] = 0;
                candMendoza[j] = 0;             
             }

            for(int i=0; i<9; i++)
            {
                votosProvincia[i] = 0;
            }

        }

        public void votosPorCandidato(ArrayList Votos, String[] candidatos)
        {
          flag = true;    //bandera usada para saber si antes de pulsar el candidatoganador pulsó este boton
          borrarDatos();    //se borran los datos anteriores

            for (int i = 0; i < Votos.Count; i++)
            {
                
                    if ((((Candidato)Votos[i]).Voto.Candidato) == candidatos[0])  //cuenta la cantidad de votos por candidato
                    {        
                        VotosxCandidato[0]++;
                    }
                    else if ((((Candidato)Votos[i]).Voto.Candidato) == candidatos[1])
                    {
                        VotosxCandidato[1]++;
                    }
                    else if ((((Candidato)Votos[i]).Voto.Candidato) == candidatos[2])
                    {
                        VotosxCandidato[2]++;
                    }            
            }
                //se muestran los votos por candidato
            MessageBox.Show("Votos por candidato: \n \n" + candidatos[0] + ": " + VotosxCandidato[0] + " votos   \n" + candidatos[1] + ": " + VotosxCandidato[1] + " votos   \n" + candidatos[2] + ": " + VotosxCandidato[2] + " votos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);       

        }

        public void candidatoGanador(String [] candidatos)
        {
            bool empate = false; //variable seguro para caso de un empate

            if (flag == true)
            {

                if (VotosxCandidato[0] == VotosxCandidato[1] && VotosxCandidato[1] == VotosxCandidato[2]) {

                    MessageBox.Show("Hubo un empate", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    empate = true;
                } 

               if (empate !=true) { //si no hay empate sigue a comparar

                   int mayorVoto = 0;

                    for (int i = 0; i < 3; i++)
                    {

                        if (VotosxCandidato[i] > mayorVoto) //se busca en el arreglo el candidato que obtuvo más votos
                    {
                        mayorVoto = VotosxCandidato[i];
                        CandidatoGanador = candidatos[i];
                    }
                }
                //se muestra el candidato ganador
                MessageBox.Show("Candidato ganador: \n \n"+CandidatoGanador+", con "+mayorVoto+" votos totales.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
            else
            {   
                MessageBox.Show("Debe presionar primero el botón: votos por candidato.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   //debe presionar antes ese boton ya que ese boton realiza los cálculos necesarios que se usan en este boton
                //de esta manera evito realizar el mismo cálculo dos veces
        }

        public void candidatoPorProvincia(ArrayList Votos, String[] candidatos)
        {
            borrarDatos(); 

            for (int i = 0; i < Votos.Count; i++)
            {
               
                    if ((((Candidato)Votos[i]).votante.Provincia) == "Mendoza") 
                    {
                        //se cuentan la cantidad de votos por candidato por provincia
                        if ((((Candidato)Votos[i]).Voto.Candidato) == candidatos[0])
                        {
                            candMendoza[0] = ++votosProvincia[0];
                        }
                        else if ((((Candidato)Votos[i]).Voto.Candidato) == candidatos[1])
                        {
                            candMendoza[1] = ++votosProvincia[1];
                        }
                        else if ((((Candidato)Votos[i]).Voto.Candidato) == candidatos[2])
                        {
                            candMendoza[2] = ++votosProvincia[2]; 
                        }
                    }
                    else if (((((Candidato)Votos[i]).votante.Provincia) == "Buenos Aires"))
                    {
                        if ((((Candidato)Votos[i]).Voto.Candidato) == candidatos[0])
                        {
                            candBuenosAires[0] = ++votosProvincia[3];
                        }
                        else if ((((Candidato)Votos[i]).Voto.Candidato) == candidatos[1])
                        {
                            candBuenosAires[1] = ++votosProvincia[4];
                        }
                        else if ((((Candidato)Votos[i]).Voto.Candidato) == candidatos[2])
                        {
                            candBuenosAires[2] = ++votosProvincia[5];
                        }
                    }
                    else if (((((Candidato)Votos[i]).votante.Provincia) == "Córdoba"))
                    {
                        if ((((Candidato)Votos[i]).Voto.Candidato) == candidatos[0])
                        {
                            candCordoba[0] = ++votosProvincia[6];
                        }
                        else if ((((Candidato)Votos[i]).Voto.Candidato) == candidatos[1])
                        {
                            candCordoba[1] = ++votosProvincia[7];
                        }
                        else if ((((Candidato)Votos[i]).Voto.Candidato) == candidatos[2])
                        {
                            candCordoba[2] = ++votosProvincia[8];
                        }
                    }        
            }

            MessageBox.Show(" Mendoza: \n \n " + candidatos[0] + ": " + candMendoza[0]+" votos." + "\n " + candidatos[1] + ": " + candMendoza[1]+ " votos." + "\n " + candidatos[2] + ": " + candMendoza[2] + " votos." + "\n \n Buenos Aires: \n \n " + candidatos[0] + ": " + candBuenosAires[0] + " votos." + "\n " + candidatos[1] + ": " + candBuenosAires[1] + " votos." + "\n " + candidatos[2] + ": " + candBuenosAires[2] + " votos." + "\n \n Córdoba: \n \n " + candidatos[0] + ": " + candCordoba[0] + " votos." + "\n " + candidatos[1] + ": " + candCordoba[1] + " votos." + "\n " + candidatos[2] + ": " + candCordoba[2] + " votos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
