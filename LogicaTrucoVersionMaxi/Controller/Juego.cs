using LogicaTrucoVersionMaxi.Model;
using System.Collections.Generic;

namespace LogicaTrucoVersionMaxi
{
    public class Juego
    {
        public Jugador Jugador1 { get; set; }

        public Jugador Jugador2 { get; set; }

        public Mazo Mazo { get; set; }

        public List<Jugada> Rondas { get; set; } = new List<Jugada>();

        public Jugador GanadorMano { get; set; }


    
        public Juego()
        {
            Jugador1 = new Jugador();
            Jugador2 = new Jugador();
            Mazo = new Mazo();
            GanadorMano = default(Jugador);
            Jugador1.Nombre = "Jugador1";
            Jugador2.Nombre = "Jugador2";
        }

            public void CalcularGanadorRonda(Jugada jugada)
            {
             var jugadaFinal = jugada;

            if (jugadaFinal.CartaJugadaJugador1 != null && jugadaFinal.CartaJugadaJugador2 != null)
            {
                if (jugadaFinal.CartaJugadaJugador1.Puntaje < jugadaFinal.CartaJugadaJugador2.Puntaje)
                {
                    jugadaFinal.PuntajeJ1++;
                }
                else if (jugadaFinal.CartaJugadaJugador1.Puntaje > jugadaFinal.CartaJugadaJugador2.Puntaje)
                {
                    jugadaFinal.PuntajeJ2++;
                }
                else
                {
                    if(jugadaFinal.PuntajeJ1 == 0 && jugadaFinal.PuntajeJ2 == 0 && jugadaFinal.CartaJugadaJugador1.Puntaje == jugadaFinal.CartaJugadaJugador2.Puntaje)
                    {
                        jugadaFinal.PuntajeJ1++;
                        jugadaFinal.PuntajeJ2++;
                    }
                }
                var nuevaJugada = new Jugada();
                nuevaJugada.Ronda = jugadaFinal.Ronda+1;
                nuevaJugada.PuntajeJ1 = jugadaFinal.PuntajeJ1;
                nuevaJugada.PuntajeJ2 = jugadaFinal.PuntajeJ2;
                nuevaJugada.Jugador1 = new List<Carta>(this.Jugador1.Cartas);
                nuevaJugada.Jugador2 = new List<Carta>(this.Jugador2.Cartas);
                this.Rondas.Add(nuevaJugada);
                CalcularGanador(nuevaJugada);
            }


        }
        public void CalcularGanador(Jugada jugada)
        {
            if(jugada.PuntajeJ1 == 2 )
            {
                this.Jugador1.Puntaje++;
                GanadorMano = this.Jugador1;
            }

            if (jugada.PuntajeJ2 == 2)
            {
                this.Jugador2.Puntaje++;
                GanadorMano = this.Jugador2;
            }
            
        }

    }


}

