using System;
using System.Windows.Forms;

namespace TriviaPro
{
    public class TemporizadorTrivia
    {
        /*
        private Timer timer;
        private int tiempoRestante;
        private Action onTimeUp;

        public int TiempoRestante => tiempoRestante;

        public TemporizadorTrivia(int tiempoInicial, Action callback)
        {
            onTimeUp = callback;
            tiempoRestante = tiempoInicial;

            timer = new Timer();
            timer.Interval = 1000; // 1 segundo

            timer.Tick += (s, e) =>
            {
                tiempoRestante--;
                if (tiempoRestante <= 0)
                {
                    timer.Stop();
                    onTimeUp?.Invoke();
                }
            };
        }

        public void Iniciar() => timer.Start();
        public void Detener() => timer.Stop();
        public void Reiniciar(int nuevoTiempo)
        {
            tiempoRestante = nuevoTiempo;
            timer.Stop();
        }
        */
    }
}
