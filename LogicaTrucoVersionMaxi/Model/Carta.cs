using System;

namespace LogicaTrucoVersionMaxi
{
    
        public class Carta : IEquatable<Carta>
        {
            public int Numero { get; set; }
            public string Palo { get; set; }
            public int Puntaje { get; set; }

        public bool Equals(Carta other)
        {
            return other.Numero == this.Numero && other.Palo == this.Palo;
        }
    }
    
}

