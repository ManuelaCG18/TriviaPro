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
        public int RespuestaCorrecta { get; protected set; }
        public string Categoria { get; protected set; }
        public string Nivel { get; protected set; }
        public int TiempoLimite { get; protected set; }


        
        public abstract int PuntajeCorrecto { get; } 
        public int PuntajeIncorrecto => -2;


        
        public Pregunta(string texto, List<string> opciones, int respuestaCorrecta, string categoria, string nivel)
        {
            Texto = texto ?? throw new ArgumentNullException(nameof(texto));
            Opciones = opciones ?? throw new ArgumentNullException(nameof(opciones));
            RespuestaCorrecta = respuestaCorrecta;
            Categoria = categoria ?? throw new ArgumentNullException(nameof(categoria));
            Nivel = nivel ?? throw new ArgumentNullException(nameof(nivel));

            if (opciones.Count < 2 || opciones.Count > 4)

                throw new ArgumentException("Debe haber entre 2 y 4 opciones");
        }

        

        public virtual bool EvaluarRespuesta(int respuestaSeleccionada)
        {
            return respuestaSeleccionada == RespuestaCorrecta;
        }
       
    }
}
