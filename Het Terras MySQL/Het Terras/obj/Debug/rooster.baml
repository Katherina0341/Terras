   M S B A M L   `   `   `  ����E  AHet Terras, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Het_Terras
Het_Terras  5   	       Het_Terras.rooster   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Het_Terras     5   	     � Title$  Het Terras - Rooster��5   
    � WindowStartupLocation$ CenterOwner=�6'   $��546.154��6K   $��750.962��6\   $
��Bold"�6l    � WindowState$ 	Maximized=�6~    � UseLayoutRounding .  ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/    �� 
StartPoint$ 0.5,0&�6S   .��5      �  � Color$ 	#FF707070��6    � Offset$ 1Q�6-   � 5      $ White��6   $ 0.083Q�6)   5      .��5      � -   5        	 �Name$	 contentGrid��5      $��0,88,0,0q�6    
 � ColumnDefinitions
 5   
   �� 5      ��5   
   
� 5      .��5      � $ 	#FFDAD8D8��6   $ 1Q�61   � 5      $ White��6   $ 0.462Q�6-   5       � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $
��263* �6   .+�5   
   � -   5        $	 navGrid��5      $��90��6    $��	0,-89,0,0q�6,   $	��Top=�6?   ��5      �� 5       �� Color# � ��6"   .+�5$      �� -   5         ��Name$ dashboardButton��5$      $��	Dashboard��6.   $
��Left=�6B   $��	19,49,0,0q�6]   $	��Top=�6p   $��75��6�   $��33��6�   
���   �6�   �� 5%      -   5        $ roosterButton��5%      $��Roosters��6,   $
��Left=�6?   $��
108,49,0,0q�6Z   $	��Top=�6n   $��75��6�   $��33��6�   
���   �6�   �� 5&      -   5        $ personeelButton��5&      $��	Personeel��6.   $
��Left=�6B   $��
197,49,0,0q�6]   $	��Top=�6q   $��75��6�   $��33��6�   
���   �6�   �� 5'      -   5        $ 
quitButton��5'      $
��Quit��6)   $
��Left=�68   $��
285,49,0,0q�6S   $	��Top=�6g   $��75��6   $��33��6�   
���   �6�   �� 5)      -   5         ��Name$ welkomLabel��5)      $�� ��6)   $
��Left=�64   $��	19,13,0,0q�6O   $	��Top=�6b   $	��337��6z   
���   �6�   5*      � 5+   
   -   5        $	 
footerGrid��5+      $��53��6#   $��	0,361,0,0q�6/   $��1��6B   $��Bottom=�6O   }�. ��5-      �� 5.      # � ��6"   
 50      �� 51      $
��251* �6#   .+�54      �� -	   5        $ label��54      $��Het Terras - 2015��6#   $��Center=�6@   $��Center=�6d   $��Center=�6�   $��26��6�   $��270,14,231,13q�6�   $	��242��6�   �� 55      $
��Left=�6   $	��Top=�60   
���   �$��1q�6\   $
��2000��6p   �� 56      $
��Left=�6   $��Bottom=�60   
���   �$��1q�6_   $
��2000��6s   57      �� 5D   
   -
   5        $ addDataButton��5D      $��Voeg data toe��6(   $
��Left=�6@   $��
211,14,0,0q�6[   $��1��6o   $	��Top=�6|   $��92��6�   $��27��6�   6�   �� 5E   
   -   5        $ editDataButton��5E      $��Beheer data��6)   $
��Left=�6?   $��
308,14,0,0q�6Z   $��1��6n   $	��Top=�6{   $��92��6�   $��27��6�   6�   �� 5F   
   -   5        $ 
klokButton��5F      $��	Inklokken��6%   $
��Left=�69   $��	14,14,0,0q�6T   $��1��6g   $��92��6t   $��27��6�   $	��Top=�6�   �� 5G   
   -   5        $ uitklokButton��5G      $��
Uitklokken��6(   $
��Left=�6=   $��
113,14,0,0q�6X   $��1��6l   $��92��6y   $��27��6�   $	��Top=�6�   �� 5H   
   -   5        $ excelButton��5H      $��Excel��6&   $
��Left=�66   $��
407,14,0,0q�6Q   $��1��6e   $	��Top=�6r   $��92��6�   $��27��6�   6�   &   System.Windows.Controls.DataGrid  5J   
   -   5          Name$ dataGrid��5J      $��	0,91,0,61q�6&   $��1��69      AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      	RowHeight$ 30Q�6�   ��6F   ��    Columns 5L      0  *System.Windows.Controls.DataGridTextColumn  5M      ,  &System.Windows.Controls.DataGridColumn   Header$ X��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 60   �� *User+  5N      $ Monday��6%    65   �� *MondayActivity+  5O      $ Tuesday ��6%    67   �� *TuesdayActivity+  5P      $ 	Wednesday��6%    68   �� *WednesdayActivity+  5Q      $ Thursday��6%    67   �� *ThursdayActivity+  5R      $ Friday��6%    66   �� *FridayActivity+  5S      $ Zaterdag��6%    67   �� *SaturdayActivity+  5T      $ Zondag��6%    65   �� *SundayActivity+  5U      $ Total hours ��6%    6;   �� *
TotalHours+  5V      $ breaks��6%    66   �� *Breaks+  5W      $ 
paid hours��6%    69   �� *	PaidHours+5Y      �� 5Z   
   -   5        $ vorigButton��5Z      $��Vorige Week��6&   $
��Left=�6<   $��	12,66,0,0q�6W   $��1��6j   $	��Top=�6w   $	��119��6�   6�   �� 5[   
   -   5        $ volgendeButton��5[      $��Volgende Week��6)   $
��Left=�6A   $��
175,65,0,0q�6\   $��1��6p   $	��Top=�6}   $	��119��6�   6�   �� 5\   
   -   5         ��Name$ weekNummerTextBox��5\      $
��Left=�6-    �� TextAlignment$ Center=�6H   $��23��6_   $��
135,64,0,0q�6k   $��1��6    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $��34��6�   {�.  6�   �� 5]   
   -   5        $ label1��5]      $��Label��6    $
��Left=�60   $��
465,50,0,0q�6K   $��1��6_   $	��Top=�6l   5b      5c      