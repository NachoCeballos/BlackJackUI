using System.Collections.Generic;
using System.Linq;

namespace LogicaJuego
{
    public class Juego
    {
        public Crupier Crupier { get; set; }
        public Jugador Bot1 { get; set; }
        public Jugador Jugador1 { get; set; }
        public Jugador CrupierJ { get; set; }
        public List<Jugador> ListaJugadores { get; set; }
        public int JugadorActual { get; private set; }

        public Juego(int jugadores)
        {
            ListaJugadores = new List<Jugador>();
            ListaJugadores.AddRange(Enumerable.Repeat(0, jugadores).Select(x=> {
                return new Jugador();
            }));
        }

        public void Iniciar(List<Jugador> jugadors)
        {
            int i, indiceJ;
            Crupier = new Crupier();

            indiceJ = jugadors.Count - 1;

            for(i = 1; i < indiceJ; i++)
            {
                ListaJugadores[i].Nombre = "Bot" + i;
                Crupier.repatirCartasIniciales(ListaJugadores[i]);
                ListaJugadores[i].SumarCartas();
            }

            ListaJugadores[0].Nombre = "Nacho";
            ListaJugadores[indiceJ].Nombre = "Crupier";

            Crupier.repatirCartasIniciales(ListaJugadores[0]);
            Crupier.repatirCartasIniciales(ListaJugadores[indiceJ]);

            ListaJugadores[indiceJ].Cartas[0].Palo = "carta";
            ListaJugadores[indiceJ].Cartas[0].Numero = 0;

            ListaJugadores[0].SumarCartas();
            ListaJugadores[indiceJ].SumarCartas();

        }

        public void JugarRonda()
        {
            int indiceJ, i;

            indiceJ = ListaJugadores.Count;

            for(i = 1; i < indiceJ; i++)
            {
                do
                {
                    if (ListaJugadores[i].Respuesta == true) ListaJugadores[i].Cartas.Add(Crupier.Repartir()[0]);

                    ListaJugadores[i].SumarCartas();

                    Crupier.OfrecerCarta(ListaJugadores[i]);

                } while (ListaJugadores[i].Respuesta == true);
            }
        }

        public void Jugada(Jugador jugador, TipoJugada tipo)
        {
            if (tipo == TipoJugada.PedirCarta) 
            {
                jugador.Cartas.Add(Crupier.Repartir()[0]);
                jugador.SumarCartas();

                if (jugador.Suma > 21) jugador.Perder = true;
            }

            if(tipo == TipoJugada.MeQuedo)
            {
                jugador.Perder = true;
            }
        }
    }

    public enum TipoJugada
    {
        PedirCarta,
        MeQuedo,
    }
}
