   M S B A M L   `   `   `  ����H  DCSharpProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CSharpProject.WindowsCSharpProject.Windows  5   	   +    %CSharpProject.Windows.DashboardWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:CSharpProject.Windows     5   	     � Title$  DashboardWindow��5   	   $	��450��6!   $	��800��6.    � WindowState$ 	Maximized=�6:   .��5	      � .+�5
   
   � $��	180,0,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DgvBook��5         CanUserAddRows$ False��6(      AutoGenerateColumns$ False��6?   $��
0,-2,0,272q�6[      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.15* 6)      Header$ Id��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $ 0.35* 6)   $
 Adı��67    6D   �� *Name+  5      $ 0.25* 6)   $ Qiyməti��67    6H   �� *Price+  5      $ 0.25* 6)   $ Sayı��67    6E   �� *
Quantity+5      � 5      $��	0,280,0,0q�6   .+�5      �� -   5        	 ��Name$	 products��5      $��
0,-110,0,0q�6/   .@�5      �� -   5        
 ��Name$
 smartphonesTab��5      ��5      �� 5       �� Orientation$ 
Horizontal=�6)   .+�5   "   A� $��10��6*   $��10��66   
���   �6A   �� 5   "   $��3q�6,   Bu gun qaytaranlar6K   5      ��5      �� 5      .+�5   "     -   5        $ DgvTodayReturn��5   +   $	��108��6C   $ False��6P   $ False��6g    5   &     5    *   $ 0.25* 6=   $ Id��6K    6W   �� *Id+  5!   *   $ 0.25* 6=   $
 Adı��6K    6X   �� *Name+  5"   *   $ 0.25* 6=   $ Telefon Nomresi��6K    6d   �� *Customer.Phone+  5#   *   $ 0.25* 6=   $ Ustunde nece kitab var��6K    6k   �� *Customer.Cart.Count+5%   #   5'      5)      �� 5*      -   5        $
 smartphonesTab1��5*      ��5+      �� 5,      $ 
Horizontal=�6)   .+�5-   "   A� $��10��6*   $��10��66   
���   �6A   �� 5.   "   $��3q�6,   Sabah Qaytaranlar6J   5/      ��51      �� 52      .+�53   "     -   5        $ DgvTommorrowReturn��53   +   $	��120��6G   55   #   56      58      �� 59      -   5        $
 
tabletsTab��59      ��5:      �� 5;      $ 
Horizontal=�6)   .+�5<   "   �� $��10��6,   $��10��68   
���   �6C   �� 5=   "   $��3q�6,   
Gecikenler6C   5>      ��5@      �� 5A      .+�5B   "     -   5        $ DgvDeleyTime��5B   +   $	��120��6A   5D   #   5E      5G      5H      5I      5L      �� 5M   
   -	   5         ��Name$ BtnAddToCart��5M      $��Add To Cart��6'   $
��Left=�6=   $��	25,83,0,0q�6X   $	��Top=�6k   $��62��6�   $	��125��6�   6�   �� 5N   
   -
   5         ��Name$ LblTime��5N      $��Bitmə Tarixi��6!   $
��Left=�68   $��	73,11,0,0q�6S   $	��Top=�6f   (  "System.Windows.Controls.DatePicker  5O   
   -   5          Name$ DtpTime��5O      $
��Left=�6&   $��	22,45,0,0q�6A   $	��Top=�6T   $	��146��6l      FirstDayOfWeek$ Monday=�6x   �� 5P   
   -   5        $ CartDashboard��5P      $��Cart Dashboard��6(   $
��Left=�6A   $��
24,157,0,0q�6\   $	��Top=�6p   $��62��6�   $	��125��6�   6�   5R      5S      