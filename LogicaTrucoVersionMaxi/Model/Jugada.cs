using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaTrucoVersionMaxi.Model
{
    public class Jugada
    {
        public List<Carta> Jugador1 { get; set; }

        public List<Carta> Jugador2 { get; set; }

        public Carta CartaJugadaJugador1  { get; set; }

        public Carta CartaJugadaJugador2 { get; set; }

        public int PuntajeJ1 { get; set; } 

        public int PuntajeJ2 { get; set; }

        public int Ronda { get; set; }


    }
}
