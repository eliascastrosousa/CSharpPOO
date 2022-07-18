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
    public partial class Pergunta02 : Form {
        public Pergunta02() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {
            VariaveisGlobais VG = new VariaveisGlobais();
            Pergunta03 p03 = new Pergunta03();

            if (buttonCerto.Checked == true)
            {
                MessageBox.Show("Parabens! \nResporta Certa");
                VG.AdicionarPontoCerto();
                p03.ShowDialog();
                this.Dispose();

            }
            else if (buttonErrado01.Checked == true || buttonErrado02.Checked == true || buttonErrado03.Checked == true)
            {
                MessageBox.Show("Ihh.. \nResporta Errada!");
                VG.AdicionarPontoErrado();
                p03.ShowDialog();
                this.Dispose();

            }
        }
    }
}
