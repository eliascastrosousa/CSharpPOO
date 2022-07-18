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
    public partial class Pergunta05 : Form {
        public Pergunta05() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            VariaveisGlobais VG = new VariaveisGlobais();
            Final F = new Final();

            if (buttonCerto.Checked == true)
            {
                MessageBox.Show("Parabens! \nResporta Certa");
                VG.AdicionarPontoCerto();
                F.ShowDialog();
                this.Dispose();

            }
            else if (buttonErrado01.Checked == true || buttonErrado02.Checked == true || buttonErrado03.Checked == true)
            {
                MessageBox.Show("Ihh.. \nResporta Errada!");
                VG.AdicionarPontoErrado();
                F.ShowDialog();
                this.Dispose();

            }
        }
    }
}
