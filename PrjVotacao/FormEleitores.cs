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
    public partial class FormEleitores : Form
    {
        public static List<EleitorModel> eleitores = new List<EleitorModel>();
        public FormEleitores()
        {
            InitializeComponent();
        }

        private void btnCadE_Click(object sender, EventArgs e)
        {
            EleitorModel eleitor = new EleitorModel
            {
                Nome = txtNomeE.Text,
                CPF = mtbCPFE.Text,
                DataNascimento = dtpNascimentoE.Value,
                Telefone = mtbTelE.Text,
                Senha = txtSenhaE.Text
            };
            eleitores.Add(eleitor);
            MessageBox.Show("Eleitor cadastrado com sucesso!");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picEleitor.Image = new Bitmap(openFileDialog.FileName);
            }
        }
        public class EleitorModel
        {
            public string Nome { get; set; }
            public string CPF { get; set; }
            public DateTime DataNascimento { get; set; }
            public string Telefone { get; set; }
            public string Senha { get; set; }
            public bool JaVotou { get; set; } = false;
        }
    }
}
