using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_voto_electrónico
{
    class Voto      
    {
        private int votante_id;
        private string candidato;   //atributos de cada votante

        public string Candidato
        {
            get
            {
                return candidato;
            }

            set
            {
                candidato = value;
            }
        }   //getters y setters para poder utilizar estos atributos en otras clases

        public int Votante_id
        {
            get
            {
                return votante_id;
            }

            set
            {
                votante_id = value;
            }
        }

        public Voto()
        {

        }

        public Voto(int votante_id, string candidato)
        {
            Votante_id = votante_id;   //atributos que le pertenecen a cada votante
            Candidato = candidato;
        }

        public static void votosTotales(ArrayList votantes, int votosTotales) //se cuentan los votos por sexo
        {
            int votosF = 0, votosM = 0;

            for(int i=0; i<votantes.Count; i++)
            {
                    if ((((Votante)votantes[i]).Sexo) == "M")
                    {
                        votosM++;
                    }
                    else if ((((Votante)votantes[i]).Sexo) == "F")
                    {
                        votosF++;
                   }              
            }
            //se muestran los votos por sexo
            MessageBox.Show("Votos totales: "+votosTotales+"\n \nVotos femeninos: "+votosF+"\nVotos masculinos: "+votosM , "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

