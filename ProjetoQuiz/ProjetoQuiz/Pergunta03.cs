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
    public partial class Pergunta03 : Form {
        public Pergunta03() {
            InitializeComponent();
        }

        private void Pergunta03_Load(object sender, EventArgs e) {

        }

        private void buttonErrado03_CheckedChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            VariaveisGlobais VG = new VariaveisGlobais();
            Pergunta04 p04 = new Pergunta04();

            if (buttonCerto.Checked == true)
            {
                MessageBox.Show("Parabens! \nResporta Certa");
                VG.AdicionarPontoCerto();
                p04.ShowDialog();
                this.Dispose();

            }
            else if (buttonErrado01.Checked == true || buttonErrado02.Checked == true || buttonErrado03.Checked == true)
            {
                MessageBox.Show("Ihh.. \nResporta Errada!");
                VG.AdicionarPontoErrado();
                p04.ShowDialog();
                this.Dispose();

            }
        }
    }
}
