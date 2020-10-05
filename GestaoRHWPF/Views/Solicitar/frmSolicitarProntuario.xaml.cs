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

            //cboCaixa.ItemsSource = CaixaDAO.Listar();
            //cboCaixa.DisplayMemberPath = "NumeroCaixa";
            //cboCaixa.SelectedValuePath = "Id";
        }
        private void cboFuncionarios_DropDownClosed(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cboFuncionarios.Text))
            {
                int id = (int)cboFuncionarios.SelectedValue;

                Funcionario funcionario = FuncionarioDAO.BuscarPorId(id);

                txtNomeFuncionario.Text = funcionario.Nome;
            }
        }

        private void btnSolicitarProntuario_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cboFuncionarios.Text))
            {

                int id = (int)cboFuncionarios.SelectedValue;
                if (ProntuarioDAO.BuscarPorIdFuncionarioP(id) != null)
                {

                    Prontuario prontuario = ProntuarioDAO.BuscarPorIdFuncionarioP(id);

                    //int idC = (int)cboCaixa.SelectedValue;
                    //prontuario.Caixa = CaixaDAO.BuscarPorId(idC);

                    PopularItensSolicitacao(prontuario);
                    PopularDataGrid(prontuario);
                    dtaSolicitacoes.ItemsSource = itens;
                    dtaSolicitacoes.Items.Refresh();



                    //MessageBox.Show("Solicitação realizada com sucesso!", "Solicitação de Prontuários",
                    //    MessageBoxButton.OK, MessageBoxImage.Information);
                    btnConcluirAdd.IsEnabled = true;
                    btnAdicionarMais.IsEnabled = true;
                    btnAdicionarMais.Visibility = Visibility.Visible;
                    btnSolicitarProntuario.IsEnabled = false;
                    btnSolicitarProntuario.Visibility = Visibility.Hidden;

                }
                else
                {
                    MessageBox.Show("Não é possível realizar esta solicitação, uma vez que um prontuário com esta matrícula ainda não foi cadastrado! O formulário será fechado!", "Solicitação de Prontuários",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    //itens.Clear();
                    //dtaSolicitacoes.Items.Refresh();
                    //solicitacao.Itens.Clear();
                    Close();
                }
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
             ); ;
        }
        private void PopularDataGrid(Prontuario prontuario)
        {
            itens.Add(new
            {
                //Matricula = prontuario.Funcionario.Matricula,
                //Nome = prontuario.Funcionario.Nome,
                NumeroCaixa = prontuario.Caixa.NumeroCaixa,
                Custodia = prontuario.Caixa.Custodia,
                CriadoEm = prontuario.CriadoEm,

            });

        }
        private void btnConcluirAdd_Click(object sender, RoutedEventArgs e)
        {
            btnCadastrarSolicitacao.IsEnabled = true;
            btnCadastrarSolicitacao.Visibility = Visibility.Visible;
            btnConcluirAdd.IsEnabled = false;
            btnConcluirAdd.Visibility = Visibility.Hidden;
            cboFuncionarios.IsEnabled = false;

        }
        private void btnAdicionarMais_Click(object sender, RoutedEventArgs e)
        {
            btnCadastrarSolicitacao.IsEnabled = false;
            btnCadastrarSolicitacao.Visibility = Visibility.Hidden;
            btnConcluirAdd.IsEnabled = false;
            btnConcluirAdd.Visibility = Visibility.Visible;
            btnSolicitarProntuario.IsEnabled = true;
            btnSolicitarProntuario.Visibility = Visibility.Visible;
            btnAdicionarMais.IsEnabled = false;
            btnAdicionarMais.Visibility = Visibility.Hidden;
            cboFuncionarios.IsEnabled = true;
        }

        private void btnCadastrarSolicitacao_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)cboFuncionarios.SelectedValue;
            Prontuario prontuario = ProntuarioDAO.BuscarPorIdFuncionarioP(id);
            solicitacao.Funcionario = FuncionarioDAO.BuscarPorId(id);
            solicitacao.Caixa = prontuario.Caixa;

            if (SolicitacaoDAO.Cadastrar(solicitacao))
            {
                MessageBox.Show($"Solicitação realizada! O número de sua solicitação é: [{id}]", "Solicitação de Prontuários",
               MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro! Algum prontuário já possui uma solicitação em aberto", "Solicitação de Prontuários",
               MessageBoxButton.OK, MessageBoxImage.Error);
                itens.Clear();
                dtaSolicitacoes.Items.Refresh();
                solicitacao.Itens.Clear();

                btnCadastrarSolicitacao.IsEnabled = false;
                btnCadastrarSolicitacao.Visibility = Visibility.Hidden;
                btnConcluirAdd.IsEnabled = false;
                btnConcluirAdd.Visibility = Visibility.Visible;
                btnAdicionarMais.IsEnabled = false;
                btnAdicionarMais.Visibility = Visibility.Hidden;
                btnSolicitarProntuario.IsEnabled = true;
                btnSolicitarProntuario.Visibility = Visibility.Visible;


            }

        }

        private void LimparFormulario()
        {
            txtNomeFuncionario.Clear();
            cboFuncionarios.Text = "";
            cboFuncionarios.Focus();
        }

    }
}
