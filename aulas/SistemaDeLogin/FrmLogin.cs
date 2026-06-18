namespace SistemaDeLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (nomeUsuario == "admin" && senha == "1234")
            {
                MessageBox.Show($"Fez login com sucesso!", "Sucesso ao fazer login", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Usuário ou a senha estão incorretos!", "Erro ao fazer login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
