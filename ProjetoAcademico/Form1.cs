namespace ProjetoAcademico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisciplinas frm = new FrmDisciplinas();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
