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
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();

            Load += FrmTelaPrincipal_Load;
        }

        private async void FrmTelaPrincipal_Load(object? sender, EventArgs e)
        {
            await AtualizarTabela();
        }

        private async void btnNovo_Click(object sender, EventArgs e)
        {
            new FrmCadastroFuncionario().ShowDialog();

            await AtualizarTabela();
        }

        private async Task AtualizarTabela()
        {
            var funcionarios = await FuncionarioRepository.ObterTodos();

            dgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionarios.ToList());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // pegar o nome do funcionário e exibir uma mensagem perguntando 
            // se o usuario tem certeza que deseja excluir
            string nomeFuncionario = dgvFuncionarios.SelectedRows[0].Cells[1].Value.ToString();

            MessageBox.Show($"Tem certeza que deseja excluir o funcionário {nomeFuncionario}?",
                "Exclusão de funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // se sim, exclui o funcionário do banco e exibe mensagem de sucesso

            // se não, só fecha MessageBox e volta para a tela principal
        }
    }
}
