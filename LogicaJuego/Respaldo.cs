using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaJuego
{
    class Respaldo
    {
        /************SIRVE PARA TODOS LOS JUGADORES*******/
        //public List<Jugador> CrearColumnasYAgregarCartas(List<Jugador> jugadors)
        //{
        //    int indiceJ, indice, i, a;

        //    indiceJ = jugadors.Count;

        //    for (i = 0; i < indiceJ; i++)
        //    {
        //        var columnaJugador = new DataGridViewImageColumn();
        //        dataGridView1.RowTemplate.Height = 140;
        //        columnaJugador.ImageLayout = DataGridViewImageCellLayout.Stretch;
        //        columnaJugador.Width = 90;

        //        dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
        //            columnaJugador});

        //        columnaJugador.HeaderText = $"Cartas De {juego.ListaJugadores[i].Nombre}" +
        //            $"\nSuma: {juego.ListaJugadores[i].Suma}";


        //    }

        //    return jugadors;
        //}

        //public void AgregarCartas(List<Jugador> jugadors)
        //{
        //    int indiceC, indice, i, a;

        //    //Cantidad de columnas = número de jugadores
        //    indiceC = dataGridView1.ColumnCount;
        //    var v = dataGridView1.RowCount.ToString();
        //    v = dataGridView1.Rows.Count.ToString();

        //    for (i = 0; i < indiceC; i++)
        //    {
        //        indice = jugadors[i].Cartas.Count;

        //        for (a = 0; a < indice; a++)
        //        {
        //            var nombreCarta = juego.ListaJugadores[i].Cartas[a].Palo + "_" + juego.ListaJugadores[i].Cartas[a].Numero;
        //            int n = dataGridView1.Rows.Add();
        //            dataGridView1.Rows[a].Cells[i].Value = ((Image)Properties.Resources.ResourceManager.GetObject(nombreCarta));

        //            //dataGridView1.Rows[].Cells[i].Value = ((Image)Properties.Resources.ResourceManager.GetObject(nombreCarta));


        //        }


        //    }
        //    v = dataGridView1.RowCount.ToString();

        //    dataGridView1.Rows.RemoveAt(2);
        //    dataGridView1.Rows.RemoveAt(2);
        //    dataGridView1.Rows.RemoveAt(2);
        //    dataGridView1.Rows.RemoveAt(2);
        //    v = dataGridView1.RowCount.ToString();

        //}

    }




    /******SIRVE PARA UN SOLO JUGADOR******/
    //public void CrearColumnAgregarCartas()
    //{
    //    int n, i, indice;

    //    var columnaJugador = new DataGridViewImageColumn();

    //    dataGridView1.RowTemplate.Height = 140;
    //    columnaJugador.ImageLayout = DataGridViewImageCellLayout.Stretch;
    //    columnaJugador.Width = 90;


    //    dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
    //            columnaJugador});

    //    columnaJugador.HeaderText = "Cartas de " + juego.ListaJugadores[0].Nombre + "\nSuma: " + juego.ListaJugadores[0].Suma;

    //    n = dataGridView1.Rows.Add();

    //    indice = juego.ListaJugadores[0].Cartas.Count;

    //    for (i = 0; i < indice; i++)
    //    {

    //        var nombreCartas = juego.ListaJugadores[0].Cartas[i].Palo + "_" + juego.ListaJugadores[0].Cartas[i].Numero;
    //        dataGridView1.Rows[n].Cells[0].Value = ((Image)Properties.Resources.ResourceManager.GetObject(nombreCartas));

    //        n = dataGridView1.Rows.Add();
    //        dataGridView1.Rows.RemoveAt(1);

    //    }
    //}
}
