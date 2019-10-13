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
    public partial class Graficos : Form
    {
       private static int[] VotosxCandidato = new int[3];
       private int votantes_total;
        private string[] candidatos = new string[3];
       
        public Graficos(int votantes_total,string [] candidatos)
        {
            InitializeComponent();

            this.votantes_total = votantes_total;
                                                    //se setean el nombre de los candidatos y los votos totales
            for (int i=0; i<3; i++)
            {
                this.candidatos[i] = candidatos[i];
            }

            mostrarGrafico();
        }

        private void mostrarGrafico()
        {
            votosPorCandidato(Principal.votos, Principal.cand); //se establecen los votos por candidato

            for (int i = 0; i < 3; i++) 
            {
                //grafico es el nombre del gráfico
                //se realiza regla de 3 simple para calcular el porcentaje

                //se le coloca el titulo a cada barra (candidato[i]) y su valor en porcentaje
                grafico.Series["Porcentaje"].Points.AddXY(candidatos[i], VotosxCandidato[i] * 100 / votantes_total);

                //Series es el conjunto de valores que conforman el gráfico y points es un valor en un punto XY
                //Porcentaje  es el nombre que representa a las barras del gráfico
                //X es el valor de texto para el eje X, e Y es el valor numérico para el eje Y

            }

            grafico.Show(); //una vez realizado los cálculos, se muestra el gráfico   

        }

        private void votosPorCandidato(ArrayList Votos, string[] candidatos)
        {
           
            for (int i = 0; i < 3; i++)
            {
                VotosxCandidato[i] = 0;//resetea los votos por candidatos
            }

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

        }

    }
}
        

