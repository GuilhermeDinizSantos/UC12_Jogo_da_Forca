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
    public partial class FormSelecao : Form
    {
        public FormSelecao()
        {
            InitializeComponent();
        }

        private void buttonEGO_Click(object sender, EventArgs e)
        {
            Class1.selecao = 1;
            Form FormJogo = new FormJogo();
            FormJogo.Show();
        }

        private void buttonFRENTE_Click(object sender, EventArgs e)
        {
            Class1.selecao = 2;
            Form FormJogo = new FormJogo();
            FormJogo.Show();
        }

        private void buttonJOGO_Click(object sender, EventArgs e)
        {
            Class1.selecao = 3;
            Form FormJogo = new FormJogo();
            FormJogo.Show();
        }
    }
}
