   M S B A M L   `   `   `  ����F  BGestaoRHWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:GestaoRHWPF.Views.CadastrarGestaoRHWPF.Views.Cadastrar  5   	   8    2GestaoRHWPF.Views.Cadastrar.frmCadastrarProntuario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:GestaoRHWPF.Views.Cadastrar     5   	   -   5          � Title$  Cadastro de Prontuários��5   	   $	��488��6)   $	��820��66    � WindowStartupLocation$ CenterScreen=�6Y   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6   � 5      $ 	#FF0069B2��6    � Offset$ 1Q�6-   5      .��5      � ��5   
   �� 5       �� ImageSource$% /Images/CadastroProntuarios.jpg��6    j� TileMode$
 None=�6G    j� Stretch$
 Fill=�6W   .+�5   
   �� $��Cadastro de Prontuários��6   $��Center=�62   $��0,16,0,0q�6O   $	��Top=�6a   
�������$��28(�6�   $��Medium"�6�   �� 5   
   $-��'Selecione a matrícula do funcionário:��6   $
��Left=�6@   $��	57,95,0,0q�6[   $	��Top=�6n   
�������$��32��6�   $	��260��6�   �� 5   
   -   5        	 ��Name$	 cboFuncionarios��5      $
��Left=�6,   $��
51,143,0,0q�6G   $	��Top=�6[   $	��253��6s   $��33��6   $��16(�6�   6�   �� 5   
   -   5        
 ��Name$
 txtNomeFuncionario��5      $
��Left=�6.   $��
51,199,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��253��6�   $��37��6�   ${�False��6�   $��16(�6�   $��Medium"�6�   �� 5   
   $��Nome do Funcionário��6   $
��Left=�6.   $��105,248,0,0q�6I   $	��Top=�6^   ${�False��6v   
�������$��32��6�   $	��164��6�   �� 5   
   $#��Selecione o número da caixa:��6   $
��Left=�67   $��
513,95,0,0q�6R   $	��Top=�6f   
�������$��32��6�   $	��188��6�   �� 5   
   -   5        $	 	cboCaixas��5      $
��Left=�6&   $��472,143,0,0q�6A   $	��Top=�6V   $	��254��6n   $��33��6z   $��16(�6�   6�   �� 5   
   -   5        $
 txtCustodia��5      $
��Left=�6'   $��473,199,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��253��6�   $��37��6�   ${�False��6�   $��16(�6�   $��Medium"�6�   
�������6�   �� 5   
   $!��Corredor - Estante - Altura��6   $
��Left=�66   $��521,248,0,0q�6Q   $	��Top=�6f   ${�False��6~   
�������$��31��6�   $	��172��6�   �� 5   
   -   5         ��Name$ btnCadastrarProntuario��5      $��	Cadastrar��61   $��Center=�6E   $��	0,362,0,0q�6b   $	��Top=�6u   $��59��6�   $	��148��6�   ���	#FFDDDDDD6�   5       5!      