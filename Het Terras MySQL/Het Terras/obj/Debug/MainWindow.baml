   M S B A M L   `   `   `  ����E  AHet Terras, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Het_Terras
Het_Terras  5   	       Het_Terras.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Het_Terras     5   	     � Title$  Het Terras - Dashboard��5   	    � WindowStartupLocation$ CenterOwner=�6(   $��546.154��6L   $��750.962��6]   $
��Bold"�6m    � WindowState$ 	Maximized=�6    � UseLayoutRounding .  ��5	      �� 5
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
���   �{�.  6�   �� 5'      -   5        $ 
quitButton��5'      $
��Quit��6)   $
��Left=�68   $��
285,49,0,0q�6S   $	��Top=�6g   $��75��6   $��33��6�   
���   �6�   �� 5(      -   5         ��Name$ label1��5(      $�� ��6$   $
��Left=�6/   $��	18,12,0,0q�6J   $	��Top=�6]   5)      � 5*   
   -   5        $	 
footerGrid��5*      $��53��6#   $��	0,361,0,0q�6/   $��1��6B   $��Bottom=�6O   ��5,      �� 5-      # � ��6"   
 5/      �� 50      $
��251* �6#   .+�53      �� -	   5        $ label��53      $��Het Terras - 2015��6#   $��Center=�6@   $��Center=�6d   $��Center=�6�   $��26��6�   $��270,14,231,13q�6�   $	��242��6�   �� 54      $
��Left=�6   $	��Top=�60   
���   �$��1q�6\   $
��2000��6p   �� 55      $
��Left=�6   $��Bottom=�60   
���   �$��1q�6_   $
��2000��6s   56      �� 57   
   -
   5        $ nieuwButton��57      $��Voeg Mededeling toe��6&   $
��Left=�6D   $��	18,17,0,0q�6_   $��1��6r   $	��Top=�6   $	��146��6�   $��26��6�   6�   �� 58   
   -   5        $ 
editButton��58      $��Pas Mededeling aan��6%   $
��Left=�6B   $��
176,17,0,0q�6]   $	��Top=�6q   $	��146��6�   $��26��6�   $��1��6�   �� 59   
   -   5        $ mededelingLabel��59      $��Mededelingen:��6)   $
��Left=�6A   $��	13,51,0,0q�6\   $��1��6o   $	��Top=�6|   $��18(�6�   &   System.Windows.Controls.DataGrid  5:   
   -   5          Name$ dataGrid��5:         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6E      CanUserAddRows .     CanUserResizeColumns .     AutoGenerateColumns . $��
10,84,10,0q�6�   $��1��6�   $	��Top=�6�      
IsReadOnly . $
��auto��6�   $
��auto��6,  ��6%   �� *MyList+6,  �� 5;   
   
���   �$��1q�6%   $
��Left=�69   $	��100��6T   $��-276,100,0,0q�6a   $��1��6w   $	��Top=�6�   $	��100��6�   5>      5?      