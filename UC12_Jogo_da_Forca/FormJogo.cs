using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_Jogo_da_Forca
{
    public partial class FormJogo : Form
    {
        public FormJogo()
        {
            InitializeComponent();


            labelVIDAS.Text = (Class1.vidas + "");

        }
        public void endgame()
        {
            if (textBoxLETRA.Text != Class1.palavra_secreta[0])
            {
                Class1.vidas = Class1.vidas - 1;

            }
            if (textBoxLETRA.Text != Class1.palavra_secreta[1])
            {
                Class1.vidas--;
            }
            if (textBoxLETRA.Text != Class1.palavra_secreta[2])
            {
                Class1.vidas--;

            }
            if (textBoxLETRA.Text != Class1.palavra_secreta[3])
            {
                Class1.vidas--;
            }
            if (textBoxLETRA.Text != Class1.palavra_secreta[4])
            {
                Class1.vidas--;

            }
            if (textBoxLETRA.Text != Class1.palavra_secreta[5])
            {
                Class1.vidas--;
            }
            if (textBoxLETRA.Text != Class1.palavra_secreta[6])
            {
                Class1.vidas--;

            }
            if (textBoxLETRA.Text != Class1.palavra_secreta[7])
            {
                Class1.vidas--;
            }
            if (textBoxLETRA.Text != Class1.palavra_secreta[8])
            {
                Class1.vidas--;

            }
            if (textBoxLETRA.Text != Class1.palavra_secreta[9])
            {
                Class1.vidas--;
            }
            if (Class1.vidas == 0)
            {
                labelERROACERTO.Text = "Você perdeu o jogo!";
            }
        }

        private void buttonRESPOSTA_Click(object sender, EventArgs e)
        {

        
            if (textBoxLETRA.Text == Class1.palavra_secreta[0])
            {
                labelPALAVRA1.Text = Class1.palavra_secreta[0];

            }
            if (textBoxLETRA.Text == Class1.palavra_secreta[1])
            {
                labelPALAVRA2.Text = Class1.palavra_secreta[1];
            }
            if (textBoxLETRA.Text == Class1.palavra_secreta[2])
            {
                labelPALAVRA1.Text = Class1.palavra_secreta[2];

            }
            if (textBoxLETRA.Text == Class1.palavra_secreta[3])
            {
                labelPALAVRA3.Text = Class1.palavra_secreta[3];
            }
            if (textBoxLETRA.Text == Class1.palavra_secreta[4])
            {
                labelPALAVRA1.Text = Class1.palavra_secreta[4];

            }
            if (textBoxLETRA.Text == Class1.palavra_secreta[5])
            {
                labelPALAVRA5.Text = Class1.palavra_secreta[5];
            }
            if (textBoxLETRA.Text == Class1.palavra_secreta[6])
            {
                labelPALAVRA1.Text = Class1.palavra_secreta[6];

            }
            if (textBoxLETRA.Text == Class1.palavra_secreta[7])
            {
                labelPALAVRA7.Text = Class1.palavra_secreta[7];
            }
            if (textBoxLETRA.Text == Class1.palavra_secreta[8])
            {
                labelPALAVRA1.Text = Class1.palavra_secreta[8];

            }
            if (textBoxLETRA.Text == Class1.palavra_secreta[9])
            {
                labelPALAVRA9.Text = Class1.palavra_secreta[9];
            }



        }

        private void buttonREINICIAR_Click(object sender, EventArgs e)
        {

        }

        private void labelERROACERTO_Click(object sender, EventArgs e)
        {

        }
    }
}
