   M S B A M L   `   `   `  ����E  AHet Terras, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Het_Terras
Het_Terras  5   	       Het_Terras.mededeling   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Het_Terras     5   	     � Title$  mededeling toevoegen��5   	   $��509.244��6&   $��374.789��67    � WindowStyle$ 
ToolWindow=�6G    � 
ResizeMode$ NoResize=�6`   .��5	      �  J� RenderTransformOrigin$ 0.5,0.5&�6    � ColumnDefinitions 5
   
   �� 5      $	��19* �6   �� 5      $
��375* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFDEDEDE��6    � Offset$ 1Q�61   � 5      $ White��6   5      z�5   
   V� 5      .~�5      �� �� 5      �� 5      	 �� Angle$
	 0.19Q�6"   T� 5      5      .+�5   
   �� -   5        
 ��Name$
 auteurLabel��5      $��Auteur:��6%   $
��Left=�67   $��	14,27,0,0q�6R   $	��Top=�6e   $��18(�6}   $��2��6�   �� 5   
   -   5         ��Name$ auteurTextBox��5      $
��Left=�6)   $��23��6D   $��0,56,0,0q�6P    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   $��1��6�   �� 5   
   -   5        $
 
titelLabel��5      $��Titel:��6$   $
��Left=�65   $��	14,87,0,0q�6P   $	��Top=�6c   $��18(�6{   $��2��6�   �� 5   
   -   5        $ titelTextBox��5      $
��Left=�6(   $��23��6C   $��	0,116,0,0q�6O   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   $��1��6�   �� 5    
   -   5        $
 mededelingLabel��5       $��Mededeling:��6)   $
��Left=�6?   $��
13,148,0,0q�6Z   $	��Top=�6n   $��18(�6�   $��2��6�   �� 5!   
   -   5        $ mededelingTextBox��5!      $��1��6-   $
��Left=�6=   $	��143��6X   $��	0,178,0,0q�6e   $
 Wrap=�6x   $�� ��6�    �� AcceptsReturn . $	��Top=�6�   $	��336��6�   �� 5"   
   -   5         ��Name$ 
saveButton��5"      $��Opslaan��6%   $
��Left=�67   $��	0,407,0,0q�6R   $	��Top=�6e   $��75��6}   $��1q�6�   
���   �$��1��6�   6�   �� 5#   
   -   5        $ 
exitButton��5#      $��	Afsluiten��6%   $
��Left=�69   $��
83,407,0,0q�6T   $	��Top=�6h   $��75��6�   $��1q�6�   
���   �$��1��6�   �� 5$   
   -	   5        $
 confirmLabel��5$      $�� ��6&   $
��Left=�61   $��
13,434,0,0q�6L   $	��Top=�6`   $��2��6x   5'      5(      