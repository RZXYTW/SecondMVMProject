   M S B A M L   `   `   `  ����C  ?WpfApp38, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp38WpfApp38  5   	       WpfApp38.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp38     5   	     � Title$  SearchContactInformation��5   	   $	��450��6*   $	��800��67   .��5	      � ���	#FFECE9D8 � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Contact��6   $��10,10,10,10q�6$   
���   �.��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Name:��6   $��20(�6(   �� 5      $	��100��6I   $��20(�6U   $��10q�6c   ��6   ��  �� Path$
 Name� �� Mode$ OneWayToSource=�6c   �� 5      $��Email:��6   $��20(�6)   �� 5      $	��100��6J   $��20(�6V   $��10q�6d   ��6   �� $ Email�$ OneWayToSource=�6d   �� 5      $��Designnation:��6   $��20(�60   �� 5      $	��100��6Q   $��20(�6]   $��10q�6k   ��6   �� $ Designnation�$ OneWayToSource=�6k   �� 5      $��Search��6   $��10q�6L   ��6*   �� *SearchCommand+6L   �� 5      $	��Add��6   $��10q�6F   ��6'   �� *
AddCommand+6F   5      5      &   System.Windows.Controls.DataGrid  5   
   $��1��6      AutoGenerateColumns .     GridLinesVisibility$
 None=�6<      CanUserDeleteRows .     CanUserAddRows .  $	��0,4q�5   *   $��16(�67   ��6E   �� *ListCITable+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Name+6M     5      $
 Email��6%   $	 250 6N    64   �� *Email+6N     5      $
 Designnation��6%   $	 150 6\    6;   �� *Designnation+6\   4  .System.Windows.Controls.DataGridTemplateColumn  5       $
 Action��6)   $ * 69      CellTemplate 5!      �� 5"      .R�5#      �� $ 
Horizontal=�6)   .+�5$   "   �� $��Delete��6)   $��Center=�6:   $��Center=�6U   $	��100��5&   F   $��5q�6R   ��5%   )   �� $ DataContext.DeleteCommand� �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" ���5&   )   �� 6R   �� 5'   "   $
��Edit��6)   $��Center=�68   $��Center=�6S   $	��100��5)   F   $��5q�6R   ��5(   )   �� $ DataContext.EditCommand� �� $ FindAncestor=�" ���5)   )   �� 6R   5*      5+      5-      5/      50      51      