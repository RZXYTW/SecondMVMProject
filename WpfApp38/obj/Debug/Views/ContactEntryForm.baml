   M S B A M L   `   `   `  ����C  ?WpfApp38, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApp38.ViewsWpfApp38.Views  5   	   %    WpfApp38.Views.ContactEntryForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfApp38.Views     5   	   -   5          �Name$  window��5   	    � Title$ ContactEntryForm��5   	   $	��600��6"   $	��800��6/   .��5	      � ���	#FFECE9D8 � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��Contact��6   $��15(�6$   
���   �$��30,10,30,10q�6F   .��5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6   $��5q�66   .+�5      �� $��Name:��6   $��15(�6,   �� 5      $��Center=�6E   $��15(�6`   $	��200��6n   ��6   ��  �� Path$
 Name� �� Mode$ TwoWay=�6n   5      �� 5      $ 
Horizontal=�6   $��5q�66   .+�5      �� $��Email:��6   $��15(�6-   �� 5      $��Center=�6F   $��15(�6a   $	��200��6o   ��6   �� $ Email�$ TwoWay=�6o   5      �� 5      $ 
Horizontal=�6   $��5q�66   .+�5      �� $��Designnation:��6   $��15(�64   �� 5      $��Center=�6M   $��15(�6h   $	��200��6v   ��6   �� $ Designnation�$ TwoWay=�6v   5      5      5      �� 5    
   $��1��6   $��Address��6    
���   �$��15(�6E   $��30,10,30,10q�6S   .��5!      �� $ 
Horizontal=�6   $��5q�62   .+�5"      �� $��Address:��6   $��15(�6+   �� 5#      $��Center=�6D   $��15(�6_   $	��140��6m   ��6   �� $ Address�$ TwoWay=�6m   �� 5$      $��City:��6   $��15(�6(   �� 5%      $��Center=�6A   $��15(�6\   $	��140��6j   ��6   �� $
 City�$ TwoWay=�6j   �� 5&      $��Country:��6   $��15(�6+   �� 5'      $��Center=�6D   $��15(�6_   $	��140��6m   ��6   �� $ Country�$ TwoWay=�6m   �� 5(      $	��Add��6   $��5q�6F   ��6'   �� *
AddCommand+6F   �� 5)      $
��Save��6   $��5q�6H   ��6(   �� *SaveCommand+6H   5*      5+      &   System.Windows.Controls.DataGrid  5,   
   $��2��6      AutoGenerateColumns .     GridLinesVisibility$
 None=�6<      CanUserDeleteRows .  	   CanUserAddRows	 .  $��5q�5-   *   $��10(�65   ��6C   �� *ListCITable+
   Columns
 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ Address��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	Address+6R     50      $
 City��6%   $	 150 6L    63   �� *City+6L     51      $ Country��6%   $	 150 6R    66   �� *	Country+6R   4  .System.Windows.Controls.DataGridTemplateColumn  52      $ Action��6)   $ * 69      CellTemplate 53      �� 54      .R�55      �� $ 
Horizontal=�6)   .+�56   "   �� $��Delete��6)   $	��100��6:   $��10q�6F   ��6R   �� $ DataContext.DeleteCommand� �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" ���6�   �� �� 57   "   $
��Edit��6)   $	��100��68   $��10q�6D   ��6P   �� $ DataContext.EditCommand� �� $ FindAncestor=�" ���6�   �� 58      59      5;      5=      �� 5>   
   $��3��6   $��Cancel��6   $��20(�6/   $��Right=�5?   A   $��10,10,30,30q�6]   ��5>   =   �� *CancelCommand+��5?      ��  �� ElementName$ window��6]   5@      5A      