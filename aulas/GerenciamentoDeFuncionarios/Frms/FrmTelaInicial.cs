using GerenciamentoDeFuncionarios.Frms;

namespace GerenciamentoDeFuncionarios
{
    public partial class FrmTelaInicial : Form
    {
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        private void btnSouAdministrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmLoginAdministrador().ShowDialog();
            this.Show();
        }
    }
}
