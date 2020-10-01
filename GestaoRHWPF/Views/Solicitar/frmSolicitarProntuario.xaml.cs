using GestaoRHWPF.DAL;
using GestaoRHWPF.Models;
using System.Collections.Generic;
using System.Windows;

namespace GestaoRHWPF.Views.Solicitar
{
    /// <summary>
    /// Interaction logic for frmSolicitarProntuario.xaml
    /// </summary>
    public partial class frmSolicitarProntuario : Window
    {
        private Solicitacao solicitacao = new Solicitacao();
        private Prontuario prontuario = new Prontuario();
        private List<dynamic> itens = new List<dynamic>();
        public frmSolicitarProntuario()
        {
            InitializeComponent();
            cboFuncionarios.Focus();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboFuncionarios.ItemsSource = FuncionarioDAO.Listar();
            cboFuncionarios.DisplayMemberPath = "Matricula";
            cboFuncionarios.SelectedValuePath = "Id";

            cboCaixa.ItemsSource = CaixaDAO.Listar();
            cboCaixa.DisplayMemberPath = "NumeroCaixa";
            cboCaixa.SelectedValuePath = "Id";
        }

        private void btnSolicitarProntuario_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cboFuncionarios.Text))
            {

                int id = (int)cboFuncionarios.SelectedValue;
                prontuario.Funcionario = FuncionarioDAO.BuscarPorId(id);

                int idC = (int)cboCaixa.SelectedValue;
                prontuario.Caixa = CaixaDAO.BuscarPorId(idC);

                PopularItensSolicitacao(prontuario);
                PopularDataGrid(prontuario);
                dtaSolicitacoes.ItemsSource = itens;
                dtaSolicitacoes.Items.Refresh();



                MessageBox.Show("Solicitação realizada com sucesso!", "Solicitação de Prontuários",
                    MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("É necessário selecionar os dados primeiro!", "Solicitação de Prontuários",
                      MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void PopularItensSolicitacao(Prontuario prontuario)
        {
            solicitacao.Itens.Add(
                new ItemSolicitacao
                {
                    Prontuario = prontuario
                }
             );
        }
        private void PopularDataGrid(Prontuario prontuario)
        {
            itens.Add(new
            {
                Matricula = prontuario.Funcionario.Matricula,
                Nome = prontuario.Funcionario.Nome,
                NumeroCaixa = prontuario.Caixa.NumeroCaixa,
                PosicaoCorredor = prontuario.Caixa.PosicaoCorredor,
                PosicaoEstante = prontuario.Caixa.PosicaoEstante,
                PosicaoAltura = prontuario.Caixa.PosicaoAltura,
                CriadoEm = solicitacao.CriadoEm,
            });
        }

        private void btnCadastrarSolicitacao_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)cboFuncionarios.SelectedValue;
            solicitacao.Funcionario = FuncionarioDAO.BuscarPorId(id);

            int idC = (int)cboCaixa.SelectedValue;
            solicitacao.Caixa = CaixaDAO.BuscarPorId(idC);

            if (SolicitacaoDAO.Cadastrar(solicitacao))
            {
                MessageBox.Show("Solicitação cadastrada com sucesso!", "Solicitação de Prontuários",
                   MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não é possível cadastrar a mesma solitação", "Solicitação de Prontuários",
            MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
