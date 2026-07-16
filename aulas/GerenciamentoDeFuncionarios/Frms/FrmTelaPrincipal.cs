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

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            string nomeFuncionario = dgvFuncionarios.SelectedRows[0].Cells[1].Value.ToString();

            var retorno = MessageBox.Show($"Tem certeza que deseja excluir o funcionário {nomeFuncionario}?",
                "Exclusão de funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                int idFuncionario = (int)dgvFuncionarios.SelectedRows[0].Cells[0].Value;

                await FuncionarioRepository.DeletarPorId(idFuncionario);

                MessageBox.Show($"O funcionário {nomeFuncionario} foi excluido com sucesso",
                    "Exclusão de funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await AtualizarTabela();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idFuncionario = (int)dgvFuncionarios.SelectedRows[0].Cells[0].Value;

            new FrmAtualizacaoFuncionario(idFuncionario).ShowDialog();
        }
    }
}
