using GestaoRHWPF.DAL;
using GestaoRHWPF.Models;
using System.Windows;

namespace GestaoRHWPF.Views.Cadastrar
{
    /// <summary>
    /// Interaction logic for frmCadastrarProntuario.xaml
    /// </summary>
    public partial class frmCadastrarProntuario : Window
    {
        public frmCadastrarProntuario()
        {
            InitializeComponent();
            cboFuncionarios.Focus();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboFuncionarios.ItemsSource = FuncionarioDAO.Listar();
            cboFuncionarios.DisplayMemberPath = "Matricula";
            cboFuncionarios.SelectedValuePath = "Id";



            cboCaixas.ItemsSource = CaixaDAO.Listar();
            cboCaixas.DisplayMemberPath = "NumeroCaixa";
            cboCaixas.SelectedValuePath = "Id";

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

        private void cboCaixas_DropDownClosed(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cboCaixas.Text))
            {
                int id = (int)cboCaixas.SelectedValue;
                Caixa caixa = CaixaDAO.BuscarPorId(id);

                txtCustodia.Text = caixa.Custodia;
            }
        }

        private void btnCadastrarProntuario_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cboFuncionarios.Text) || !string.IsNullOrWhiteSpace(cboCaixas.Text))
            {
                int id = (int)cboFuncionarios.SelectedValue;
                Funcionario funcionario = FuncionarioDAO.BuscarPorId(id);

                int idC = (int)cboCaixas.SelectedValue;
                Caixa caixa = CaixaDAO.BuscarPorId(idC);

                if (caixa != null && funcionario != null)
                {
                    Prontuario prontuario = new Prontuario
                    {
                        Funcionario = funcionario,
                        Caixa = caixa
                    };

                    if (ProntuarioDAO.BuscarPorMatriculaP(prontuario.Funcionario.Matricula) != null)
                    {
                        MessageBox.Show("Esta matrícula já está vinculada a um Prontuário existente", "Cadastro de Prontuários", MessageBoxButton.OK, MessageBoxImage.Error);
                        LimparFormulario();
                    }
                    else if (ProntuarioDAO.BuscarPorIdCaixaP(prontuario.Caixa.Id) != null)
                    {
                        MessageBox.Show("Esta caixa já se encontra ocupada", "Cadastro de Prontuários", MessageBoxButton.OK, MessageBoxImage.Error);
                        LimparFormulario();
                    }
                    else
                    {
                        ProntuarioDAO.Cadastrar(prontuario);
                        MessageBox.Show("Prontuário cadastrado com sucesso!", "Cadastro de Prontuários", MessageBoxButton.OK, MessageBoxImage.Information);
                        LimparFormulario();
                    }
                }
                else
                {
                    MessageBox.Show("Dados não encontrados!", "Cadastro de Prontuários", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar os dados primeiro!", "Cadastro de Prontuários", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void LimparFormulario()
        {
            txtNomeFuncionario.Clear();
            txtCustodia.Clear();
            cboFuncionarios.Text = "";
            cboCaixas.Text = "";
            cboFuncionarios.Focus();
        }
    }
}
