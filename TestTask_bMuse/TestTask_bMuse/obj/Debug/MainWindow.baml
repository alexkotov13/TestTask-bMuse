   M S B A M L   `   `   `  ����I  ETestTask_bMuse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TestTask_bMuseTestTask_bMuse  5   	       TestTask_bMuse.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TestTask_bMuse     5   	     � Title$
  Test��5   	   $	��500��6   $	��450��6#   .��5	      � .+�5
   
   o� $��5q�6   $��20��6   $
��Left=�6&   $	��Top=�6A   
�������.@�5      m� -   5        $
��Help��5      6=   m� 5      -   5        $
��Exit��5      6=   5      �� 5   
   -   5         ��Name$ GetInfo��5      $	��350��6"   $��30��6.   
�������$
��Left=�6Q   $	��Top=�6l   $��	30,50,0,0q�6�   $��Get info��6�   $��20(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridWeather��5         AutoGenerateColumns . $
��Left=�6H   $��	30,80,0,0q�6c   $	��350��6v   $	��300��6�   ��6�   �� *controlPointsCollection+   	CellStyle 5      �� 5       �� Triggers 5      P� 5      *  $System.Windows.Controls.DataGridCell P� Property �@ 
IsSelected P� Value . . �5      ��  �� Property � ��	 �� Value
	 ���F�6H   �� 5       � ��
	 �/���6I   5      5      ��5      �� 5      
 �� 
TargetType)  #System.Windows.Controls.DataGridRow"
  6   .�5      -   5        5      5!      5"      5$      