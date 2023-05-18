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
            if (Class1.selecao == 1)
            {
                labelPALAVRA4.Text = "";
                labelPALAVRA5.Text = "";
                labelPALAVRA6.Text = "";
                labelPALAVRA7.Text = "";
                labelPALAVRA8.Text = "";
                labelPALAVRA9.Text = "";
                labelPALAVRA10.Text = "";
                labelPALAVRA11.Text = "";
                labelPALAVRA12.Text = "";
                labelPALAVRA13.Text = "";
            }
            if (Class1.selecao == 2)
            {
                labelPALAVRA7.Text = "";
                labelPALAVRA8.Text = "";
                labelPALAVRA9.Text = "";
                labelPALAVRA10.Text = "";
                labelPALAVRA11.Text = "";
                labelPALAVRA12.Text = "";
                labelPALAVRA13.Text = "";
            }
            if (Class1.selecao == 3)
            {
                labelPALAVRA5.Text = "";
                labelPALAVRA6.Text = "";
                labelPALAVRA7.Text = "";
                labelPALAVRA8.Text = "";
                labelPALAVRA9.Text = "";
                labelPALAVRA10.Text = "";
                labelPALAVRA11.Text = "";
                labelPALAVRA12.Text = "";
                labelPALAVRA13.Text = "";
            }
            labelVIDAS.Text = "5x";
            labelERROACERTO.Text = "";
        }
        public void endgame ()
        {
            if (Class1.selecao == 1) 
            {
                if (labelPALAVRA1.Text == "E" && labelPALAVRA2.Text == "G" && labelPALAVRA3.Text == "O")
                {
                    labelERROACERTO.Text = "Você conseguiu. Parabéns!";
                    labelERROACERTO.ForeColor = Color.Green;
                    textBoxLETRA.Enabled = false;
                }
            }
            if (Class1.selecao == 2)
            {
                if (labelPALAVRA1.Text == "F" && labelPALAVRA2.Text == "R" && labelPALAVRA3.Text == "E" && labelPALAVRA4.Text == "N" && labelPALAVRA5.Text == "T" && labelPALAVRA6.Text == "E")
                {
                    labelERROACERTO.Text = "Você conseguiu. Parabéns!";
                    labelERROACERTO.ForeColor = Color.Green;
                    textBoxLETRA.Enabled = false;
                }
            }
            if (Class1.selecao == 3)
            {
                if (labelPALAVRA1.Text == "J" && labelPALAVRA2.Text == "O" && labelPALAVRA3.Text == "G" && labelPALAVRA4.Text == "O")
                {
                    labelERROACERTO.Text = "Você conseguiu. Parabéns!";
                    labelERROACERTO.ForeColor = Color.Green;
                    textBoxLETRA.Enabled = false;
                }
            }
            if (Class1.vidas == 0)
            {
                labelERROACERTO.Text = "Você Morreu";
                labelERROACERTO.ForeColor = Color.Red;
                textBoxLETRA.Enabled = false;
            }
        }
        private void buttonRESPOSTA_Click(object sender, EventArgs e)
        {
            textBoxLETRA.CharacterCasing = CharacterCasing.Upper;
            //Primeira palavra
            if (Class1.selecao == 1)
            {
                Class1.resposta = "EGO";
                if (textBoxLETRA.Text != "E" && textBoxLETRA.Text != "G" && textBoxLETRA.Text != "O")
                {
                    Class1.vidas = Class1.vidas - 1;
                    labelVIDAS.Text = (Class1.vidas + "x");
                    labelERROACERTO.Text = "Letra incorreta. Tente novamente";
                    labelERROACERTO.ForeColor = Color.Red;
                    textBoxLETRA.Clear();
                }
                if (textBoxLETRA.Text == "E")
                {
                    labelPALAVRA1.Text = "E";
                    labelERROACERTO.Text = "";
                    textBoxLETRA.Text = "";
                }
                if (textBoxLETRA.Text == "G")
                {
                    labelPALAVRA2.Text = "G";
                    labelERROACERTO.Text = "";
                    textBoxLETRA.Text = "";
                }
                if (textBoxLETRA.Text == "O")
                {
                    labelPALAVRA3.Text = "O";
                    labelERROACERTO.Text = "";
                    textBoxLETRA.Text = "";
                }
            }
            //Segunda palavra
            if (Class1.selecao == 2)
            {
                Class1.resposta = "frente";
                if (textBoxLETRA.Text != "F" && textBoxLETRA.Text != "R" && textBoxLETRA.Text != "E" && textBoxLETRA.Text != "N" && textBoxLETRA.Text != "T")
                {
                    Class1.vidas = Class1.vidas - 1;
                    labelVIDAS.Text = (Class1.vidas + "x");
                    labelERROACERTO.Text = "Letra incorreta. Tente novamente";
                    labelERROACERTO.ForeColor = Color.Red;
                    textBoxLETRA.Clear();
                }
                if (textBoxLETRA.Text == "F")
                {
                    labelPALAVRA1.Text = "F";
                    labelERROACERTO.Text = "";
                    textBoxLETRA.Text = "";
                }
                if (textBoxLETRA.Text == "R")
                {
                    labelPALAVRA2.Text = "R";
                    labelERROACERTO.Text = "";
                    textBoxLETRA.Text = "";
                }
                if (textBoxLETRA.Text == "E")
                {
                    labelPALAVRA3.Text = "E";
                    labelERROACERTO.Text = "";
                    labelPALAVRA6.Text = "E";
                    textBoxLETRA.Text = "";
                }
                if (textBoxLETRA.Text == "N")
                {
                    labelPALAVRA4.Text = "N";
                    labelERROACERTO.Text = "";
                    textBoxLETRA.Text = "";
                }
                if (textBoxLETRA.Text == "T")
                {
                    labelPALAVRA5.Text = "T";
                    labelERROACERTO.Text = "";
                    textBoxLETRA.Text = "";
                }
            }
            //Terceira palavra
            if (Class1.selecao == 3)
            {
                Class1.resposta = "jogo";
                if (textBoxLETRA.Text != "J" && textBoxLETRA.Text != "O" && textBoxLETRA.Text != "G")
                {
                    Class1.vidas = Class1.vidas - 1;
                    labelVIDAS.Text = (Class1.vidas + "x");
                    labelERROACERTO.Text = "Letra incorreta. Tente novamente";
                    labelERROACERTO.ForeColor = Color.Red;
                    textBoxLETRA.Clear();
                }
                if (textBoxLETRA.Text == "J")
                {
                    labelPALAVRA1.Text = "J";
                    labelERROACERTO.Text = "";
                    textBoxLETRA.Text = "";
                }
                if (textBoxLETRA.Text == "O")
                {
                    labelPALAVRA2.Text = "O";
                    labelERROACERTO.Text = "";
                    labelPALAVRA4.Text = "O";
                    textBoxLETRA.Text = "";
                }
                if (textBoxLETRA.Text == "G")
                {
                    labelPALAVRA3.Text = "G";
                    labelERROACERTO.Text = "";
                    textBoxLETRA.Text = "";
                }
            }
            //Rotina de Public Void
            endgame();
        }

        private void buttonREINICIAR_Click(object sender, EventArgs e)
        {
            Class1.vidas = 5;
            textBoxLETRA.Enabled = true;
            if (Class1.selecao == 1)
            {
                labelPALAVRA1.Text = "_";
                labelPALAVRA2.Text = "_";
                labelPALAVRA3.Text = "_";
                labelPALAVRA4.Text = "";
                labelPALAVRA5.Text = "";
                labelPALAVRA6.Text = "";
                labelPALAVRA7.Text = "";
                labelPALAVRA8.Text = "";
                labelPALAVRA9.Text = "";
                labelPALAVRA10.Text = "";
                labelPALAVRA11.Text = "";
                labelPALAVRA12.Text = "";
                labelPALAVRA13.Text = "";
            }
            if (Class1.selecao == 2)
            {
                labelPALAVRA1.Text = "_";
                labelPALAVRA2.Text = "_";
                labelPALAVRA3.Text = "_";
                labelPALAVRA4.Text = "_";
                labelPALAVRA5.Text = "_";
                labelPALAVRA6.Text = "_";
                labelPALAVRA7.Text = "";
                labelPALAVRA8.Text = "";
                labelPALAVRA9.Text = "";
                labelPALAVRA10.Text = "";
                labelPALAVRA11.Text = "";
                labelPALAVRA12.Text = "";
                labelPALAVRA13.Text = "";
            }
            if (Class1.selecao == 3)
            {
                labelPALAVRA1.Text = "_";
                labelPALAVRA2.Text = "_";
                labelPALAVRA3.Text = "_";
                labelPALAVRA4.Text = "_";
                labelPALAVRA5.Text = "";
                labelPALAVRA6.Text = "";
                labelPALAVRA7.Text = "";
                labelPALAVRA8.Text = "";
                labelPALAVRA9.Text = "";
                labelPALAVRA10.Text = "";
                labelPALAVRA11.Text = "";
                labelPALAVRA12.Text = "";
                labelPALAVRA13.Text = "";
            }
            labelVIDAS.Text = "5x";
            labelERROACERTO.Text = "";
        }
    }
}
