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
    public partial class Pergunta04 : Form {
        public Pergunta04() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            VariaveisGlobais VG = new VariaveisGlobais();
            Pergunta05 p05 = new Pergunta05();

            if (buttonCerto.Checked == true)
            {
                MessageBox.Show("Parabens! \nResporta Certa");
                VG.AdicionarPontoCerto();
                p05.ShowDialog();
                this.Dispose();

            }
            else if (buttonErrado01.Checked == true || buttonErrado02.Checked == true || buttonErrado03.Checked == true)
            {
                MessageBox.Show("Ihh.. \nResporta Errada!");
                VG.AdicionarPontoErrado();
                p05.ShowDialog();
                this.Dispose();

            }
        }
    }
}
