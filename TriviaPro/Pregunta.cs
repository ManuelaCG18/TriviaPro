using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro
{
    public abstract class Pregunta
    {
        public string Texto {  get; protected set; }
        public List<string> Opciones { get; protected set; }
        public string RespuestaCorrecta { get; protected set; }
        public string Categoria { get; protected set; }

        public string Nivel { get; protected set; }

        public int TiempoLimite { get; protected set; }

        public abstract int PuntajeCorrecto { get; }
        public int PuntajeIncorrecto => -2;

    }
}
