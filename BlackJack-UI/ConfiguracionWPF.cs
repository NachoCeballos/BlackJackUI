using LogicaJuego;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.VisualStyles;

namespace BlackJack_UI
{
    public partial class ConfiguracionWPF : Form
    {

        public int cantidadJugadores;

        public ConfiguracionWPF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cantidadJugadores = int.Parse(txt1.Text);

            if (cantidadJugadores <= 7)
            {
                if (cantidadJugadores > 2)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else MessageBox.Show("La cantidad de jugadores debe ser mayor a 2 y menor a 8");
            }
            else MessageBox.Show("La cantidad de jugadores debe ser mayor a 2 y menor a 8");

        }
    }
}
