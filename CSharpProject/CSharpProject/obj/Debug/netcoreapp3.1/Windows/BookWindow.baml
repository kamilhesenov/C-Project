   M S B A M L   `   `   `  ����H  DCSharpProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CSharpProject.WindowsCSharpProject.Windows  5   	   &     CSharpProject.Windows.BookWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:CSharpProject.Windows     5   	     � Title$  
BookWindow��5   	   $	��450��6   $	��800��6)    � WindowState$ 	Maximized=�65   .��5	      � .+�5
   
   � $��	0,0,560,0q�6   .+�5      �� -   5         ��Name$ LblName��5      $��Adı *��6%   $
��Left=�65   $��	77,56,0,0q�6P   $	��Top=�6c   �� 5      -   5         ��Name$ TxtName��5      $
��Left=�6'   $��	34,81,0,0q�6B    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��120��6�   �� 5      -   5        $ LblPrice��5      $��Qiyməti��6&   $
��Left=�68   $��
69,119,0,0q�6S   $	��Top=�6g   �� 5      -   5        $ TxtPrice��5      $
��Left=�6(   $��
35,151,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��120��6�   �� 5      -   5        $ LblQuantity��5      $��Miqdarı��6)   $
��Left=�6;   $��
74,190,0,0q�6V   $	��Top=�6j   �� 5      -   5        $ TxtQuantity��5      $
��Left=�6+   $��
34,222,0,0q�6F   $
 Wrap=�6Z   $	��Top=�6n   $	��124��6�   �� 5      -   5         ��Name$ 	BtnCreate��5      $��Create��6(   $
��Left=�69   $��
28,266,0,0q�6T   $	��Top=�6h   $	��116��6�   $��45��6�   6�   �� 5      -   5        $ 	BtnUpdate��5      $��Update��6(   $
��Left=�69   $��
25,319,0,0q�6T   $	��Top=�6h   $	��117��6�   $��45��6�   $y�Hidden=�6�   �� 5      -	   5        $ 	BtnDelete��5      $��Delete��6(   $
��Left=�69   $��
26,375,0,0q�6T   $	��Top=�6h   $	��116��6�   $��45��6�   $y�Hidden=�6�   5      � 5   
   $��	207,0,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -
   5          Name$ DgvBook��5         CanUserAddRows$ False��6(      AutoGenerateColumns$ False��6?   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.15* 6)      Header$ Id��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $
 0.35* 6)   $
 Adı��67    6D   �� *Name+  5      $
 0.25* 6)   $ Qiyməti��67    6H   �� *Price+  5      $
 0.25* 6)   $ Miqdarı��67    6H   �� *
Quantity+5      5      5!      5"      