namespace PrjVotacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            eleitoresToolStripMenuItem = new ToolStripMenuItem();
            candidatosToolStripMenuItem = new ToolStripMenuItem();
            votaçãoToolStripMenuItem = new ToolStripMenuItem();
            votarToolStripMenuItem = new ToolStripMenuItem();
            resultadosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, votaçãoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1172, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eleitoresToolStripMenuItem, candidatosToolStripMenuItem });
            cadastrarToolStripMenuItem.Font = new Font("Yu Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            cadastrarToolStripMenuItem.Image = (Image)resources.GetObject("cadastrarToolStripMenuItem.Image");
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(183, 42);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // eleitoresToolStripMenuItem
            // 
            eleitoresToolStripMenuItem.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            eleitoresToolStripMenuItem.Image = (Image)resources.GetObject("eleitoresToolStripMenuItem.Image");
            eleitoresToolStripMenuItem.Name = "eleitoresToolStripMenuItem";
            eleitoresToolStripMenuItem.Size = new Size(199, 32);
            eleitoresToolStripMenuItem.Text = "Eleitores";
            eleitoresToolStripMenuItem.Click += eleitoresToolStripMenuItem_Click;
            // 
            // candidatosToolStripMenuItem
            // 
            candidatosToolStripMenuItem.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            candidatosToolStripMenuItem.Image = (Image)resources.GetObject("candidatosToolStripMenuItem.Image");
            candidatosToolStripMenuItem.Name = "candidatosToolStripMenuItem";
            candidatosToolStripMenuItem.Size = new Size(199, 32);
            candidatosToolStripMenuItem.Text = "Candidatos";
            candidatosToolStripMenuItem.Click += candidatosToolStripMenuItem_Click;
            // 
            // votaçãoToolStripMenuItem
            // 
            votaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { votarToolStripMenuItem, resultadosToolStripMenuItem });
            votaçãoToolStripMenuItem.Font = new Font("Yu Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            votaçãoToolStripMenuItem.Image = (Image)resources.GetObject("votaçãoToolStripMenuItem.Image");
            votaçãoToolStripMenuItem.Name = "votaçãoToolStripMenuItem";
            votaçãoToolStripMenuItem.Size = new Size(159, 42);
            votaçãoToolStripMenuItem.Text = "Votação";
            votaçãoToolStripMenuItem.Click += votaçãoToolStripMenuItem_Click;
            // 
            // votarToolStripMenuItem
            // 
            votarToolStripMenuItem.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            votarToolStripMenuItem.Image = (Image)resources.GetObject("votarToolStripMenuItem.Image");
            votarToolStripMenuItem.Name = "votarToolStripMenuItem";
            votarToolStripMenuItem.Size = new Size(198, 32);
            votarToolStripMenuItem.Text = "Votar";
            votarToolStripMenuItem.Click += votarToolStripMenuItem_Click;
            // 
            // resultadosToolStripMenuItem
            // 
            resultadosToolStripMenuItem.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            resultadosToolStripMenuItem.Image = (Image)resources.GetObject("resultadosToolStripMenuItem.Image");
            resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            resultadosToolStripMenuItem.Size = new Size(198, 32);
            resultadosToolStripMenuItem.Text = "Resultados";
            resultadosToolStripMenuItem.Click += resultadosToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 648);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem eleitoresToolStripMenuItem;
        private ToolStripMenuItem candidatosToolStripMenuItem;
        private ToolStripMenuItem votaçãoToolStripMenuItem;
        private ToolStripMenuItem votarToolStripMenuItem;
        private ToolStripMenuItem resultadosToolStripMenuItem;
    }
}