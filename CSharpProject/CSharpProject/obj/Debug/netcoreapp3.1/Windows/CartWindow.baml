   M S B A M L   `   `   `  ����H  DCSharpProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CSharpProject.WindowsCSharpProject.Windows  5   	   &     CSharpProject.Windows.CartWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:CSharpProject.Windows     5   	     � Title$  
CartWindow��5   	   $	��450��6   $	��800��6)    � WindowState$ 	Maximized=�65   .��5	      � $��	168,0,0,0q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgvCart��5
         CanUserAddRows$ False��6$      AutoGenerateColumns$ False��6;      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.10* 6%      Header$ Id��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+  5      $ 0.10* 6%   $
 Adı��63    6@   �� *Name+  5      $ 0.10* 6%   $ Qiyməti��63    6D   �� *Price+  5      $ 0.14* 6%   $ Müştəri Adı��63    6H   �� *Customer.Name+  5      $ 0.18* 6%   $ Götürmə Vaxtı��63    6J   �� *WithdrawalDate+  5      $ 0.18* 6%   $ Geri Qaytarma vaxtı��63    6P   �� *ExpirationDate+  5      $ 0.18* 6%   $ Gecikmə Vaxtı��63    6J   �� *	DelayTime+5      �� 5   
   -   5        	 ��Name$	 BtnDelete_Order��5      $��Kitab Qaytarıldı��6*   $
��Left=�6E   $��-136,29,0,0q�6`   $	��Top=�6u   $��35��6�   $��93��6�   6�   �� 5   
   -   5        
 ��Name$
 	TxtSearch��5      $
��Left=�6%   $��-154,85,0,0q�6@    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��120��6�   �� 5   
   -   5        $	 	BtnSearch��5      $��Search��6$   $
��Left=�65   $��-149,121,0,0q�6P   $	��Top=�6f   $��47��6~   $	��115��6�   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DtpDaleyTime��5      $
��Left=�6+   $��
-152,0,0,0q�6F   $��Center=�6Z   $��35��6u   $	��118��6�      FirstDayOfWeek$ Monday=�6�   �� 5   
   -   5        $	 BtnDelayTime��5      $��
Delay Time��6'   $
��Left=�6<   $��-147,253,0,0q�6W   $	��Top=�6m   $��45��6�   $	��106��6�   6�   5      5      