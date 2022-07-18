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
    public partial class Pergunta01 : Form {
        public Pergunta01() {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {
            VariaveisGlobais VG = new VariaveisGlobais();
            Pergunta02 p02 = new Pergunta02();
            

            if (buttonCerto.Checked == true)
            {
                MessageBox.Show("Parabens! \nResporta Certa");
                VG.AdicionarPontoCerto();
                VG.PontoCerto++;
                p02.ShowDialog();
                this.Dispose();

            }else if(buttonErrado01.Checked == true || buttonErrado02.Checked == true || buttonErrado03.Checked == true)
            {
                MessageBox.Show("Ihh.. \nResporta Errada!");
                VG.PontoCerto++;
                VG.AdicionarPontoErrado();
                p02.ShowDialog();
                this.Dispose();

            }
        }

        private void label2_Click_1(object sender, EventArgs e) {

        }

        private void label2_Click_2(object sender, EventArgs e) {

        }
    }
}
