   M S B A M L   `   `   `  ����H  DCSharpProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CSharpProject.WindowsCSharpProject.Windows  5   	   *    $CSharpProject.Windows.CustomerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:CSharpProject.Windows     5   	     � Title$  CustomerWindow��5   	   $	��450��6    $	��800��6-    � WindowState$ 	Maximized=�69   .��5	      � .+�5
   
   � $��	0,0,556,0q�6   .+�5      �� -   5         ��Name$ LblName��5      $��Adı *��6%   $
��Left=�65   $��87,5,0,0q�6P   $	��Top=�6b   �� 5      -   5         ��Name$ TxtName��5      $
��Left=�6'   $��	36,33,0,0q�6B    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��139��6�   �� 5      -   5        $ 
LblSurname��5      $��	Soyadı *��6(   $
��Left=�6;   $��	77,55,0,0q�6V   $	��Top=�6i   �� 5      -   5        $ 
TxtSurname��5      $
��Left=�6*   $��	37,85,0,0q�6E   $
 Wrap=�6X   $	��Top=�6l   $	��139��6�   �� 5      -   5        $ LblPhone��5      $��Telefon Nömrəsi *��6&   $
��Left=�6B   $��
58,107,0,0q�6]   $	��Top=�6q   �� 5      -   5        $ TxtPhone��5      $
��Left=�6(   $��
38,137,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��139��6�   �� 5      -   5        $ LblEmail��5      $��	Emailı *��6&   $
��Left=�69   $��
79,158,0,0q�6T   $	��Top=�6h   �� 5      -   5        $ TxtEmail��5      $
��Left=�6(   $��
39,188,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��139��6�   �� 5      -	   5        $ LblPassword��5      $��Şifrəsi *��6)   $
��Left=�6=   $��
86,210,0,0q�6X   $	��Top=�6l   G� 5      -
   5         G�Name$ TxtPassword��5      $
��Left=�6/   $��
36,241,0,0q�6J   $	��Top=�6^   $	��144��6v   �� 5      -   5         ��Name$ 	BtnCreate��5      $��Create��6(   $
��Left=�69   $��
16,277,0,0q�6T   $	��Top=�6h   $��41��6�   $	��164��6�   6�   �� 5      -   5        $ 	BtnUpdate��5      $��Update��6(   $
��Left=�69   $��
16,324,0,0q�6T   $	��Top=�6h   $��41��6�   $	��164��6�   $y�Hidden=�6�   �� 5      -   5        $ 	BtnDelete��5      $��Delete��6(   $
��Left=�69   $��
16,372,0,0q�6T   $	��Top=�6h   $��41��6�   $	��164��6�   $y�Hidden=�6�   5      � 5   
   $��	194,0,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DgvCustomer��5         CanUserAddRows$ False��6,   	   AutoGenerateColumns$	 False��6C   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.10* 6)      Header$ Id��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $ 0.17* 6)   $
 Adı��67    6D   �� *Name+  5      $ 0.17* 6)   $ Soyadı��67    6G   �� *	Surname+  5      $ 0.17* 6)   $ Telefon Nömrəsi��67    6P   �� *Phone+  5       $ 0.24* 6)   $ Emailı��67    6G   �� *Email+  5!      $ 0.17* 6)   $ 	Şifrəsi��67    6H   �� *
Password+5#      5$      5&      5'      