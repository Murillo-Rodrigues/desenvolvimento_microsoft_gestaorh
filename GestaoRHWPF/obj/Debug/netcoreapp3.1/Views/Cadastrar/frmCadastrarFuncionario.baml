   M S B A M L   `   `   `  ����F  BGestaoRHWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:GestaoRHWPF.Views.CadastrarGestaoRHWPF.Views.Cadastrar  5   	   9    3GestaoRHWPF.Views.Cadastrar.frmCadastrarFuncionario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:GestaoRHWPF.Views.Cadastrar     5   	     � Title$  Cadastrar Funcionários��5   	   $	��427��6(   $	��750��65    � WindowStartupLocation$ CenterScreen=�6A   $��16(�6f   $��Medium"�6t   .��5	      � ��5
   
   �� 5       j� Stretch$ UniformToFill=�6    �� ImageSource$&  /Images/CadastroFuncionarios.jpg��61   .+�5   
   �� $��Cadastrar Funcionários��6   $��25(�61   $��Medium"�6?   $��Center=�6S   $��0,10,0,0q�6p   $	��Top=�6�   �� 5   
   $O��IInsira todos os dados abaixo para realizar o cadastro de um funcionário!��6   $��14(�6c   $��Normal"�6q   $��Center=�6�   $��0,58,0,0q�6�   $	��Top=�6�   $��29��6�   $	��462��6�   �� 5   
   $��Matrícula:��6   $
��Left=�6%   $��
14,107,0,0q�6@   $	��Top=�6T   �� 5   
   $��(5 dígitos)��6   $
��Left=�6&   $��665,111,0,0q�6A   $	��Top=�6V   $��13(�6n   $��Normal"�6|    J� RenderTransformOrigin$ 0.679,0.481&�6�   �� 5   
   $��Nome:��6   $
��Left=�6    $��
14,146,0,0q�6;   $	��Top=�6O   �� 5   
   $
��CPF:��6   $
��Left=�6   $��
14,185,0,0q�6:   $	��Top=�6N   �� 5   
   $��	Telefone:��6   $
��Left=�6$   $��
14,221,0,0q�6?   $	��Top=�6S   �� 5   
   -   5         ��Name$ txtMatricula��5      $
��Left=�6(   $��110,115,0,0q�6C    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $	��550��6�   $��0��6�    �� 	MaxLength$ 5��6�   �� 5   
   -   5        $ txtNome��5      $
��Left=�6#   $��110,154,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��550��6   $��1��6�   �� 5   
   -   5        $ txtCpf��5      $
��Left=�6"   $��110,193,0,0q�6=   $
 Wrap=�6R   $	��Top=�6f   $	��550��6~   $��2��6�   $ 11��6�   �� 5   
   -   5        $ txtTelefone��5      $
��Left=�6'   $��110,229,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��550��6�   $��3��6�   $ 10��6�   �� 5   
   -   5         ��Name$ btnCadastrarFuncionario��5      $��	Cadastrar��62   $
��Left=�6F   $��306,314,0,0q�6a   $	��Top=�6v   $��59��6�   $	��158��6�   $��3��6�   ��6�   Z� 5      5      