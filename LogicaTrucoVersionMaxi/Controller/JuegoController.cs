using LogicaTrucoVersionMaxi.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicaTrucoVersionMaxi.Controller
{
    public class JuegoController
    {
        private readonly Juego juego;

        public JuegoController(Juego juego)
        {
            this.juego = juego;
        }
        public void Jugar()
        {
            juego.Mazo.CargarMazo();
            var indice = new Random();
            juego.Jugador1.Cartas = juego.Mazo.RepartirCartas(indice);
            juego.Jugador2.Cartas = juego.Mazo.RepartirCartas(indice);
            /*
            juego.Jugador1.Cartas = juego.Mazo.Cartas.Where(x => x.Puntaje == 13).Take(2).ToList();
            juego.Jugador2.Cartas = juego.Mazo.Cartas.Where(x=>x.Puntaje==13).Take(2).ToList();
            juego.Jugador1.Cartas.Add( juego.Mazo.Cartas.First(x => x.Puntaje == 1));
            juego.Jugador2.Cartas.Add(juego.Mazo.Cartas.First(x => x.Puntaje == 2));
            */
            var jugada = new Jugada();
            jugada.Jugador1 = new List<Carta>(juego.Jugador1.Cartas);
            jugada.Jugador2 = new List<Carta>(juego.Jugador2.Cartas);
            juego.Rondas.Add(jugada);

        }


        public Jugada JugadaActual()
        {
            return juego.Rondas.Last();
        }

        public Jugador ObtenerGanador()
        {
            return juego.GanadorMano;
        }

        public List<Jugada> GanadorPorRonda()

        {
            var retorno = new List<Jugada>();
            foreach (var ronda in juego.Rondas)
            {
                if(ronda.CartaJugadaJugador1 != null && ronda.CartaJugadaJugador2 != null)
                {
                    retorno.Add(ronda);
                }
            }
            return retorno;
        }
        public void JugadorJuega(int jugador,Carta carta)
        {
            var jugada = juego.Rondas.Last();
            if(jugador==1 && jugada.CartaJugadaJugador1 == null)
            {
                juego.Jugador1.Cartas.Remove(carta);
                jugada.Jugador1 = new List<Carta>(juego.Jugador1.Cartas);
                jugada.Jugador2 = new List<Carta>(juego.Jugador2.Cartas);
                jugada.CartaJugadaJugador1 = carta;
                
            }
            if (jugador == 2 && jugada.CartaJugadaJugador2 == null)
            {
                juego.Jugador2.Cartas.Remove(carta);
                jugada.Jugador1 = new List<Carta>(juego.Jugador1.Cartas);
                jugada.Jugador2 = new List<Carta>(juego.Jugador2.Cartas);
                jugada.CartaJugadaJugador2 = carta;
            }

            juego.CalcularGanadorRonda(jugada);
        }

    }
}
