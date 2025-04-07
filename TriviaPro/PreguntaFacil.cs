using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro
{
    public class PreguntaFacil : Pregunta
    {
        public override int PuntajeCorrecto => 5;

        public PreguntaFacil(string texto, List<string> opciones, int respuestaCorrecta, string categoria)
            : base(texto, opciones, respuestaCorrecta, categoria, "Facil")
        {
            TiempoLimite = 20; // 2oseg para faciles
        }
    }
}
