   M S B A M L   `   `   `  ����H  DCSharpProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CSharpProject.WindowsCSharpProject.Windows  5   	   (    "CSharpProject.Windows.RaportWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:CSharpProject.Windows     5   	     � Title$  RaportWindow��5   	   $	��450��6   $	��800��6+    � WindowState$ 	Maximized=�67   .��5	      � .+�5
   
   � $��	136,0,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	DgvRaport��5         CanUserAddRows$ False��6*      AutoGenerateColumns$ False��6A   $��20,0,0,0q�6]      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.10* 6)      Header$ Id��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $ 0.10* 6)   $
 Adı��67    6D   �� *Name+  5      $ 0.10* 6)   $ Qiyməti��67    6H   �� *Price+  5      $ 0.14* 6)   $ Müştəri Adı��67    6L   �� *Customer.Name+  5      $ 0.18* 6)   $ Götürmə Vaxtı��67    6N   �� *WithdrawalDate+  5      $ 0.18* 6)   $ Geri Qaytarma vaxtı��67    6T   �� *ExpirationDate+  5      $ 0.18* 6)   $ Gecikmə Vaxtı��67    6N   �� *	DelayTime+5      5      (  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 DtpStartTime��5      $
��Left=�6+   $��	17,43,0,0q�6F   $	��Top=�6Y   
   FirstDayOfWeek$
 Monday=�6q   �� 5   
   -   5         ��Name$ LblStartTime��5      $��	StartTime��6&   $
��Left=�6:   $��	44,15,0,0q�6U   $	��Top=�6h     5   
   -   5        $	 
DtpEndTime��5      $
��Left=�6)   $��
13,100,0,0q�6D   $	��Top=�6X   $
 Monday=�6p   �� 5   
   -   5        $ 
LblEndTime��5      $��EndTime��6$   $
��Left=�66   $��	40,72,0,0q�6Q   $	��Top=�6d   �� 5   
   -   5         ��Name$ BtnSerachInterval��5      $��Search Interval��6,   $
��Left=�6F   $��	4,142,0,0q�6a   $	��Top=�6t   $��40��6�   $	��128��6�   6�   �� 5   
   -   5        $ 
BtnAllData��5      $��Show All Data��6%   $
��Left=�6=   $��	8,196,0,0q�6X   $	��Top=�6k   $��40��6�   $	��122��6�   6�   �� 5   
   -   5        $ 	BtnExport��5      $��Export��6$   $
��Left=�65   $��	9,257,0,0q�6P   $	��Top=�6c   $��39��6{   $	��102��6�   6�   5      5       