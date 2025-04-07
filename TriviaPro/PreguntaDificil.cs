using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro
{
    public class PreguntaDificil : Pregunta
    {
        public override int PuntajeCorrecto => 15;

        public PreguntaDificil(string texto, List<string> opciones, int respuestaCorrecta, string categoria)
            : base(texto, opciones, respuestaCorrecta, categoria, "Dificil")
        {
            TiempoLimite = 10; // 10seg para dificiles
        }
    }
}
