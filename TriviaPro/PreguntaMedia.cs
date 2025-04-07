using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro
{
    public class PreguntaMedia : Pregunta
    {
        public override int PuntajeCorrecto => 10;

        public PreguntaMedia(string texto, List<string> opciones, int respuestaCorrecta, string categoria)
            : base(texto, opciones, respuestaCorrecta, categoria, "Media")
        {
            TiempoLimite = 15; // 15seg para medias
        }
    }
}
