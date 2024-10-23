namespace PrjVotacao
{
    partial class FormResultados
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
            lblVotosBranco = new Label();
            lblTotalVotos = new Label();
            lblPercentualNulos = new Label();
            lblPercentualBranco = new Label();
            lblVotosNulos = new Label();
            listResultados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(511, 65);
            label1.Name = "label1";
            label1.Size = new Size(162, 35);
            label1.TabIndex = 2;
            label1.Text = "Resultados";
            // 
            // lblVotosBranco
            // 
            lblVotosBranco.AutoSize = true;
            lblVotosBranco.BorderStyle = BorderStyle.FixedSingle;
            lblVotosBranco.Font = new Font("Yu Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblVotosBranco.Location = new Point(588, 164);
            lblVotosBranco.Name = "lblVotosBranco";
            lblVotosBranco.Size = new Size(2, 29);
            lblVotosBranco.TabIndex = 3;
            // 
            // lblTotalVotos
            // 
            lblTotalVotos.AutoSize = true;
            lblTotalVotos.BorderStyle = BorderStyle.FixedSingle;
            lblTotalVotos.Font = new Font("Yu Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalVotos.Location = new Point(588, 110);
            lblTotalVotos.Name = "lblTotalVotos";
            lblTotalVotos.Size = new Size(2, 29);
            lblTotalVotos.TabIndex = 4;
            // 
            // lblPercentualNulos
            // 
            lblPercentualNulos.AutoSize = true;
            lblPercentualNulos.BorderStyle = BorderStyle.FixedSingle;
            lblPercentualNulos.Font = new Font("Yu Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPercentualNulos.Location = new Point(588, 318);
            lblPercentualNulos.Name = "lblPercentualNulos";
            lblPercentualNulos.Size = new Size(2, 29);
            lblPercentualNulos.TabIndex = 5;
            // 
            // lblPercentualBranco
            // 
            lblPercentualBranco.AutoSize = true;
            lblPercentualBranco.BorderStyle = BorderStyle.FixedSingle;
            lblPercentualBranco.Font = new Font("Yu Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPercentualBranco.Location = new Point(588, 268);
            lblPercentualBranco.Name = "lblPercentualBranco";
            lblPercentualBranco.Size = new Size(2, 29);
            lblPercentualBranco.TabIndex = 6;
            // 
            // lblVotosNulos
            // 
            lblVotosNulos.AutoSize = true;
            lblVotosNulos.BorderStyle = BorderStyle.FixedSingle;
            lblVotosNulos.Font = new Font("Yu Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblVotosNulos.Location = new Point(588, 222);
            lblVotosNulos.Name = "lblVotosNulos";
            lblVotosNulos.Size = new Size(2, 29);
            lblVotosNulos.TabIndex = 7;
            // 
            // listResultados
            // 
            listResultados.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listResultados.FormattingEnabled = true;
            listResultados.ItemHeight = 25;
            listResultados.Location = new Point(328, 374);
            listResultados.Name = "listResultados";
            listResultados.Size = new Size(528, 204);
            listResultados.TabIndex = 8;
            // 
            // FormResultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 642);
            Controls.Add(listResultados);
            Controls.Add(lblVotosNulos);
            Controls.Add(lblPercentualBranco);
            Controls.Add(lblPercentualNulos);
            Controls.Add(lblTotalVotos);
            Controls.Add(lblVotosBranco);
            Controls.Add(label1);
            Name = "FormResultados";
            Text = "FormResultados";
            Load += FormResultados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblVotosBranco;
        private Label lblTotalVotos;
        private Label lblPercentualNulos;
        private Label lblPercentualBranco;
        private Label lblVotosNulos;
        private ListBox listResultados;
    }
}