namespace ProjetoAcademico
{
    partial class FrmDisciplinas
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
            LblSigla = new Label();
            TxtSigla = new TextBox();
            TxtNome = new TextBox();
            label1 = new Label();
            GrpbCargaHoraria = new GroupBox();
            Rd90 = new RadioButton();
            Rd80 = new RadioButton();
            Rd40 = new RadioButton();
            LblModulo = new Label();
            CmbModulo = new ComboBox();
            GrpbTipo = new GroupBox();
            RdTeoricaPratica = new RadioButton();
            RdPratica = new RadioButton();
            RdTeorica = new RadioButton();
            groupBox1 = new GroupBox();
            RdNao = new RadioButton();
            RdSim = new RadioButton();
            BarraPadrao = new ToolStrip();
            BarraBtnNovo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            BarraBtnSalvar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            BarraBtnListar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            BarraBtnDeletar = new ToolStripButton();
            GrpbCargaHoraria.SuspendLayout();
            GrpbTipo.SuspendLayout();
            groupBox1.SuspendLayout();
            BarraPadrao.SuspendLayout();
            SuspendLayout();
            // 
            // LblSigla
            // 
            LblSigla.AutoSize = true;
            LblSigla.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSigla.Location = new Point(12, 100);
            LblSigla.Name = "LblSigla";
            LblSigla.Size = new Size(67, 26);
            LblSigla.TabIndex = 0;
            LblSigla.Text = "Sigla:";
            // 
            // TxtSigla
            // 
            TxtSigla.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSigla.Location = new Point(97, 96);
            TxtSigla.Name = "TxtSigla";
            TxtSigla.Size = new Size(125, 30);
            TxtSigla.TabIndex = 1;
            // 
            // TxtNome
            // 
            TxtNome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNome.Location = new Point(97, 142);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(426, 30);
            TxtNome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 146);
            label1.Name = "label1";
            label1.Size = new Size(79, 26);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            // 
            // GrpbCargaHoraria
            // 
            GrpbCargaHoraria.Controls.Add(Rd90);
            GrpbCargaHoraria.Controls.Add(Rd80);
            GrpbCargaHoraria.Controls.Add(Rd40);
            GrpbCargaHoraria.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GrpbCargaHoraria.Location = new Point(12, 206);
            GrpbCargaHoraria.Name = "GrpbCargaHoraria";
            GrpbCargaHoraria.Size = new Size(511, 90);
            GrpbCargaHoraria.TabIndex = 4;
            GrpbCargaHoraria.TabStop = false;
            GrpbCargaHoraria.Text = "Carga Horária";
            // 
            // Rd90
            // 
            Rd90.AutoSize = true;
            Rd90.Location = new Point(384, 43);
            Rd90.Name = "Rd90";
            Rd90.Size = new Size(63, 27);
            Rd90.TabIndex = 2;
            Rd90.Text = "90h";
            Rd90.UseVisualStyleBackColor = true;
            // 
            // Rd80
            // 
            Rd80.AutoSize = true;
            Rd80.Checked = true;
            Rd80.Location = new Point(205, 43);
            Rd80.Name = "Rd80";
            Rd80.Size = new Size(63, 27);
            Rd80.TabIndex = 1;
            Rd80.TabStop = true;
            Rd80.Text = "80h";
            Rd80.UseVisualStyleBackColor = true;
            // 
            // Rd40
            // 
            Rd40.AutoSize = true;
            Rd40.Location = new Point(32, 43);
            Rd40.Name = "Rd40";
            Rd40.Size = new Size(63, 27);
            Rd40.TabIndex = 0;
            Rd40.Text = "40h";
            Rd40.UseVisualStyleBackColor = true;
            // 
            // LblModulo
            // 
            LblModulo.AutoSize = true;
            LblModulo.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblModulo.Location = new Point(12, 318);
            LblModulo.Name = "LblModulo";
            LblModulo.Size = new Size(91, 26);
            LblModulo.TabIndex = 5;
            LblModulo.Text = "Módulo:";
            // 
            // CmbModulo
            // 
            CmbModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbModulo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbModulo.FormattingEnabled = true;
            CmbModulo.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            CmbModulo.Location = new Point(109, 313);
            CmbModulo.Name = "CmbModulo";
            CmbModulo.Size = new Size(72, 31);
            CmbModulo.TabIndex = 6;
            // 
            // GrpbTipo
            // 
            GrpbTipo.Controls.Add(RdTeoricaPratica);
            GrpbTipo.Controls.Add(RdPratica);
            GrpbTipo.Controls.Add(RdTeorica);
            GrpbTipo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GrpbTipo.Location = new Point(12, 371);
            GrpbTipo.Name = "GrpbTipo";
            GrpbTipo.Size = new Size(511, 90);
            GrpbTipo.TabIndex = 7;
            GrpbTipo.TabStop = false;
            GrpbTipo.Text = "Tipo da Disciplina";
            // 
            // RdTeoricaPratica
            // 
            RdTeoricaPratica.AutoSize = true;
            RdTeoricaPratica.Location = new Point(305, 41);
            RdTeoricaPratica.Name = "RdTeoricaPratica";
            RdTeoricaPratica.Size = new Size(180, 27);
            RdTeoricaPratica.TabIndex = 4;
            RdTeoricaPratica.Text = "Teórica e Prática";
            RdTeoricaPratica.UseVisualStyleBackColor = true;
            // 
            // RdPratica
            // 
            RdPratica.AutoSize = true;
            RdPratica.Location = new Point(166, 41);
            RdPratica.Name = "RdPratica";
            RdPratica.Size = new Size(93, 27);
            RdPratica.TabIndex = 3;
            RdPratica.Text = "Prática";
            RdPratica.UseVisualStyleBackColor = true;
            // 
            // RdTeorica
            // 
            RdTeorica.AutoSize = true;
            RdTeorica.Checked = true;
            RdTeorica.Location = new Point(17, 41);
            RdTeorica.Name = "RdTeorica";
            RdTeorica.Size = new Size(95, 27);
            RdTeorica.TabIndex = 2;
            RdTeorica.TabStop = true;
            RdTeorica.Text = "Teórica";
            RdTeorica.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RdNao);
            groupBox1.Controls.Add(RdSim);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 479);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 90);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pertence ao Eixo Tecnológico?";
            // 
            // RdNao
            // 
            RdNao.AutoSize = true;
            RdNao.Location = new Point(305, 43);
            RdNao.Name = "RdNao";
            RdNao.Size = new Size(66, 27);
            RdNao.TabIndex = 2;
            RdNao.Text = "Não";
            RdNao.UseVisualStyleBackColor = true;
            // 
            // RdSim
            // 
            RdSim.AutoSize = true;
            RdSim.Checked = true;
            RdSim.Location = new Point(105, 43);
            RdSim.Name = "RdSim";
            RdSim.Size = new Size(64, 27);
            RdSim.TabIndex = 0;
            RdSim.TabStop = true;
            RdSim.Text = "Sim";
            RdSim.UseVisualStyleBackColor = true;
            // 
            // BarraPadrao
            // 
            BarraPadrao.ImageScalingSize = new Size(20, 20);
            BarraPadrao.Items.AddRange(new ToolStripItem[] { BarraBtnNovo, toolStripSeparator1, BarraBtnSalvar, toolStripSeparator2, BarraBtnListar, toolStripSeparator3, BarraBtnDeletar });
            BarraPadrao.Location = new Point(0, 0);
            BarraPadrao.Name = "BarraPadrao";
            BarraPadrao.Size = new Size(800, 71);
            BarraPadrao.TabIndex = 11;
            BarraPadrao.Text = "toolStrip1";
            // 
            // BarraBtnNovo
            // 
            BarraBtnNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BarraBtnNovo.Image = Properties.Resources.novo;
            BarraBtnNovo.ImageScaling = ToolStripItemImageScaling.None;
            BarraBtnNovo.ImageTransparentColor = Color.Magenta;
            BarraBtnNovo.Name = "BarraBtnNovo";
            BarraBtnNovo.Size = new Size(68, 68);
            BarraBtnNovo.Text = "toolStripButton1";
            BarraBtnNovo.ToolTipText = "Nova Disciplina";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 71);
            // 
            // BarraBtnSalvar
            // 
            BarraBtnSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BarraBtnSalvar.Image = Properties.Resources.salvar;
            BarraBtnSalvar.ImageScaling = ToolStripItemImageScaling.None;
            BarraBtnSalvar.ImageTransparentColor = Color.Magenta;
            BarraBtnSalvar.Name = "BarraBtnSalvar";
            BarraBtnSalvar.Size = new Size(68, 68);
            BarraBtnSalvar.Text = "toolStripButton1";
            BarraBtnSalvar.ToolTipText = "Salvar uma Disciplina";
            BarraBtnSalvar.Click += BarraBtnSalvar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 71);
            // 
            // BarraBtnListar
            // 
            BarraBtnListar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BarraBtnListar.Image = Properties.Resources.listar;
            BarraBtnListar.ImageScaling = ToolStripItemImageScaling.None;
            BarraBtnListar.ImageTransparentColor = Color.Magenta;
            BarraBtnListar.Name = "BarraBtnListar";
            BarraBtnListar.Size = new Size(68, 68);
            BarraBtnListar.Text = "toolStripButton1";
            BarraBtnListar.ToolTipText = "Listar Disciplinas";
            BarraBtnListar.Click += BarraBtnListar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 71);
            // 
            // BarraBtnDeletar
            // 
            BarraBtnDeletar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BarraBtnDeletar.Image = Properties.Resources.deletar;
            BarraBtnDeletar.ImageScaling = ToolStripItemImageScaling.None;
            BarraBtnDeletar.ImageTransparentColor = Color.Magenta;
            BarraBtnDeletar.Name = "BarraBtnDeletar";
            BarraBtnDeletar.Size = new Size(68, 68);
            BarraBtnDeletar.Text = "toolStripButton1";
            BarraBtnDeletar.ToolTipText = "Apagar uma Disciplina";
            BarraBtnDeletar.Click += BarraBtnDeletar_Click;
            // 
            // FrmDisciplinas
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 593);
            Controls.Add(BarraPadrao);
            Controls.Add(groupBox1);
            Controls.Add(GrpbTipo);
            Controls.Add(CmbModulo);
            Controls.Add(LblModulo);
            Controls.Add(GrpbCargaHoraria);
            Controls.Add(TxtNome);
            Controls.Add(label1);
            Controls.Add(TxtSigla);
            Controls.Add(LblSigla);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "FrmDisciplinas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Disciplinas";
            GrpbCargaHoraria.ResumeLayout(false);
            GrpbCargaHoraria.PerformLayout();
            GrpbTipo.ResumeLayout(false);
            GrpbTipo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            BarraPadrao.ResumeLayout(false);
            BarraPadrao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblSigla;
        private TextBox TxtSigla;
        private TextBox TxtNome;
        private Label label1;
        private GroupBox GrpbCargaHoraria;
        private RadioButton Rd90;
        private RadioButton Rd80;
        private RadioButton Rd40;
        private Label LblModulo;
        private ComboBox CmbModulo;
        private GroupBox GrpbTipo;
        private GroupBox groupBox1;
        private RadioButton RdNao;
        private RadioButton RdSim;
        private ToolStrip BarraPadrao;
        private ToolStripButton BarraBtnNovo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BarraBtnSalvar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton BarraBtnListar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton BarraBtnDeletar;
        private RadioButton RdPratica;
        private RadioButton RdTeorica;
        private RadioButton RdTeoricaPratica;
    }
}