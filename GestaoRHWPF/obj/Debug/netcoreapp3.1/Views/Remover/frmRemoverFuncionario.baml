   M S B A M L   `   `   `  ����F  BGestaoRHWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:GestaoRHWPF.Views.RemoverGestaoRHWPF.Views.Remover  5   	   5    /GestaoRHWPF.Views.Remover.frmRemoverFuncionario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:GestaoRHWPF.Views.Remover     5   	     � Title$   Remoção de Funcionários��5   	   $	��541��6)   $	��653��66    � WindowStartupLocation$ CenterScreen=�6B   
�������.��5	      � $��0,2,0,-6q�6   ��5
   
   �� 5       �� ImageSource$$ /Images/RemoverFuncionario.jpg��6    j� Stretch$ UniformToFill=�6F   .+�5   
   �� $ ��Remoção de Funcionários��6   $
��Left=�62   $��
178,21,0,0q�6M   $	��Top=�6a   $��22(�6y   $��Medium&�6�   $
��Bold"�6�   $��43��6�   $	��283��6�   
���   ���6�   Z� �� 5   
   $5��/Por favor, insira a matrícula do funcionário:��6   $
��Left=�6H   $��
152,69,0,0q�6c   $	��Top=�6w   $��Arial)�6�   $��Normal&�6�   $��16(�6�   $��Normal$�6�   $
��Bold"�6�   $��29��6�   $	��339��6�   �� 5   
   $	��Id:��6   $
��Left=�6   $��
32,125,0,0q�69   $	��Top=�6M   $��16(�6e   $
��Bold"�6s   $��34��6�   $��30��6�   �� 5   
   $��Matrícula:��6   $
��Left=�6%   $��
32,164,0,0q�6@   $	��Top=�6T   $��16(�6l   $
��Bold"�6z   $��34��6�   $��88��6�   �� 5   
   $��Nome:��6   $
��Left=�6    $��
32,204,0,0q�6;   $	��Top=�6O   $��16(�6g   $
��Bold"�6u   $��34��6�   $��63��6�   �� 5   
   $
��CPF:��6   $
��Left=�6   $��
32,246,0,0q�6:   $	��Top=�6N   $��16(�6f   $
��Bold"�6t   $��34��6�   $��44��6�   �� 5   
   $��	Telefone:��6   $
��Left=�6$   $��
32,294,0,0q�6?   $	��Top=�6S   $��16(�6k   $
��Bold"�6y   $��34��6�   $��78��6�   �� 5   
   $��
Criado em:��6   $
��Left=�6%   $��
32,333,0,0q�6@   $	��Top=�6T   $��16(�6l   $
��Bold"�6z   $��34��6�   $��95��6�   �� 5   
   -   5         ��Name$ txtId��5      $
��Left=�6!   $��152,133,0,0q�6<    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��438��6}   $��26��6�   ${�False��6�   $��14(�6�   $��Medium"�6�   �� 5   
   -   5        $ txtMatricula��5      $
��Left=�6(   $��152,172,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��438��6�   $��26��6�   $��0��6�   $��14(�6�   $��Medium"�6�    �� 	MaxLength$ 5��6�   �� 5   
   -   5        $ txtNome��5      $
��Left=�6#   $��152,213,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��438��6   $��27��6�   ${�False��6�   $��1��6�   $��14(�6�   $��Medium"�6�   �� 5   
   -   5        $ txtCpf��5      $
��Left=�6"   $��152,250,0,0q�6=   $
 Wrap=�6R   $	��Top=�6f   $	��438��6~   $��27��6�   ${�False��6�   $��2��6�   $��14(�6�   $��Medium"�6�   $ 11��6�   �� 5   
   -   5        $ txtTelefone��5      $
��Left=�6'   $��152,297,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��438��6�   $��27��6�   ${�False��6�   $��3��6�   $��14(�6�   $��Medium"�6�   $ 10��6�   �� 5   
   -   5        $ txtCriadoEm��5      $
��Left=�6'   $��152,341,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��438��6�   $��26��6�   ${�False��6�   $��14(�6�   $��Medium"�6�   �� 5   
   -   5         ��Name$ 	btnBuscar��5      $��Buscar��6$   $
��Left=�65   $��
58,433,0,0q�6P   $	��Top=�6d   $��58��6|   $	��169��6�   $��4��6�   $��16(�6�   ���	#FFDDDDDD6�   �� 5   
   -   5        $ 
btnAlterar��5      $��Alterar��6%   $
��Left=�67   $��248,433,0,0q�6R   $	��Top=�6g   $��58��6   $	��170��6�   $��5��6�   ${�False��6�   $��16(�6�   ���	#FFDDDDDD6�   �� 5    
   -	   5        $ btnConcluir��5       $��Concluir��6&   $
��Left=�69   $��440,433,0,0q�6T   $	��Top=�6i   $��58��6�   $	��169��6�   $��6��6�   ${�False��6�   $y�Visible=�6�   $��16(�6�   ���	#FFDDDDDD6�   �� 5!   
   -
   5        $ 
btnRemover��5!      $��Remover��6%   $
��Left=�67   $��440,433,0,0q�6R   $	��Top=�6g   $��58��6   $	��169��6�   $��6��6�   ${�False��6�   $��16(�6�   ���	#FFDDDDDD6�   5$      5%      