namespace PrjVotacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void votaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void eleitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEleitores obj = new FormEleitores();
            obj.ShowDialog();
        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formcandidato obj = new Formcandidato();
            obj.ShowDialog();
        }

        private void votarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVotacao obj = new FormVotacao();
            obj.ShowDialog();
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormResultados obj = new FormResultados();
            obj.ShowDialog();
        }
    }
}