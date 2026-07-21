using GerenciamentoDeFuncionarios.Banco.Repositories;

namespace GerenciamentoDeFuncionarios.Frms
{
    public partial class FrmAtualizacaoFuncionario : Form
    {
        private int idFuncionario;

        public FrmAtualizacaoFuncionario(int idFuncionario)
        {
            InitializeComponent();

            this.idFuncionario = idFuncionario;
            Load += FrmAtualizacaoFuncionario_Load;
        }

        private async void FrmAtualizacaoFuncionario_Load(object? sender, EventArgs e)
        {
            var funcionario = await FuncionarioRepository.ObterPorId(this.idFuncionario);

            txtNome.Text = funcionario.Nome;
            txtEmail.Text = funcionario.Email;
            txtSalario.Text = funcionario.Salario.ToString();

            switch (funcionario.Sexo)
            {
                case 'M':
                    rbMasculino.Checked = true;
                    break;
                case 'F':
                    rbFeminino.Checked = true;
                    break;
            }

            switch (funcionario.TipoDeContrato)
            {
                case "CLT":
                    rbClt.Checked = true;
                    break;
                case "PJ":
                    rbPj.Checked = true;
                    break;
                case "Autonomo":
                    rbAutonomo.Checked = true;
                    break;
            }
        }
    }
}
