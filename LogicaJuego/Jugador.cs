using System.Collections.Generic;

namespace LogicaJuego
{
    public class Jugador
    {
        public List<Carta> Cartas { get; set; }
        public string Nombre { get; set; }
        public int Suma { get; set; }
        public bool Respuesta { get; set; }
        public bool Perder { get; set; }

        public void SumarCartas()
        {
            int indice;

            indice = Cartas.Count - 1;
            Suma = 0;

            for (int i = 0; i <= indice; i++)
            {
                Suma += Cartas[i].Puntaje;
            }
        }
    }
}
