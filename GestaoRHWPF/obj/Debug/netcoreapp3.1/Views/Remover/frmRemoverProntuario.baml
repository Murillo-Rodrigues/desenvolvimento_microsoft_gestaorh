   M S B A M L   `   `   `  ����F  BGestaoRHWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:GestaoRHWPF.Views.RemoverGestaoRHWPF.Views.Remover  5   	   4    .GestaoRHWPF.Views.Remover.frmRemoverProntuario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:GestaoRHWPF.Views.Remover     5   	     � Title$  Remoção de Prontuários��5   	   $	��501��6(   $	��643��65    � WindowStartupLocation$ CenterScreen=�6A   .��5	      � ��5
   
   �� 5       �� ImageSource$$ /Images/RemoverProntuario.jpeg��6    j� Stretch$ UniformToFill=�6F   .+�5   
   �� $��Remoção de Prontuário:��6   $��Center=�61   $��0,32,0,0q�6N   $	��Top=�6`   $��22(�6x   $��Medium&�6�   $
��Bold"�6�   �� 5   
   $C��=Insira a matrícula do funcionário para realizar a remoção��6   $��Center=�6T   $��0,76,0,0q�6q   $	��Top=�6�   $��Arial)�6�   $��14(�6�   $��Normal&�6�   $��Normal$�6�   $
��Bold"�6�   �� 5   
   $	��Id:��6   $
��Left=�6   $��
20,118,0,0q�69   $	��Top=�6M   $��16(�6e   $��Medium"�6s   �� 5   
   $!��Matrícula do funcionário:��6   $
��Left=�64   $��
19,157,0,0q�6O   $	��Top=�6c   $��16(�6{   $��Medium"�6�   �� 5   
   $��Nome do funcionário:��6   $
��Left=�6/   $��
20,193,0,0q�6J   $	��Top=�6^   $��16(�6v   $��Medium"�6�   �� 5   
   $��Número da Caixa:��6   $
��Left=�6+   $��
19,229,0,0q�6F   $	��Top=�6Z   $��16(�6r   $��Medium"�6�   �� 5   
   $��
Custódia:��6   $
��Left=�6$   $��
20,264,0,0q�6?   $	��Top=�6S   $��16(�6k   $��Medium"�6y   �� 5   
   $��
Criado em:��6   $
��Left=�6%   $��
19,301,0,0q�6@   $	��Top=�6T   $��16(�6l   $��Medium"�6z   �� 5   
   -   5         ��Name$ txtId��5      $
��Left=�6!   $��227,122,0,0q�6<    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��359��6}   $��24��6�   ${�False��6�   $��14(�6�   $��Medium"�6�   �� 5   
   -   5        $ txtMatricula��5      $
��Left=�6(   $��227,161,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��359��6�   $��24��6�   $��0��6�   $��14(�6�   $��Medium"�6�    �� 	MaxLength$ 5��6�   �� 5   
   -   5        $ txtNomeFuncionario��5      $
��Left=�6.   $��227,197,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��359��6�   $��24��6�   ${�False��6�   $��14(�6�   $��Medium"�6�   �� 5   
   -   5        $ txtNumeroCaixa��5      $
��Left=�6*   $��227,232,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��359��6�   $��24��6�   ${�False��6�   $��14(�6�   $��Medium"�6�   �� 5   
   -   5        $ txtCustodia��5      $
��Left=�6'   $��227,268,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��359��6�   $��24��6�   ${�False��6�   $��14(�6�   $��Medium"�6�   �� 5   
   -   5        $ txtCriadoEm��5      $
��Left=�6'   $��227,305,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��359��6�   $��24��6�   ${�False��6�   $��14(�6�   $��Medium"�6�   �� 5   
   -   5         ��Name$ 	btnBuscar��5      $��Buscar��6$   $
��Left=�65   $��167,380,0,0q�6P   $	��Top=�6e   $��52��6}   $	��153��6�   $��1��6�   $��15(�6�   �� 5   
   -   5        $ 
btnRemover��5      $��Remover��6%   $
��Left=�67   $��342,380,0,0q�6R   $	��Top=�6g   $��52��6   $	��152��6�   $��2��6�   ${�False��6�   $��15(�6�   5       5!      