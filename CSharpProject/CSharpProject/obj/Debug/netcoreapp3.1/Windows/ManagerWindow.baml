   M S B A M L   `   `   `  ����H  DCSharpProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CSharpProject.WindowsCSharpProject.Windows  5   	   )    #CSharpProject.Windows.ManagerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:CSharpProject.Windows     5   	     � Title$  ManagerWindow��5   	   $	��450��6   $	��800��6,    � WindowState$ 	Maximized=�68   .��5	      � $��
3,-8,585,8q�6   .+�5
   
   �� -   5         ��Name$ LblName��5
      $��Adı *��6!   $
��Left=�61   $��	101,9,0,0q�6L   $	��Top=�6_   �� 5   
   -   5         ��Name$ TxtName��5      $
��Left=�6#   $��	54,37,0,0q�6>    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   �� 5   
   -   5        $ 
LblSurname��5      $��	Soyadı *��6$   $
��Left=�67   $��	92,56,0,0q�6R   $	��Top=�6e   �� 5   
   -   5        $ 
TxtSurname��5      $
��Left=�6&   $��	54,81,0,0q�6A   $
 Wrap=�6T   $	��Top=�6h   $	��120��6�   �� 5   
   -   5        $ LblEmail��5      $��	Emailı *��6"   $
��Left=�65   $��
97,103,0,0q�6P   $	��Top=�6d   �� 5   
   -   5        $ TxtEmail��5      $
��Left=�6$   $��
54,129,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��120��6   �� 5   
   -   5         ��Name$ 	BtnCreate��5      $��Create��6$   $
��Left=�65   $��
37,180,0,0q�6P   $	��Top=�6d   $	��148��6|   $��52��6�   � 5   
   $��237,0,-587,0q�6    J� RenderTransformOrigin$ 0.5,0.5&�6%   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
DgvManager��5      $��-6,0,0,0q�6+      CanUserAddRows$ False��6=   	   AutoGenerateColumns$	 False��6T   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.15* 6)      Header$ Id��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $ 0.25* 6)   $
 Adı��67    6D   �� *Name+  5      $ 0.25* 6)   $ Soyadı��67    6G   �� *	Surname+  5      $ 0.35* 6)   $ Emailı��67    6G   �� *Email+5      5      �� 5   
   -	   5        $ 	BtnUpdate��5      $��Update��6$   $
��Left=�65   $��
40,264,0,0q�6P   $	��Top=�6d   $	��142��6|   $��58��6�   $y�Hidden=�6�   �� 5   
   -
   5        $ 	BtnDelete��5      $��Delete��6$   $
��Left=�65   $��
45,349,0,0q�6P   $	��Top=�6d   $	��136��6|   $��58��6�   $y�Hidden=�6�   5      5!      