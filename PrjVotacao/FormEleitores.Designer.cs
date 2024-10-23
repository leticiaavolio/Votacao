namespace PrjVotacao
{
    partial class FormEleitores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEleitores));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtNomeE = new TextBox();
            txtSenhaE = new TextBox();
            mtbCPFE = new MaskedTextBox();
            mtbTelE = new MaskedTextBox();
            dtpNascimentoE = new DateTimePicker();
            picEleitor = new PictureBox();
            btnCadE = new Button();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)picEleitor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(439, 107);
            label1.Name = "label1";
            label1.Size = new Size(300, 35);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Eleitores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(175, 210);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(175, 262);
            label3.Name = "label3";
            label3.Size = new Size(198, 25);
            label3.TabIndex = 2;
            label3.Text = "Data de Nascimento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(175, 314);
            label9.Name = "label9";
            label9.Size = new Size(55, 25);
            label9.TabIndex = 8;
            label9.Text = "CPF:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(175, 366);
            label10.Name = "label10";
            label10.Size = new Size(94, 25);
            label10.TabIndex = 9;
            label10.Text = "Telefone:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(175, 418);
            label12.Name = "label12";
            label12.Size = new Size(73, 25);
            label12.TabIndex = 11;
            label12.Text = "Senha:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(743, 200);
            label13.Name = "label13";
            label13.Size = new Size(57, 25);
            label13.TabIndex = 12;
            label13.Text = "Foto:";
            // 
            // txtNomeE
            // 
            txtNomeE.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeE.Location = new Point(250, 197);
            txtNomeE.Name = "txtNomeE";
            txtNomeE.Size = new Size(425, 38);
            txtNomeE.TabIndex = 13;
            // 
            // txtSenhaE
            // 
            txtSenhaE.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaE.Location = new Point(254, 405);
            txtSenhaE.Name = "txtSenhaE";
            txtSenhaE.Size = new Size(421, 38);
            txtSenhaE.TabIndex = 14;
            // 
            // mtbCPFE
            // 
            mtbCPFE.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtbCPFE.Location = new Point(236, 301);
            mtbCPFE.Mask = "999.999.999-99";
            mtbCPFE.Name = "mtbCPFE";
            mtbCPFE.Size = new Size(439, 38);
            mtbCPFE.TabIndex = 15;
            // 
            // mtbTelE
            // 
            mtbTelE.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtbTelE.Location = new Point(275, 353);
            mtbTelE.Mask = "(99)99999-9999";
            mtbTelE.Name = "mtbTelE";
            mtbTelE.Size = new Size(400, 38);
            mtbTelE.TabIndex = 16;
            // 
            // dtpNascimentoE
            // 
            dtpNascimentoE.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNascimentoE.Location = new Point(379, 252);
            dtpNascimentoE.Name = "dtpNascimentoE";
            dtpNascimentoE.Size = new Size(296, 38);
            dtpNascimentoE.TabIndex = 17;
            // 
            // picEleitor
            // 
            picEleitor.Image = (Image)resources.GetObject("picEleitor.Image");
            picEleitor.Location = new Point(806, 197);
            picEleitor.Name = "picEleitor";
            picEleitor.Size = new Size(197, 194);
            picEleitor.SizeMode = PictureBoxSizeMode.StretchImage;
            picEleitor.TabIndex = 18;
            picEleitor.TabStop = false;
            // 
            // btnCadE
            // 
            btnCadE.BackColor = Color.DarkSeaGreen;
            btnCadE.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadE.Location = new Point(501, 496);
            btnCadE.Name = "btnCadE";
            btnCadE.Size = new Size(177, 43);
            btnCadE.TabIndex = 19;
            btnCadE.Text = "Cadastrar";
            btnCadE.UseVisualStyleBackColor = false;
            btnCadE.Click += btnCadE_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkGray;
            btnSalvar.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(806, 400);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(197, 43);
            btnSalvar.TabIndex = 20;
            btnSalvar.Text = "Salvar Foto";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // FormEleitores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 646);
            Controls.Add(btnSalvar);
            Controls.Add(btnCadE);
            Controls.Add(picEleitor);
            Controls.Add(dtpNascimentoE);
            Controls.Add(mtbTelE);
            Controls.Add(mtbCPFE);
            Controls.Add(txtSenhaE);
            Controls.Add(txtNomeE);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEleitores";
            Text = "FormEleitores";
            ((System.ComponentModel.ISupportInitialize)picEleitor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label13;
        private TextBox txtNomeE;
        private TextBox txtSenhaE;
        private MaskedTextBox mtbCPFE;
        private MaskedTextBox mtbTelE;
        private DateTimePicker dtpNascimentoE;
        private PictureBox picEleitor;
        private Button btnCadE;
        private Button btnSalvar;
    }
}