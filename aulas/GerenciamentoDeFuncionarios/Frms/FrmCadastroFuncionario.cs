using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Text;
using GerenciamentoDeFuncionarios.Banco.Repositories;
using GerenciamentoDeFuncionarios.Modelos;

namespace GerenciamentoDeFuncionarios.Frms
{
    public partial class FrmCadastroFuncionario : Form
    {
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            char sexo = rbMasculino.Checked ? 'M' : 'F';
            string tipoContrato = rbClt.Checked ? "CLT" : rbPj.Checked ? "PJ" : "Autonomo";
            decimal salario = decimal.Parse(txtSalario.Text);
            var dataCadastro = DateTime.Now;

            var funcionario = new Funcionario(nome, email, sexo, tipoContrato, salario, dataCadastro);

            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();

            var contexto = new ValidationContext(funcionario);
            Validator.TryValidateObject(funcionario, contexto, listaDeErros, true);

            if (listaDeErros.Count > 0)
            {
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                }

                lblErros.Text = stringBuilder.ToString();
            }
            else
            {
                await FuncionarioRepository.Adicionar(funcionario);

                this.Close();
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(",")) 
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && ((TextBox)sender).Text == string.Empty)
            {
                e.Handled = true;
            }
        }
    }
}
