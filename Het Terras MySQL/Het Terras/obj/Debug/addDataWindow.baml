   M S B A M L   `   `   `  ����E  AHet Terras, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Het_Terras
Het_Terras  5   	       Het_Terras.addDataWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Het_Terras     5   	     � Title$*  $Het Terras - Rooster - Voeg Data Toe��5   	    � WindowStartupLocation$ CenterOwner=�66   $��546.154��6Z   $��750.962��6k   $
��Bold"�6{    � WindowState$ 	Maximized=�6�    � UseLayoutRounding .  ��5	      �� 5
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
���   �6�   �� 5)      -   5         ��Name$ welkomLabel��5)      $9��3Welkom gebruiker! U bent ingelogd als Administrator��6)   $
��Left=�6g   $��	19,13,0,0q�6�   $	��Top=�6�   $	��337��6�   
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
��2000��6s   57      �� 58   
   -
   5        $ 	naamLabel��58      $��Selecteer Personeel��6#   $
��Left=�6A   $��	27,34,0,0q�6\   $��1��6o   $	��Top=�6|   �� 59   
   -   5         ��Name$ comboBox��59      $
��Left=�6%   $��	26,63,0,0q�6@   $��1��6S   $	��Top=�6`   $	��121��6x   $��30��6�    �� DisplayMemberPath$ 	Firstname��6�   ��6�   �� *MyList+6�   &   System.Windows.Controls.Calendar  5:   
   -   5        $��
myCalendar��5:      $
��Left=�6%   $��
146,42,0,0q�6@   $��1��6T   $	��Top=�6a   $	��214��6y   $	��180��6�      DisplayDate$ 
2016-01-13��6�      FirstDayOfWeek$ Monday=�6�      SelectionMode$ SingleRange=�6�   �� 5;   
   -   5        $ beginUurCombo��5;      $
��Left=�6,   $��
27,123,0,0q�6G   $��1��6[   $	��Top=�6h   $��50��6�    �� Text$ 08��6�   .@�5<      �� .��6   006   �� 5=      .��6   016   �� 5>      .��6   026   �� 5?      .��6   036   �� 5@      .��6   046   �� 5A      .��6   056   �� 5B      .��6   066   �� 5C      .��6   076   �� 5D      .��6   086   �� 5E      .��6   096   �� 5F      .��6   106   �� 5G      .��6   116   �� 5H      .��6   126   �� 5I      .��6   136   �� 5J      .��6   146   �� 5K      .��6   156   �� 5L      .��6   166   �� 5M      .��6   176   �� 5N      .��6   186   �� 5O      .��6   196   �� 5P      .��6   206   �� 5Q      .��6   216   �� 5R      .��6   226   �� 5S      .��6   236   5T      �� 5V   
   -   5        $ beginMinuutCombo��5V      $
��Left=�6-   $��
96,124,0,0q�6H   $��1��6\   $	��Top=�6i   $��50��6�   $ 00��6�   .@�5W      �� .��6   006   �� 5X      .��6   156   �� 5Y      .��6   306   �� 5Z      .��6   456   5[      �� 5\   
   -   5        $ label1��5\      $��Begin Tijdstip:��6    $
��Left=�6:   $��	26,96,0,0q�6U   $��1��6h   $	��Top=�6u   $	��118��6�   �� 5^   
   -   5        $ label1_Copy��5^      $��Eind Tijdstip:��6%   $
��Left=�6>   $��
26,148,0,0q�6Y   $��1��6m   $	��Top=�6z   $	��118��6�   �� 5_   
   -   5        $ eindUurCombo��5_      $
��Left=�6)   $��
28,175,0,0q�6D   $��1��6X   $	��Top=�6e   $��50��6}   $ 17��6�   .@�5`      �� .��6   006   �� 5a      .��6   016   �� 5b      .��6   026   �� 5c      .��6   036   �� 5d      .��6   046   �� 5e      .��6   056   �� 5f      .��6   066   �� 5g      .��6   076   �� 5h      .��6   086   �� 5i      .��6   096   �� 5j      .��6   106   �� 5k      .��6   116   �� 5l      .��6   126   �� 5m      .��6   136   �� 5n      .��6   146   �� 5o      .��6   156   �� 5p      .��6   166   �� 5q      .��6   176   �� 5r      .��6   186   �� 5s      .��6   196   �� 5t      .��6   206   �� 5u      .��6   216   �� 5v      .��6   226   �� 5w      .��6   236   5x      �� 5y   
   -   5        $ eindMinuutCombo��5y      $
��Left=�6-   $��
97,176,0,0q�6H   $��1��6\   $	��Top=�6i   $��50��6�   $ 00��6�   .@�5z      �� .��6   006   �� 5{      .��6   156   �� 5|      .��6   306   �� 5}      .��6   456   5~      �� 5   
   -   5        $ activiteitButton��5      $��Maak activiteit aan��6+   $
��Left=�6I   $��
28,321,0,0q�6d   $��1��6x   $	��Top=�6�   $	��119��6�   $��33��6�    �� 	IsDefault . 6�   �� 5�   
   -   5         ��Name$ omschrijvingTextBox��5�      $
��Left=�6/   $	��104��6J   $��
27,209,0,0q�6W   $��1��6k    �� TextWrapping$
 Wrap=�6x   $��Omschrijving��6�   $	��Top=�6�   $	��123��6�   5�      5�      