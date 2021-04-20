using System;
using System.Collections.Generic;

namespace LogicaJuego
{
    public class Crupier
    {
        Mazo Mazo = new Mazo();

        Random random = new Random();
        public List<Carta> Cartas { get; set; }
        public int Suma { get; set; }
        public string Nombre { get; set; }
        public bool Respuesta { get; set; }



        public Jugador OfrecerCarta(Jugador jugador)
        {
            jugador.SumarCartas();

            if (jugador.Suma <= 16) jugador.Respuesta = true;

            if (jugador.Suma >= 17) jugador.Respuesta = false;

            return jugador;
        }

        public void OfrecerCarta()
        {

            if (Suma <= 16) Respuesta = true;

            if (Suma >= 17) Respuesta = false;

        }

        public Jugador repatirCartasIniciales(Jugador jugador)
        {
            var C = Repartir();

            jugador.Cartas = C;

            C = Repartir();

            jugador.Cartas.Add(C[0]);

            return jugador;
        }

        public List<Carta> repatirCartasIniciales()
        {
            var C = Repartir();

            Cartas = C;

            C = Repartir();

            Cartas.Add(C[0]);

            return Cartas;
        }

        public List<Carta> Repartir()
        {
            List<Carta> cartaARepartir = new List<Carta>();

            cartaARepartir.Add(cartaAleatoria());

            return cartaARepartir;
        }

        public Carta cartaAleatoria()
        {
            int num = random.Next(Mazo.Cartas.Count - 1);

            Carta cartaDevolver = Mazo.Cartas[num];
            Mazo.Cartas.RemoveAt(num);
            return cartaDevolver;
        }

        public void SumarCartas()
        {
            int indice;
            indice = Cartas.Count - 1;

            for (int i = 0; i <= indice; i++)
            {
                Suma += Cartas[i].Puntaje;
            }
        }

    }
}
