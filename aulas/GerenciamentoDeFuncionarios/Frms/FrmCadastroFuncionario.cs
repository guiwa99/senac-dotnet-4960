using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            char sexo = rbMasculino.Checked ? 'M' : 'F';
            string tipoContrato = rbClt.Checked ? "CLT" : rbPj.Checked ? "PJ" : "Autonomo";
            decimal salario = decimal.Parse(txtSalario.Text);
            var dataCadastro = DateTime.Now;

            var funcionario = new Funcionario(nome, email, sexo, tipoContrato, salario, dataCadastro);

             FuncionarioRepository.Adicionar(funcionario);
        }
    }
}
