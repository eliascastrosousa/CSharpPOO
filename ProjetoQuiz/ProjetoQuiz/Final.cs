using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoQuiz {
    public partial class Final : Form {
        public Final() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {
            VariaveisGlobais VG = new VariaveisGlobais();
            Console.WriteLine("{0}", VG.MostrarPontuacao());
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {
           /* VariaveisGlobais VG = new VariaveisGlobais();
            int labelAcertos = VG.MostrarPontuacao();
            int labelErros = VG.MostrarPontuacaoErrada();

            label4.Text = labelAcertos.ToString();
            label5.Text = labelErros.ToString();*/
        }

        private void Final_Load(object sender, EventArgs e) {
            VariaveisGlobais VG = new VariaveisGlobais();
            label4.Text = VG.PontoCerto.ToString();
            label5.Text = VG.PontoErrado.ToString();
            /* int labelAcertos = VG.MostrarPontuacao();
            int labelErros = VG.MostrarPontuacaoErrada();

            label4.Text = labelAcertos.ToString();
            label5.Text = labelErros.ToString(); */
        }

        private void label5_Click_1(object sender, EventArgs e) {
            /*
            VariaveisGlobais VG = new VariaveisGlobais();
            int labelAcertos = VG.MostrarPontuacao();
            int labelErros = VG.MostrarPontuacaoErrada();

            label4.Text = labelAcertos.ToString();
            label5.Text = labelErros.ToString();*/
        }
    }
}
