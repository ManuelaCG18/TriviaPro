using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro
{
    public class Jugador
    {
       
        public int Puntaje { get; private set; }
        public int PreguntasCorrectas { get; private set; }
        public int PreguntasIncorrectas { get; private set; }

        public void ActualizarPuntaje(int puntos)
        {
            Puntaje += puntos;
            if (Puntaje < 0) Puntaje = 0; 

            if (puntos > 0) PreguntasCorrectas++;
            else PreguntasIncorrectas++;
        }

        public void Reiniciar()
        {
            Puntaje = 0;
            PreguntasCorrectas = 0;
            PreguntasIncorrectas = 0;
        }
    }
}
