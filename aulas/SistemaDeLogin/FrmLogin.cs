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
                this.Hide();
                string nome = txtNome.Text;
                new MenuPrincipal(nome).ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show($"Usuário ou a senha estão incorretos!", "Erro ao fazer login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
