namespace SistemaDeLogin
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(string nomeUsuario)
        {
            InitializeComponent();

            lblNomeUsuario.Text = $"Bem vindo {nomeUsuario}";
        }
    }
}
