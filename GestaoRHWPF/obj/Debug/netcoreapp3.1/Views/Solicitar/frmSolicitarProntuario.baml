   M S B A M L   `   `   `  ����F  BGestaoRHWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:GestaoRHWPF.Views.SolicitarGestaoRHWPF.Views.Solicitar  5   	   8    2GestaoRHWPF.Views.Solicitar.frmSolicitarProntuario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:GestaoRHWPF.Views.Solicitar     5   	   -   5          � Title$#  Solicitação de Prontuários��5   	   $	��584��6,   $
��1180��69    � WindowStartupLocation$ CenterScreen=�6F   .��5	      � ��5
   
   �� 5       �� ImageSource$% /Images/SolicitarProntuario.jpg��6    j� Stretch$
 Fill=�6G   .+�5   
   �� $#��Solicitação de Prontuários��6   $
��Left=�65   $��
538,10,0,0q�6P   $	��Top=�6d   
���   �$��25(�6�   $��Normal"�6�   �� 5   
   $-��'Selecione a matrícula do funcionário:��6   $
��Left=�6@   $��	40,54,0,0q�6[   $	��Top=�6n   $��16(�6�   $��37��6�   $	��282��6�    � ForceCursor$
 True��6�   $��Medium"�6�   �� 5   
   -   5         ��Name$ cboFuncionarios��5      $
��Left=�6,   $��	40,96,0,0q�6G   $	��Top=�6Z   $	��270��6r   $��36��6~   $��16(�6�   $��0��6�   �� 5   
   -   5         ��Name$ txtNomeFuncionario��5      $
��Left=�6.   $��
40,147,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��270��6�   $��36��6�   ${�False��6�   $��18(�6�   $��Medium"�6�   �� 5   
   $��Nome do Funcionário��6   $
��Left=�6.   $��
89,183,0,0q�6I   $	��Top=�6]   ${�False��6u   $��16(�6�   $��37��6�   $	��170��6�   
���   �$��Medium"�6�   �� 5   
   -   5         ��Name$ btnSolicitarProntuario��5      $)��#ADD Prontuário(s) à solicitação��61   $
��Left=�6[   $��
60,345,0,0q�6v   $	��Top=�6�   $��59��6�   $	��228��6�   $��15(�6�   $��Regular"�6�   $��1��6  �� 5   
   -   5        $ btnAdicionarMais��5      $!��Adicionar mais prontuários��6+   $
��Left=�6P   $��
60,345,0,0q�6k   $	��Top=�6   $��59��6�   $	��228��6�   $y�Hidden=�6�   $��15(�6�   $��Regular"�6�   $��1��6�   6�   �� 5   
   -   5        $ btnCadastrarSolicitacao��5      $��Cadastrar Solicitação��62   $
��Left=�6R   $��
60,421,0,0q�6m   $	��Top=�6�   $��56��6�   $	��228��6�   ${�False��6�   $y�Hidden=�6�   $��15(�6�   $��Regular"�6  $��2��6   �� 5   
   -   5        $ btnConcluirAdd��5      $��Concluir��6)   $
��Left=�6<   $��
60,421,0,0q�6W   $	��Top=�6k   $��56��6�   $	��228��6�   ${�False��6�   $��15(�6�   $��Regular"�6�   $��2��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dtaSolicitacoes��5      
   AutoGenerateColumns$
 False��6,   $��348,62,21,72q�6H   $��18(�6^   $��Medium"�6l   ��5      �� 5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Número da Caixa��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *NumeroCaixa+  5      $ Custodia��6%   $ 1* 67    6B   �� *
Custodia+  5      $ 	Criado Em��6%   $ 2* 68    6C   �� *
CriadoEm+5       �� 5!   
   $
��Left=�6   $	��257��62   $��170,140,0,0q�6?   $	��Top=�6T   $��6��6l    J� RenderTransformOrigin$ 0.5,0.5&�6v   ${�False��6�   z�5"      V� 5#      .~�5$      ��  �� ScaleX$ 0.926Q�6%    �� ScaleY$
 1.08Q�64   �� 5%       �� AngleY$ 0.034Q�6$   �� 5&       �� Angle$ 90.202Q�6&   T� 5'      5(      5*      5,      5-      