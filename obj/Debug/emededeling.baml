   M S B A M L   `   `   `  ����E  AHet Terras, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Het_Terras
Het_Terras  5   	       Het_Terras.emededeling   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Het_Terras     5   	     � Title$$  Het Terras - Beheer Mededeling��5       � WindowStartupLocation$ CenterOwner=�6.   $��546.154��6R   $��750.962��6c   $
��Bold"�6s    � WindowState$ 	Maximized=�6�    � UseLayoutRounding .  ��5	      �� 5
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
���   �6�   �� 5(      -   5         ��Name$ welkomLabel��5(      $9��3Welkom gebruiker! U bent ingelogd als Administrator��6)   $
��Left=�6g   $��	19,13,0,0q�6�   $	��Top=�6�   $	��337��6�   
���   �6�   5)      � 5*   
   -   5        $	 
footerGrid��5*      $��53��6#   $��	0,361,0,0q�6/   $��1��6B   $��Bottom=�6O   $��2��6j   ��5,      �� 5-      # � ��6"   
 5/      �� 50      $
��251* �6#   .+�53      �� -	   5        $ label��53      $��Het Terras - 2015��6#   $��Center=�6@   $��Center=�6d   $��Center=�6�   $��26��6�   $��270,14,231,13q�6�   $	��242��6�   �� 54      $
��Left=�6   $	��Top=�60   
���   �$��1q�6\   $
��2000��6p   �� 55      $
��Left=�6   $��Bottom=�60   
���   �$��1q�6_   $
��2000��6s   56      �� 57   
   -
   5        $ selectLabel��57      $��Selecteer Titel:��6%   $
��Left=�6@   $��4,26,0,0q�6[   $��1��6m   $	��Top=�6z   �� 58   
   -   5         ��Name$ dataComboBox��58      $
��Left=�6)   $��5,50,0,0q�6D   $��1��6V   $	��Top=�6c   $	��129��6{    �� DisplayMemberPath$ title��6�   ��6�   �� *
NewCombo+5:      &   System.Windows.Controls.DataGrid  5;   
   -   5          Name$ dataGrid��5;         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6H      AutoGenerateColumns . $��0,84,0,0q�6s   $��1��6�   $	��Top=�6�   $	��248��6�      CanUserResizeRows .     CanUserAddRows .  ��6%   �� *
LoadList+6   �� 5<   
   
���   �$��1q�6%   $
��Left=�69   $	��100��6T   $��-262,94,0,0q�6a   $��1��6v   $	��Top=�6�   $	��100��6�   �� 5=   
   -   5        $ label1��5=      $��1��6    $
��Left=�60   $��
188,31,0,0q�6K   $��1��6_   $	��Top=�6l   �� 5>   
   -   5        $ 
saveButton��5>      $#��Save changes                 ��6%   $
��Left=�5?      $��
141,49,0,0q�6.   $��1��6B   $	��Top=�6O   $��87��6g   $��24��6r   6~   �� 5@   
   -   5        $ testingLabel��5@      $��Label��6&   $
��Left=�66   $��
318,20,0,0q�6Q   $��1��6e   $	��Top=�6r   5C      5D      