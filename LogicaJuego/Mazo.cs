using System;
using System.Collections.Generic;

namespace LogicaJuego
{
    public class Mazo
    {
        public List<Carta> Cartas { get; set; }


        public List<Carta> Repartir()
        {
            List<Carta> cartaARepartir = new List<Carta>();

            cartaARepartir.Add(cartaAleatoria());

            return cartaARepartir;
        }

        public Carta cartaAleatoria()
        {
            var numR = new Random().Next(this.Cartas.Count - 1);

            Carta cartaDevolver = this.Cartas[numR];
            this.Cartas.RemoveAt(numR);
            return cartaDevolver;
        }

        public Mazo()
        {
            Cartas = new List<Carta>();

            Cartas.Add(new Carta()
            {
                Palo = "picas",
                Tipo = "A",
                Numero = 1,
                Puntaje = 1,
            });

            Cartas.Add(new Carta()
            {
                Palo = "picas",
                Tipo = "2",
                Numero = 2,
                Puntaje = 2,
            });

            Cartas.Add(new Carta()
            {
                Palo = "picas",
                Tipo = "3",
                Numero = 3,
                Puntaje = 3,
            });

            Cartas.Add(new Carta()
            {
                Palo = "picas",
                Tipo = "4",
                Numero = 4,
                Puntaje = 4,
            });

            Cartas.Add(new Carta()
            {
                Palo = "picas",
                Tipo = "5",
                Numero = 5,
                Puntaje = 5,
            });

            Cartas.Add(new Carta()
            {
                Palo = "picas",
                Tipo = "6",
                Numero = 6,
                Puntaje = 6,
            });

            Cartas.Add(new Carta()
            {
                Palo = "picas",
                Tipo = "7",
                Numero = 7,
                Puntaje = 7,
            });

            Cartas.Add(new Carta()
            {
                Palo = "picas",
                Tipo = "8",
                Numero = 8,
                Puntaje = 8,
            });

            Cartas.Add(new Carta()
            {
                Palo = "picas",
                Tipo = "9",
                Numero = 9,
                Puntaje = 9,
            });

            Cartas.Add(new Carta()
            {
                Palo = "picas",
                Tipo = "10",
                Numero = 10,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "picas",
                Tipo = "J",
                Numero = 11,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "picas",
                Tipo = "Q",
                Numero = 12,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "picas",
                Tipo = "K",
                Numero = 13,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "tréboles",
                Tipo = "A",
                Numero = 1,
                Puntaje = 1,
            });

            Cartas.Add(new Carta()
            {
                Palo = "tréboles",
                Tipo = "2",
                Numero = 2,
                Puntaje = 2,
            });

            Cartas.Add(new Carta()
            {
                Palo = "tréboles",
                Tipo = "3",
                Numero = 3,
                Puntaje = 3,
            });

            Cartas.Add(new Carta()
            {
                Palo = "tréboles",
                Tipo = "4",
                Numero = 4,
                Puntaje = 4,
            });

            Cartas.Add(new Carta()
            {
                Palo = "tréboles",
                Tipo = "5",
                Numero = 5,
                Puntaje = 5,
            });

            Cartas.Add(new Carta()
            {
                Palo = "tréboles",
                Tipo = "6",
                Numero = 6,
                Puntaje = 6,
            });

            Cartas.Add(new Carta()
            {
                Palo = "tréboles",
                Tipo = "7",
                Numero = 7,
                Puntaje = 7,
            });

            Cartas.Add(new Carta()
            {
                Palo = "tréboles",
                Tipo = "8",
                Numero = 8,
                Puntaje = 8,
            });

            Cartas.Add(new Carta()
            {
                Palo = "tréboles",
                Tipo = "9",
                Numero = 9,
                Puntaje = 9,
            });

            Cartas.Add(new Carta()
            {
                Palo = "tréboles",
                Tipo = "10",
                Numero = 10,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "tréboles",
                Tipo = "J",
                Numero = 11,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "tréboles",
                Tipo = "Q",
                Numero = 12,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "tréboles",
                Tipo = "K",
                Numero = 13,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "corazones",
                Tipo = "A",
                Numero = 1,
                Puntaje = 1,
            });

            Cartas.Add(new Carta()
            {
                Palo = "corazones",
                Tipo = "2",
                Numero = 2,
                Puntaje = 2,
            });

            Cartas.Add(new Carta()
            {
                Palo = "corazones",
                Tipo = "3",
                Numero = 3,
                Puntaje = 3,
            });

            Cartas.Add(new Carta()
            {
                Palo = "corazones",
                Tipo = "4",
                Numero = 4,
                Puntaje = 4,
            });

            Cartas.Add(new Carta()
            {
                Palo = "corazones",
                Tipo = "5",
                Numero = 5,
                Puntaje = 5,
            });

            Cartas.Add(new Carta()
            {
                Palo = "corazones",
                Tipo = "6",
                Numero = 6,
                Puntaje = 6,
            });

            Cartas.Add(new Carta()
            {
                Palo = "corazones",
                Tipo = "7",
                Numero = 7,
                Puntaje = 7,
            });

            Cartas.Add(new Carta()
            {
                Palo = "corazones",
                Tipo = "8",
                Numero = 8,
                Puntaje = 8,
            });

            Cartas.Add(new Carta()
            {
                Palo = "corazones",
                Tipo = "9",
                Numero = 9,
                Puntaje = 9,
            });

            Cartas.Add(new Carta()
            {
                Palo = "corazones",
                Tipo = "10",
                Numero = 10,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "corazones",
                Tipo = "J",
                Numero = 11,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "corazones",
                Tipo = "Q",
                Numero = 12,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "corazones",
                Tipo = "K",
                Numero = 13,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "diamantes",
                Tipo = "A",
                Numero = 1,
                Puntaje = 1,
            });

            Cartas.Add(new Carta()
            {
                Palo = "diamantes",
                Tipo = "2",
                Numero = 2,
                Puntaje = 2,
            });

            Cartas.Add(new Carta()
            {
                Palo = "diamantes",
                Tipo = "3",
                Numero = 3,
                Puntaje = 3,
            });

            Cartas.Add(new Carta()
            {
                Palo = "diamantes",
                Tipo = "4",
                Numero = 4,
                Puntaje = 4,
            });

            Cartas.Add(new Carta()
            {
                Palo = "diamantes",
                Tipo = "5",
                Numero = 5,
                Puntaje = 5,
            });

            Cartas.Add(new Carta()
            {
                Palo = "diamantes",
                Tipo = "6",
                Numero = 6,
                Puntaje = 6,
            });

            Cartas.Add(new Carta()
            {
                Palo = "diamantes",
                Tipo = "7",
                Numero = 7,
                Puntaje = 7,
            });

            Cartas.Add(new Carta()
            {
                Palo = "diamantes",
                Tipo = "8",
                Numero = 8,
                Puntaje = 8,
            });

            Cartas.Add(new Carta()
            {
                Palo = "diamantes",
                Tipo = "9",
                Numero = 9,
                Puntaje = 9,
            });

            Cartas.Add(new Carta()
            {
                Palo = "diamantes",
                Tipo = "10",
                Numero = 10,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "diamantes",
                Tipo = "J",
                Numero = 11,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "diamantes",
                Tipo = "Q",
                Numero = 12,
                Puntaje = 10,
            });

            Cartas.Add(new Carta()
            {
                Palo = "diamantes",
                Tipo = "K",
                Numero = 13,
                Puntaje = 10,
            });
        }
    }
}
