namespace PrjVotacao
{
    partial class Formcandidato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formcandidato));
            label1 = new Label();
            btnCadC = new Button();
            dtpNascimentoC = new DateTimePicker();
            mtbTelC = new MaskedTextBox();
            mtbCPFC = new MaskedTextBox();
            txtNomeC = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSenhaC = new TextBox();
            label4 = new Label();
            button1 = new Button();
            picEleitor = new PictureBox();
            txtNumero = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picEleitor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(429, 73);
            label1.Name = "label1";
            label1.Size = new Size(333, 35);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Candidatos";
            // 
            // btnCadC
            // 
            btnCadC.BackColor = Color.DarkSeaGreen;
            btnCadC.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadC.Location = new Point(496, 525);
            btnCadC.Name = "btnCadC";
            btnCadC.Size = new Size(177, 43);
            btnCadC.TabIndex = 32;
            btnCadC.Text = "Cadastrar";
            btnCadC.UseVisualStyleBackColor = false;
            btnCadC.Click += btnCadC_Click;
            // 
            // dtpNascimentoC
            // 
            dtpNascimentoC.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNascimentoC.Location = new Point(360, 204);
            dtpNascimentoC.Name = "dtpNascimentoC";
            dtpNascimentoC.Size = new Size(296, 38);
            dtpNascimentoC.TabIndex = 30;
            // 
            // mtbTelC
            // 
            mtbTelC.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtbTelC.Location = new Point(256, 305);
            mtbTelC.Mask = "(99)99999-9999";
            mtbTelC.Name = "mtbTelC";
            mtbTelC.Size = new Size(400, 38);
            mtbTelC.TabIndex = 29;
            // 
            // mtbCPFC
            // 
            mtbCPFC.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtbCPFC.Location = new Point(217, 253);
            mtbCPFC.Mask = "999.999.999-99";
            mtbCPFC.Name = "mtbCPFC";
            mtbCPFC.Size = new Size(439, 38);
            mtbCPFC.TabIndex = 28;
            // 
            // txtNomeC
            // 
            txtNomeC.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeC.Location = new Point(231, 149);
            txtNomeC.Name = "txtNomeC";
            txtNomeC.Size = new Size(425, 38);
            txtNomeC.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(724, 152);
            label13.Name = "label13";
            label13.Size = new Size(57, 25);
            label13.TabIndex = 25;
            label13.Text = "Foto:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(156, 370);
            label12.Name = "label12";
            label12.Size = new Size(87, 25);
            label12.TabIndex = 24;
            label12.Text = "Número:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(156, 318);
            label10.Name = "label10";
            label10.Size = new Size(94, 25);
            label10.TabIndex = 23;
            label10.Text = "Telefone:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(156, 266);
            label9.Name = "label9";
            label9.Size = new Size(55, 25);
            label9.TabIndex = 22;
            label9.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(156, 214);
            label3.Name = "label3";
            label3.Size = new Size(198, 25);
            label3.TabIndex = 21;
            label3.Text = "Data de Nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(156, 162);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 20;
            label2.Text = "Nome:";
            // 
            // txtSenhaC
            // 
            txtSenhaC.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaC.Location = new Point(235, 410);
            txtSenhaC.Name = "txtSenhaC";
            txtSenhaC.Size = new Size(421, 38);
            txtSenhaC.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(156, 423);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 33;
            label4.Text = "Senha:";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(787, 402);
            button1.Name = "button1";
            button1.Size = new Size(248, 43);
            button1.TabIndex = 38;
            button1.Text = "Salvar Foto";
            button1.UseVisualStyleBackColor = false;
            // 
            // picEleitor
            // 
            picEleitor.Image = (Image)resources.GetObject("picEleitor.Image");
            picEleitor.Location = new Point(787, 149);
            picEleitor.Name = "picEleitor";
            picEleitor.Size = new Size(248, 246);
            picEleitor.SizeMode = PictureBoxSizeMode.StretchImage;
            picEleitor.TabIndex = 37;
            picEleitor.TabStop = false;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(249, 357);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(407, 38);
            txtNumero.TabIndex = 39;
            // 
            // Formcandidato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 641);
            Controls.Add(txtNumero);
            Controls.Add(button1);
            Controls.Add(picEleitor);
            Controls.Add(txtSenhaC);
            Controls.Add(label4);
            Controls.Add(btnCadC);
            Controls.Add(dtpNascimentoC);
            Controls.Add(mtbTelC);
            Controls.Add(mtbCPFC);
            Controls.Add(txtNomeC);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Formcandidato";
            Text = "Formcandidato";
            ((System.ComponentModel.ISupportInitialize)picEleitor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCadC;
        private DateTimePicker dtpNascimentoC;
        private MaskedTextBox mtbTelC;
        private MaskedTextBox mtbCPFC;
        private TextBox txtNomeC;
        private Label label13;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label3;
        private Label label2;
        private TextBox txtSenhaC;
        private Label label4;
        private Button button1;
        private PictureBox picEleitor;
        private TextBox txtNumero;
    }
}