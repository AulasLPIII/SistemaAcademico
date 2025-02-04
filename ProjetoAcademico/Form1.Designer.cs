namespace ProjetoAcademico
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
            MenuAplicacao = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            disciplinasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            MenuAplicacao.SuspendLayout();
            SuspendLayout();
            // 
            // MenuAplicacao
            // 
            MenuAplicacao.ImageScalingSize = new Size(20, 20);
            MenuAplicacao.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem });
            MenuAplicacao.Location = new Point(0, 0);
            MenuAplicacao.Name = "MenuAplicacao";
            MenuAplicacao.Size = new Size(800, 28);
            MenuAplicacao.TabIndex = 1;
            MenuAplicacao.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinasToolStripMenuItem, sairToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(86, 24);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // disciplinasToolStripMenuItem
            // 
            disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            disciplinasToolStripMenuItem.Size = new Size(224, 26);
            disciplinasToolStripMenuItem.Text = "Disciplinas";
            disciplinasToolStripMenuItem.Click += disciplinasToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(224, 26);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuAplicacao);
            IsMdiContainer = true;
            MainMenuStrip = MenuAplicacao;
            Name = "Form1";
            Text = "Sistema Academico";
            WindowState = FormWindowState.Maximized;
            MenuAplicacao.ResumeLayout(false);
            MenuAplicacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuAplicacao;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem disciplinasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
