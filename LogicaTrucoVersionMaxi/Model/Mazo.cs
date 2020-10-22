using System;
using System.Collections.Generic;

namespace LogicaTrucoVersionMaxi
{
   
        public class Mazo
        {
            public List<Carta> Cartas { get; set; }

            public void CargarMazo()
            {
                Cartas = new List<Carta>();

                Cartas.Add(new Carta()
                {
                    Numero = 1,
                    Palo = "Espada",
                    Puntaje = 1
                });
                Cartas.Add(new Carta()
                {
                    Numero = 1,
                    Palo = "Basto",
                    Puntaje = 2
                });
                Cartas.Add(new Carta()
                {
                    Numero = 7,
                    Palo = "Espada",
                    Puntaje = 3
                });
                Cartas.Add(new Carta()
                {
                    Numero = 7,
                    Palo = "Oro",
                    Puntaje = 4
                });
                Cartas.Add(new Carta()
                {
                    Numero = 3,
                    Palo = "Espada",
                    Puntaje = 5
                });
                Cartas.Add(new Carta()
                {
                    Numero = 3,
                    Palo = "Oro",
                    Puntaje = 5
                });
                Cartas.Add(new Carta()
                {
                    Numero = 3,
                    Palo = "Basto",
                    Puntaje = 5
                });
                Cartas.Add(new Carta()
                {
                    Numero = 3,
                    Palo = "Copa",
                    Puntaje = 5
                });
                Cartas.Add(new Carta()
                {
                    Numero = 2,
                    Palo = "Espada",
                    Puntaje = 6
                });
                Cartas.Add(new Carta()
                {
                    Numero = 2,
                    Palo = "Oro",
                    Puntaje = 6
                });
                Cartas.Add(new Carta()
                {
                    Numero = 2,
                    Palo = "Basto",
                    Puntaje = 6
                });
                Cartas.Add(new Carta()
                {
                    Numero = 2,
                    Palo = "Copa",
                    Puntaje = 6
                });
                Cartas.Add(new Carta()
                {
                    Numero = 1,
                    Palo = "Oro",
                    Puntaje = 7
                });
                Cartas.Add(new Carta()
                {
                    Numero = 1,
                    Palo = "Copa",
                    Puntaje = 7
                });
                Cartas.Add(new Carta()
                {
                    Numero = 12,
                    Palo = "Espada",
                    Puntaje = 8
                });
                Cartas.Add(new Carta()
                {
                    Numero = 12,
                    Palo = "Oro",
                    Puntaje = 8
                });
                Cartas.Add(new Carta()
                {
                    Numero = 12,
                    Palo = "Basto",
                    Puntaje = 8
                });
                Cartas.Add(new Carta()
                {
                    Numero = 12,
                    Palo = "Copa",
                    Puntaje = 8
                });
                Cartas.Add(new Carta()
                {
                    Numero = 11,
                    Palo = "Espada",
                    Puntaje = 9
                });
                Cartas.Add(new Carta()
                {
                    Numero = 11,
                    Palo = "Oro",
                    Puntaje = 9
                });
                Cartas.Add(new Carta()
                {
                    Numero = 11,
                    Palo = "Basto",
                    Puntaje = 9
                });
                Cartas.Add(new Carta()
                {
                    Numero = 11,
                    Palo = "Copa",
                    Puntaje = 9
                });
                Cartas.Add(new Carta()
                {
                    Numero = 10,
                    Palo = "Espada",
                    Puntaje = 10
                });
                Cartas.Add(new Carta()
                {
                    Numero = 10,
                    Palo = "Oro",
                    Puntaje = 10
                });
                Cartas.Add(new Carta()
                {
                    Numero = 10,
                    Palo = "Basto",
                    Puntaje = 10
                });
                Cartas.Add(new Carta()
                {
                    Numero = 10,
                    Palo = "Copa",
                    Puntaje = 10
                });
                Cartas.Add(new Carta()
                {
                    Numero = 7,
                    Palo = "Basto",
                    Puntaje = 10
                });
                Cartas.Add(new Carta()
                {
                    Numero = 7,
                    Palo = "Copa",
                    Puntaje = 10
                });
                Cartas.Add(new Carta()
                {
                    Numero = 6,
                    Palo = "Espada",
                    Puntaje = 11
                });
                Cartas.Add(new Carta()
                {
                    Numero = 6,
                    Palo = "Oro",
                    Puntaje = 11
                });
                Cartas.Add(new Carta()
                {
                    Numero = 6,
                    Palo = "Basto",
                    Puntaje = 11
                });
                Cartas.Add(new Carta()
                {
                    Numero = 6,
                    Palo = "Copa",
                    Puntaje = 11
                });
                Cartas.Add(new Carta()
                {
                    Numero = 5,
                    Palo = "Espada",
                    Puntaje = 12
                });
                Cartas.Add(new Carta()
                {
                    Numero = 5,
                    Palo = "Oro",
                    Puntaje = 12
                });
                Cartas.Add(new Carta()
                {
                    Numero = 5,
                    Palo = "Basto",
                    Puntaje = 12
                });
                Cartas.Add(new Carta()
                {
                    Numero = 5,
                    Palo = "Copa",
                    Puntaje = 12
                });
                Cartas.Add(new Carta()
                {
                    Numero = 4,
                    Palo = "Espada",
                    Puntaje = 13
                });
                Cartas.Add(new Carta()
                {
                    Numero = 4,
                    Palo = "Oro",
                    Puntaje = 13
                });
                Cartas.Add(new Carta()
                {
                    Numero = 4,
                    Palo = "Basto",
                    Puntaje = 13
                });
                Cartas.Add(new Carta()
                {
                    Numero = 4,
                    Palo = "Copa",
                    Puntaje = 13
                });

            }
            public List<Carta> RepartirCartas(Random indice)
            {
                var retorno = new List<Carta>();

                for (int i = 0; i < 3; i++)
                {
                 
                    var numeroRandom = indice.Next(Cartas.Count - 1);
                    Console.WriteLine(numeroRandom);
                    retorno.Add(Cartas[numeroRandom]);
                    Cartas.RemoveAt(numeroRandom);
                    
                }
                return retorno;
            }

        }
    
}

