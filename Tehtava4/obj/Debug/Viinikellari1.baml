   M S B A M L   `   `   `  ����C  ?Tehtava4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Tehtava4Tehtava4  5   	       Tehtava4.Viinikellari1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Tehtava4     5   	     � Title$  Viinikellari1��5   	   $��404.734��6   $��671.893��60   .��5
      �  � 	Resources 5   
      
viinidataa � XPath��%>   &	        � 5      $ viinikellari/wine��61   5      5      .+�5   
   �� -   5         ��Name$ button��5      $��Button��6!   $
��Left=�62   $��	18,19,0,0q�6M   $	��Top=�6`   $��75��6x    J� RenderTransformOrigin$ 0.393,0.201&�6�   6�   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6&   $��
145,19,0,0q�6A   $	��Top=�6U   $	��120��6m    �� AlternationCount$ 1��6y    � DataContext# [  6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ viinit��5      # [  6$   	   AutoGenerateColumns	 .  $��18,67,-176,-333q�6�   ��6N   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Viini��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   ��  �� XPath$
 nimi��  5      $	 Maa��6%    62   �� $	 maa��  5      $ Pisteet��6%    66   �� $ arvio��5      5      5      