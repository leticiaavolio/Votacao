namespace PrjVotacao
{
    partial class FormVotacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            mtbCPFV = new MaskedTextBox();
            label9 = new Label();
            txtSenhaV = new TextBox();
            label4 = new Label();
            label12 = new Label();
            btnConf = new Button();
            btnBranco = new Button();
            txtNumeroVoto = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(533, 73);
            label1.Name = "label1";
            label1.Size = new Size(122, 35);
            label1.TabIndex = 1;
            label1.Text = "Votação";
            // 
            // mtbCPFV
            // 
            mtbCPFV.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtbCPFV.Location = new Point(405, 161);
            mtbCPFV.Mask = "999.999.999-99";
            mtbCPFV.Name = "mtbCPFV";
            mtbCPFV.Size = new Size(439, 38);
            mtbCPFV.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(344, 174);
            label9.Name = "label9";
            label9.Size = new Size(55, 25);
            label9.TabIndex = 29;
            label9.Text = "CPF:";
            // 
            // txtSenhaV
            // 
            txtSenhaV.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaV.Location = new Point(423, 229);
            txtSenhaV.Name = "txtSenhaV";
            txtSenhaV.Size = new Size(421, 38);
            txtSenhaV.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(344, 242);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 35;
            label4.Text = "Senha:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(344, 310);
            label12.Name = "label12";
            label12.Size = new Size(108, 25);
            label12.TabIndex = 37;
            label12.Text = "Candidato:";
            // 
            // btnConf
            // 
            btnConf.BackColor = Color.DarkSeaGreen;
            btnConf.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnConf.Location = new Point(608, 374);
            btnConf.Name = "btnConf";
            btnConf.Size = new Size(177, 43);
            btnConf.TabIndex = 39;
            btnConf.Text = "Confirmar";
            btnConf.UseVisualStyleBackColor = false;
            btnConf.Click += btnConf_Click;
            // 
            // btnBranco
            // 
            btnBranco.BackColor = Color.White;
            btnBranco.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBranco.Location = new Point(404, 374);
            btnBranco.Name = "btnBranco";
            btnBranco.Size = new Size(177, 43);
            btnBranco.TabIndex = 40;
            btnBranco.Text = "Branco";
            btnBranco.UseVisualStyleBackColor = false;
            btnBranco.Click += btnBranco_Click;
            // 
            // txtNumeroVoto
            // 
            txtNumeroVoto.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroVoto.Location = new Point(458, 297);
            txtNumeroVoto.Name = "txtNumeroVoto";
            txtNumeroVoto.Size = new Size(386, 38);
            txtNumeroVoto.TabIndex = 41;
            // 
            // FormVotacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 642);
            Controls.Add(txtNumeroVoto);
            Controls.Add(btnBranco);
            Controls.Add(btnConf);
            Controls.Add(label12);
            Controls.Add(txtSenhaV);
            Controls.Add(label4);
            Controls.Add(mtbCPFV);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "FormVotacao";
            Text = "FormVotacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox mtbCPFV;
        private Label label9;
        private TextBox txtSenhaV;
        private Label label4;
        private Label label12;
        private Button btnConf;
        private Button btnBranco;
        private TextBox txtNumeroVoto;
    }
}