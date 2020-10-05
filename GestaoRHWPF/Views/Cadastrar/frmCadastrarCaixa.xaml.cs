using GestaoRHWPF.DAL;
using GestaoRHWPF.Models;
using System.Windows;

namespace GestaoRHWPF.Views.Cadastrar
{
    /// <summary>
    /// Interaction logic for frmCadastrarCaixa.xaml
    /// </summary>
    public partial class frmCadastrarCaixa : Window
    {
        public frmCadastrarCaixa()
        {
            InitializeComponent();
            txtNumeroCaixa.Focus();
            txtCustodia.ToolTip = "É necessário preencher 3 caracteres: 1 - CORREDOR em que a caixa está (A-Z) , 2 - POSIÇÃO da estante (1-10), 3 - ALTURA da estante (1-4)    Ex: A11";
        }


        private void btnCadastrarCaixa_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumeroCaixa.Text) && !string.IsNullOrWhiteSpace(txtCustodia.Text) && txtNumeroCaixa.Text.Length == 9 && txtCustodia.Text.Length == 3)
            {

                Caixa caixa = new Caixa
                {
                    NumeroCaixa = txtNumeroCaixa.Text,
                    Custodia = txtCustodia.Text,
                };

                if (CaixaDAO.BuscarPorNumeroCaixa(caixa.NumeroCaixa) != null)
                {

                    MessageBox.Show("Caixa com número já existe", "Cadastro de Caixas", MessageBoxButton.OK, MessageBoxImage.Error);
                    LimparFormulario();

                }
                else
                {
                    if (CaixaDAO.BuscarPorCustodia(caixa.Custodia) != null)
                    {
                        MessageBox.Show("Caixa no setor, posição, altura, já existe", "Cadastro de Caixas", MessageBoxButton.OK, MessageBoxImage.Error);
                        LimparFormulario();
                    }
                    else
                    {
                        CaixaDAO.Cadastrar(caixa);
                        MessageBox.Show("Caixa cadastrada com sucesso!", "Cadastro de Caixas", MessageBoxButton.OK, MessageBoxImage.Information);
                        LimparFormulario();
                    }
                }


            }
            else
            {
                MessageBox.Show("Preencha todos os campos para realizar o cadastro!!", "Cadastro de Caixas",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LimparFormulario()
        {
            txtNumeroCaixa.Clear();
            txtCustodia.Clear();
            txtNumeroCaixa.Focus();
        }

    }
}
