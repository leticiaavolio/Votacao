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
    public partial class FormResultados : Form
    {
        public FormResultados()
        {
            InitializeComponent();
        }

        private void FormResultados_Load(object sender, EventArgs e)
        {
            int totalVotos = Formcandidato.candidatos.Sum(c => c.TotalVotos) + FormVotacao.votosBranco + FormVotacao.votosNulos;

            lblTotalVotos.Text = $"Total de Votos: {totalVotos}";
            lblVotosBranco.Text = $"Votos em Branco: {FormVotacao.votosBranco}";
            lblVotosNulos.Text = $"Votos Nulos: {FormVotacao.votosNulos}";

            var candidatosOrdenados = Formcandidato.candidatos.OrderByDescending(c => c.TotalVotos).ToList();
            foreach (var candidato in candidatosOrdenados)
            {
                listResultados.Items.Add($"{candidato.Nome} - {candidato.TotalVotos} votos ({(double)candidato.TotalVotos / totalVotos:P})");
            }

            double percentualBranco = (double)FormVotacao.votosBranco / totalVotos * 100;
            double percentualNulo = (double)FormVotacao.votosNulos / totalVotos * 100;

            lblPercentualBranco.Text = $"Percentual de votos em branco: {percentualBranco:F2}%";
            lblPercentualNulos.Text = $"Percentual de votos nulos: {percentualNulo:F2}%";
        }
    }
}
