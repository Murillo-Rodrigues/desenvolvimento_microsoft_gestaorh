   M S B A M L   `   `   `  ����F  BGestaoRHWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:GestaoRHWPF.Views.RemoverGestaoRHWPF.Views.Remover  5   	   /    )GestaoRHWPF.Views.Remover.frmRemoverCaixa   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:GestaoRHWPF.Views.Remover     5   	     � Title$  Remoção de Caixas��5   	   $	��484��6#   $	��571��60    � WindowStartupLocation$ CenterScreen=�6<   .��5	      � ��5
   
   �� 5       �� ImageSource$ /Images/RemoverCaixa.jpg��6    j� Stretch$ Uniform=�6@   .+�5   
   �� $��Remoção de Caixas��6   $
��Left=�6,   $��
178,13,0,0q�6G   $	��Top=�6[   $��24(�6s   $
��Bold"�6�   �� 5   
   $9��3Insira o número da caixa para realizar a remoção��6   $
��Left=�6K   $��
115,55,0,0q�6f   $	��Top=�6z   $��16(�6�   $��Medium"�6�   $��33��6�   $	��374��6�   �� 5   
   $	��Id:��6   $
��Left=�6   $��
21,129,0,0q�69   $	��Top=�6M   $��15(�6e   $��Medium"�6s   �� 5   
   $��Número da Caixa:��6   $
��Left=�6+   $��
21,165,0,0q�6F   $	��Top=�6Z   $��15(�6r   $��Medium"�6�   �� 5   
   $��Posição da Custódia:��6   $
��Left=�6/   $��
21,199,0,0q�6J   $	��Top=�6^   $��15(�6v   $��Medium"�6�   �� 5   
   $��
Criado Em:��6   $
��Left=�6%   $��
21,235,0,0q�6@   $	��Top=�6T   $��15(�6l    J� RenderTransformOrigin$ 0.551,-0.057&�6z   $��Medium"�6�   �� 5   
   -   5         ��Name$ txtId��5      $
��Left=�6!   $��178,131,0,0q�6<    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��353��6}   ${�False��6�   $��15(�6�   $��29��6�   $��Medium"�6�   �� 5   
   -   5        $ txtNumeroCaixa��5      $
��Left=�6*   $��178,167,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��353��6�   $��29��6�   $��0��6�    �� 	MaxLength$ 9��6�   $��15(�6�   $��Medium"�6�   �� 5   
   -   5        $ txtCustodia��5      $
��Left=�6'   $��178,201,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��353��6�   $��29��6�   $ 1��6�   ${�False��6�   $��15(�6�   $��Medium"�6�   �� 5   
   -   5        $ txtCriadoEm��5      $
��Left=�6'   $��178,237,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��353��6�   $��29��6�   ${�False��6�   $��15(�6�   $��Medium"�6�   �� 5   
   -   5         ��Name$ btnBuscarCaixa��5      $��Buscar��6)   $
��Left=�6:   $��126,365,0,0q�6U   $	��Top=�6j   $��59��6�   $	��146��6�   $��1��6�   $��15(�6�   �� 5   
   -   5        $ btnRemoverCaixa��5      $��Remover��6*   $
��Left=�6<   $��318,365,0,0q�6W   $	��Top=�6l   $��59��6�   $	��147��6�   $��2��6�   ${�False��6�   $��15(�6�   5      5      