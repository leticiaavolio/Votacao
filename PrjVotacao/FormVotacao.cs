using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PrjVotacao
{
    public partial class FormVotacao : Form
    {
        public static int votosBranco = 0;
        public static int votosNulos = 0;
        public FormVotacao()
        {
            InitializeComponent();
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            string cpf = mtbCPFV.Text;
            string senha = txtSenhaV.Text;

            var eleitor = FormEleitores.eleitores.FirstOrDefault(x => x.CPF == cpf && x.Senha == senha);
            if (eleitor == null)
            {
                MessageBox.Show("CPF ou Senha inválidos!");
                return;
            }
            if (eleitor.JaVotou)
            {
                MessageBox.Show("Este eleitor já votou!");
                return;
            }
            int numeroCandidato;
            if (!int.TryParse(txtNumeroVoto.Text, out numeroCandidato))
            {
                MessageBox.Show("Número inválido, o voto será nulo. Confirma?");
                DialogResult result = MessageBox.Show("Confirma voto nulo?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    votosNulos++;
                    eleitor.JaVotou = true;
                }
                return;
            }
            var candidato = Formcandidato.candidatos.FirstOrDefault(x => x.NumeroCandidato == numeroCandidato);
            if (candidato == null)
            {
                MessageBox.Show("Candidato não encontrado, o voto será nulo. Confirma?");
                DialogResult result = MessageBox.Show("Confirma voto nulo?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    votosNulos++;
                    eleitor.JaVotou = true;
                }
                return;
            }
            candidato.TotalVotos++;
            eleitor.JaVotou = true;
            MessageBox.Show("Voto computado com sucesso!");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            string cpf = mtbCPFV.Text;
            string senha = txtSenhaV.Text;

            var eleitor = FormEleitores.eleitores.FirstOrDefault(x => x.CPF == cpf && x.Senha == senha);
            if (eleitor == null)
            {
                MessageBox.Show("CPF ou Senha inválidos!");
                return;
            }

            if (eleitor.JaVotou)
            {
                MessageBox.Show("Este eleitor já votou!");
                return;
            }

            votosBranco++;
            eleitor.JaVotou = true;
            MessageBox.Show("Voto em branco computado!");
        }
    }
}
