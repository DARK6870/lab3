   M S B A M L   `   `   `  ����@  <Ghost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GhostGhost  5   	       Ghost.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Ghost     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � Title$ Login into account��5   	   $	��550��6$   $	��450��64   $	��550��6C   $	��450��6P   $	��700��6\    � Icon$ /ghost-solid.png��6l   $	��620��6�   .��5      � .+�5   
   �� $��80��6   $��Center=�6   $	��100��68   $
��Fill=�6E   $��0,20,0,0q�6T   $	��Top=�6f   $��/ghost-solid.png��6~    �� BitmapScalingMode$ HighQuality=�6�   �� 5   
   -   5         ��Name$ username_tb��5   \   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��6   $��	10,10,5,5q�6H   $	��300��6q   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter username��6}   $��15(�6�    ! MaterialDesignOutlinedTextBox#��[ 6�   $��2q�6�   $	��Top=�6  $��Center=�6  $��	0,220,0,0q�6;  $��45��6N  $��Regular"�5      $��Center=�6"   ���	#FF006FDD �� SelectionBrush �	#FF006FDD	 �� 
CaretBrush	 �	#FF0055A4
 �� SelectionOpacity$	
 0.3Q�6�   $��Cascadia Code)�6�   G� 5   
   -   5         G�Name$ password_tb��5   *   $��	10,10,5,5q�6   $	��300��6?   $ Enter password��6K   $��15(�6{   $
 True��6�    + 'MaterialDesignOutlinedRevealPasswordBox#��[ 5      $��2q�6B   $	��Top=�6V   $��Center=�6n   $��45��6�   $��Regular"�5      $��Center=�6"   ���	#FF006FDD G� SelectionBrush �	#FF006FDD G� 
CaretBrush �	#FF0055A4 G� SelectionOpacity$	 0.3Q�6�   $��Cascadia Code)�6�   $��	0,280,0,0q�6�   �� 5   
   $��Welcome back!��6   $��Center=�6(   $��	0,120,0,0q�6E   $	��Top=�6X   ���	#FF3E3E3E$��25(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ Submit��5      $��40��66   $��Login into account��6B   $
��Left=�6_   $��	70,0,0,90q�6z   $��Bottom=�6�   �� 5   
   -   5        $ 	clear_btn��5      $��40��6<   $��Clear all data��6H   $��Right=�6a   $��	0,0,70,90q�6}   $��Bottom=�6�   ���	#FFB94343���	#FFA43E3E6�   �� 5   
   -   5        $ openRegForm��5      $"��Don't have account? Register��6@   $��20��6g   $��12(�6s   
������ 
������ 
�������$��Center=�6�   $��0,0,0,0q�6�   $��0,0,0,10q�6�   $��Bottom=�6  �� 5   
   -   5         ��Name$ message��5      $�� ��6!   $��Center=�6,   $��	0,163,0,0q�6I   $	��Top=�6\   ���	#FFEA4D4D$
��Bold"�6�   $��46��6�   $	��392��6�   $��Center=�6�   $��Center=�6�   $��Yu Gothic UI)�6�   $��14(�6  5      5      