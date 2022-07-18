namespace ProjetoQuiz {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void quizToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void iniciarToolStripMenuItem1_Click(object sender, EventArgs e) {
            Pergunta01 p1 = new Pergunta01();
            p1.ShowDialog();
            this.Dispose();

        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e) {
            Pergunta01 p01 = new Pergunta01();
            p01.ShowDialog();
            this.Dispose();
        }

        private void Main_Load(object sender, EventArgs e) {
            VariaveisGlobais VG = new VariaveisGlobais();
            VG.ZerarVariaveis();
        }
    }
}