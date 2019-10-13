using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Simulador_voto_electrónico
{
    class Provincia //
    {

        private String nombre, candidato_ganador;
        private int porcentaje;

        ArrayList votantesP = new ArrayList();

        public Provincia(string nombre, string candidato_ganador, int porcentaje)
        {
            this.nombre = nombre;
            this.candidato_ganador = candidato_ganador;
            this.porcentaje = porcentaje;
        }

        public Provincia()
        {

        }





    }
}
