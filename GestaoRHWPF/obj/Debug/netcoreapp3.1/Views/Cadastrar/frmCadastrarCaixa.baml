   M S B A M L   `   `   `  ����F  BGestaoRHWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:GestaoRHWPF.Views.CadastrarGestaoRHWPF.Views.Cadastrar  5   	   3    -GestaoRHWPF.Views.Cadastrar.frmCadastrarCaixa   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:GestaoRHWPF.Views.Cadastrar     5   	     � Title$  Cadastrar Caixas��5   	   $	��379��6"   $	��683��6/    � WindowStartupLocation$ CenterScreen=�6;   .��5	      � ��5
   
   �� 5       �� ImageSource$  /Images/CadastroCaixas.jpg��6   .+�5   
   �� $��Cadastrar Caixas��6   $��Center=�6+   $��0,17,0,0q�6H   $	��Top=�6Z   $��22(�6r   $��Medium"�6�   �� 5   
   $F��@Preencha os dados abaixo para realizar a criação de uma caixa!��6   $��Center=�6Y   $��0,68,0,0q�6v   $	��Top=�6�   $��15(�6�   $��Medium"�6�   �� 5   
   $��Número da Caixa:��6   $
��Left=�6+   $��
17,128,0,0q�6F   $	��Top=�6Z   $��15(�6r   $��Medium"�6�   $��0,0,0,0q�6�   
���   ���6�   Z� 6�   �� 5   
   $��Posição da Custódia:��6   $
��Left=�6/   $��
17,168,0,0q�6J   $	��Top=�6^   $��15(�6v   $��Medium"�6�   �� 5   
   -   5         ��Name$ txtNumeroCaixa��5      $
��Left=�6*   $��181,134,0,0q�6E    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $	��375��6�   $��0��6�    �� 	MaxLength$ 9��6�   $��24��6�   $��15(�6�   $��Medium"�6�   �� 5   
   -   5        $ txtCustodia��5      $
��Left=�6'   $��181,171,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��375��6�   $��1��6�   $ 3��6�   $��24��6�   $��15(�6�   $��Medium"�6�   
�������6�   �� 5   
   $��(9 dígitos)��6   $
��Left=�6&   $��566,130,0,0q�6A   $	��Top=�6V   $��28��6n   $��66��6z   �� 5   
   -   5         ��Name$ btnCadastrarCaixa��5      $��	Cadastrar��6,   $
��Left=�6@   $��292,250,0,0q�6[   $	��Top=�6p   $��45��6�   $	��137��6�   $��2��6�   ���	#FFE6E6E6$��14(�6�   5      5      