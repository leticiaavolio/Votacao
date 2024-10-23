using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjVotacao
{
    public partial class Formcandidato : Form
    {
        public static List<CandidatoModel> candidatos = new List<CandidatoModel>();
        public Formcandidato()
        {
            InitializeComponent();
        }

        private void btnCadC_Click(object sender, EventArgs e)
        {
            CandidatoModel candidato = new CandidatoModel
            {
                Nome = txtNomeC.Text,
                CPF = mtbCPFC.Text,
                DataNascimento = dtpNascimentoC.Value,
                Telefone = mtbTelC.Text,
                NumeroCandidato = int.Parse(txtNumero.Text),
                Senha = txtSenhaC.Text
            };
            candidatos.Add(candidato);
            MessageBox.Show("Candidato cadastrado com sucesso!");
        }
        public class CandidatoModel
        {
            public string Nome { get; set; }
            public string CPF { get; set; }
            public DateTime DataNascimento { get; set; }
            public string Telefone { get; set; }
            public int NumeroCandidato { get; set; }
            public string Senha { get; set; }
            public int TotalVotos { get; set; } = 0;
        }
    }
}
