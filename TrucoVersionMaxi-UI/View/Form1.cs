using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaTrucoVersionMaxi;
using  LogicaTrucoVersionMaxi.Controller;
using LogicaTrucoVersionMaxi.Model;

namespace TrucoVersionMaxi_UI
{
    public partial class Form1 : Form
    {
        JuegoController controller = new JuegoController(new LogicaTrucoVersionMaxi.Juego());
        Carta cartaEnManoJug1Car1;
        Carta cartaEnManoJug1Car2;
        Carta cartaEnManoJug1Car3;
        Carta cartaEnManoJug2Car1;
        Carta cartaEnManoJug2Car2;
        Carta cartaEnManoJug2Car3;

        public Form1()
        {
            InitializeComponent();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            controller.Jugar();
            pbxCartaJugadaJugador1.Image = TrucoVersionMaxi_UI.Properties.Resources.carta_vacia;
            pbxCartaJugadaJugador2.Image = TrucoVersionMaxi_UI.Properties.Resources.carta_vacia;
            txtRonda1Jugador1.BackColor = Color.White;
            txtRonda2Jugador1.BackColor = Color.White;
            txtRonda3Jugador1.BackColor = Color.White;
            txtRonda1Jugador2.BackColor = Color.White;
            txtRonda2Jugador2.BackColor = Color.White;
            txtRonda3Jugador2.BackColor = Color.White;


            var jugada = controller.JugadaActual();
            // Carta 1 Jugador 1
            cartaEnManoJug1Car1 = jugada.Jugador1[0];

            var nombreDeLaCartaJug1Car1 = cartaEnManoJug1Car1.Palo + "_" + cartaEnManoJug1Car1.Numero;

            pbxCarta1Jugador1.Image = (Image)Properties.Resources.ResourceManager.GetObject(nombreDeLaCartaJug1Car1.ToLower());


            //Carta 2 jugador 1
            cartaEnManoJug1Car2 = jugada.Jugador1[1];

            var nombreDeLaCartaJug1Car2 = cartaEnManoJug1Car2.Palo + "_" + cartaEnManoJug1Car2.Numero;

            pbxCarta2Jugador1.Image = (Image)Properties.Resources.ResourceManager.GetObject(nombreDeLaCartaJug1Car2.ToLower());
            //Carta 3 jugador 1
            cartaEnManoJug1Car3 = jugada.Jugador1[2];

            var nombreDeLaCartaJug1Car3 = cartaEnManoJug1Car3.Palo + "_" + cartaEnManoJug1Car3.Numero;

            pbxCarta3Jugador1.Image = (Image)Properties.Resources.ResourceManager.GetObject(nombreDeLaCartaJug1Car3.ToLower());
            //Carta 1 jugador 2
            cartaEnManoJug2Car1 = jugada.Jugador2[0];

            var nombreDeLaCartaJug2Car1 = cartaEnManoJug2Car1.Palo + "_" + cartaEnManoJug2Car1.Numero;

            pbxCarta1Jugador2.Image = (Image)Properties.Resources.ResourceManager.GetObject(nombreDeLaCartaJug2Car1.ToLower());

            //Carta 2 jugador 2

            cartaEnManoJug2Car2 = jugada.Jugador2[1];

            var nombreDeLaCartaJug2Car2 = cartaEnManoJug2Car2.Palo + "_" + cartaEnManoJug2Car2.Numero;

            pbxCarta2Jugador2.Image = (Image)Properties.Resources.ResourceManager.GetObject(nombreDeLaCartaJug2Car2.ToLower());
            //Carta 3 jugador 2
            cartaEnManoJug2Car3 = jugada.Jugador2[2];

            var nombreDeLaCartaJug2Car3 = cartaEnManoJug2Car3.Palo + "_" + cartaEnManoJug2Car3.Numero;

            pbxCarta3Jugador2.Image = (Image)Properties.Resources.ResourceManager.GetObject(nombreDeLaCartaJug2Car3.ToLower());



        }

        private void JugadorJuegaClick(Carta carta, PictureBox pictureBox, int jugador)
        {
            var jugada = controller.JugadaActual();

            if (jugada.CartaJugadaJugador1 == null && jugador == 1)
            {
                pbxCartaJugadaJugador1.Image = pictureBox.Image;
                pictureBox.Image = TrucoVersionMaxi_UI.Properties.Resources.carta_vacia;
                controller.JugadorJuega(jugador, carta);
            }
            if (jugada.CartaJugadaJugador2 == null && jugador == 2)
            {
                pbxCartaJugadaJugador2.Image = pictureBox.Image;
                pictureBox.Image = TrucoVersionMaxi_UI.Properties.Resources.carta_vacia;
                controller.JugadorJuega(jugador, carta);
            }
            var ganador = controller.ObtenerGanador();
            if (ganador != null)
            {
                MessageBox.Show("El ganador de la ronda es: " + ganador.Nombre);
            }

            var resultado = controller.GanadorPorRonda();
            ActualizarTablero(resultado);
            
            
               

        }
        
        private void ActualizarTablero(List<Jugada> resultado)
        {
            foreach (var item in resultado)
            {
                var control = this.Controls["tableLayoutPanel1"].Controls[$"txtRonda{item.Ronda+1}Jugador1"];
                control.BackColor = Color.Black;
            }
            if (resultado.Count == 1)
            {
                if (resultado[0].PuntajeJ1 != 0 && resultado[0].PuntajeJ2 != resultado[0].PuntajeJ1)
                {
                    txtRonda1Jugador1.BackColor = Color.Green;
                    txtRonda1Jugador2.BackColor = Color.Red;
                }
                else if (resultado[0].PuntajeJ2 != 0 && resultado[0].PuntajeJ2 != resultado[0].PuntajeJ1)
                {
                    txtRonda1Jugador2.BackColor = Color.Green;
                    txtRonda1Jugador1.BackColor = Color.Red;
                }
                else if (resultado[0].PuntajeJ2 != 0 && resultado[0].PuntajeJ1 != 0)
                {
                    txtRonda1Jugador1.BackColor = Color.DarkGray;
                    txtRonda1Jugador2.BackColor = Color.DarkGray;
                }
            }

        }
        private void pbxCarta1Jugador2_Click(object sender, EventArgs e)
        {
            JugadorJuegaClick(cartaEnManoJug2Car1, pbxCarta1Jugador2,2);
        }

        private void pbxCarta2Jugador2_Click(object sender, EventArgs e)
        {
            JugadorJuegaClick(cartaEnManoJug2Car2, pbxCarta2Jugador2,2);
        }

        private void pbxCarta3Jugador2_Click(object sender, EventArgs e)
        {
            JugadorJuegaClick(cartaEnManoJug2Car3, pbxCarta3Jugador2,2);
        }


        private void pbxCarta3Jugador1_Click(object sender, EventArgs e)
        {
            JugadorJuegaClick(cartaEnManoJug1Car3, pbxCarta3Jugador1,1);
        }

        private void pbxCarta2Jugador1_Click(object sender, EventArgs e)
        {
            JugadorJuegaClick(cartaEnManoJug1Car2, pbxCarta2Jugador1,1);
        }

        private void pbxCarta1Jugador1_Click(object sender, EventArgs e)
        {
            JugadorJuegaClick(cartaEnManoJug1Car1, pbxCarta1Jugador1,1);
        }


    }
}