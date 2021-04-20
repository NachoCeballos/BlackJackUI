using BlackJack_UI.Properties;
using LogicaJuego;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_UI
{
    public partial class JuegoWPF : Form
    {
        Juego juego;

        public int cantidadJugadores;
        public JuegoWPF()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfiguracionWPF configuracionWPF = (ConfiguracionWPF)Program.provedor.GetService(typeof(ConfiguracionWPF));

            //configuracionWPF.ShowDialog();

            var resultado = configuracionWPF.ShowDialog();

            if(resultado != DialogResult.OK)
            {
                this.Close();
            }else
            {
                cantidadJugadores = configuracionWPF.cantidadJugadores;

                juego = new Juego(cantidadJugadores);

                juego.Iniciar(juego.ListaJugadores);

                CrearColumnas(juego.ListaJugadores);

                AgregarCartas(juego.ListaJugadores);

                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                CrearColumnas(juego.ListaJugadores);
                AgregarCartas(juego.ListaJugadores);
            }

            
        }

        public List<Jugador> CrearColumnas(List<Jugador> jugadors)
        {
            int indiceJ, i;

            indiceJ = jugadors.Count;

            for (i = 0; i < indiceJ; i++)
            {
                var columnaJugador = new DataGridViewImageColumn();
                columnaJugador.DefaultCellStyle.NullValue = null;
                dataGridView1.RowTemplate.Height = 140;
                columnaJugador.ImageLayout = DataGridViewImageCellLayout.Stretch;
                columnaJugador.Width = 90;

                dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
                    columnaJugador});

                columnaJugador.HeaderText = $"Cartas De {juego.ListaJugadores[i].Nombre}" +
                    $"\nSuma: {juego.ListaJugadores[i].Suma}";

            }
            return jugadors;
        }

        public void AgregarCartas(List<Jugador> jugadors)
        {
            int indiceC, indice, i, a, n;

            //Cantidad de columnas = número de jugadores
            indiceC = dataGridView1.ColumnCount;

            dataGridView1.Rows.Add();


            for (i = 0; i < indiceC; i++)
            {
                indice = jugadors[i].Cartas.Count;

                for (a = 0; a < indice; a++)
                {
                    var nombreCarta = juego.ListaJugadores[i].Cartas[a].Palo + "_" + juego.ListaJugadores[i].Cartas[a].Numero;
                    dataGridView1.Rows[a].Cells[i].Value = ((Image)Properties.Resources.ResourceManager.GetObject(nombreCarta));
                    n = dataGridView1.Rows.Add();

                    //dataGridView1.Rows.RemoveAt(1);
                   
                    dataGridView1.Rows[a].Cells[i].Value = ((Image)Properties.Resources.ResourceManager.GetObject(nombreCarta));
                }
            }
        }

        public void SacarRowsInutiles()
        {
            int maxRow = 0, aux, aux1, i, indiceJ, h;

            indiceJ = juego.ListaJugadores.Count;

            for (i = 0; i < indiceJ; i++)
            {
                aux = juego.ListaJugadores[i].Cartas.Count;

                if (maxRow < aux) maxRow = juego.ListaJugadores[i].Cartas.Count;
            }

            aux1 = maxRow;
            aux1 += 5;

            for (h = maxRow; h < aux1; h++)
            {
                dataGridView1.Rows.RemoveAt(maxRow);
            }
        }

        public void ActualizarInterfaz()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            CrearColumnas(juego.ListaJugadores);
            AgregarCartas(juego.ListaJugadores);
            SacarRowsInutiles();

            ApagarBoton(btnJugador1MeQuedo, juego.ListaJugadores[0]);
            ApagarBoton(btnJugador1PedirC, juego.ListaJugadores[0]);
        }

        private void btnJugador1PedirC_Click(object sender, EventArgs e)
        {
            juego.Jugada(juego.ListaJugadores[0], TipoJugada.PedirCarta);
            ActualizarInterfaz();
            
        }

        private void btnJugador1MeQuedo_Click(object sender, EventArgs e)
        {
            juego.Jugada(juego.ListaJugadores[0], TipoJugada.MeQuedo);
            ActualizarInterfaz();
        }

        public void ApagarBoton(Button button, Jugador jugador)
        {
            if (jugador.Perder == true)
            {
                button.Enabled = false;
                juego.JugarRonda();
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                CrearColumnas(juego.ListaJugadores);
                AgregarCartas(juego.ListaJugadores);
                SacarRowsInutiles();
            }
       
        }




    }
}
