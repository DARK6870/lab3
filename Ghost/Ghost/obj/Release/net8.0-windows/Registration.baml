   M S B A M L   `   `   `  ���� @  <Ghost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GhostGhost      Ghost.Registration   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Ghost     _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���   � Title$ Create a new account��$	��750��$	��850��$	��750��$	��850�� � Icon$ ghost-solid.png��$	��800��$	��850��.��� .+��� $��80��$��Center=�$	��100��$
��Fill=�$��0,20,0,0q�$	��Top=�$��/ghost-solid.png�� �� BitmapScalingMode$ HighQuality=��� -    ��Name$ username_tb��.  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��$��	10,10,5,5q�$	��300��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter username��$��15(� ! MaterialDesignOutlinedTextBox#��[ $��2q�$	��Top=�$
��Left=�$��100,290,0,0q�$��45��$��Regular"�$��Center=����	#FF006FDD �� SelectionBrush �	#FF006FDD	 �� 
CaretBrush	 �	#FF0055A4
 �� SelectionOpacity$	
 0.3Q�$��Cascadia Code)��� -   $ email_tb��$
 True��$��	10,10,5,5q�$	��300��$ Enter email��$��15(�#��[ $��2q�$	��Top=�$
��Left=�$��450,290,0,0q�$��45��$��Regular"�$��Center=����	#FF006FDD �	#FF006FDD	 �	#FF0055A4$	
 0.3Q�$��Cascadia Code)�G� -    G�Name$ password_tb��$��	10,10,5,5q�$	��300��$ Enter password��$��15(�$
 True�� + 'MaterialDesignOutlinedRevealPasswordBox#��[ $��2q�$	��Top=�$
��Left=�$��45��$��Regular"�$��Center=����	#FF006FDD G� SelectionBrush �	#FF006FDD G� 
CaretBrush �	#FF0055A4 G� SelectionOpacity$	 0.3Q�$��Cascadia Code)�$��100,350,0,0q��� -   $ fullName_tb��$
 True��$��	10,10,5,5q�$	��300��$ Enter fullname��$��15(�#��[ $��2q�$	��Top=�$
��Left=�$��450,350,0,0q�$��45��$��Regular"�$��Center=����	#FF006FDD �	#FF006FDD	 �	#FF0055A4$	
 0.3Q�$��Cascadia Code)��� $��Create a new account��$��Center=�$��	0,110,0,0q�$	��Top=����	#FF3E3E3E$��25(�$
��Bold"��� -    ��Name$ reg_btn��$��40��$��Create a new account��$
��Left=�$��	96,0,0,54q�$��Bottom=��� -   $ 	clear_btn��$��40��$��Clear all data��$
��Left=�$��
286,0,0,54q�$��Bottom=����	#FFB94343���	#FFA43E3E�� -   $ openLoginForm��$$��Already have an account? Login��$��20��$��12(�
������ 
������ 
�������$��Center=�$��0,0,0,0q�$��0,0,0,10q�$��Bottom=��� $��Gender: ��$
��Left=�$��100,419,0,0q�$	��Top=�
�������$��15(�$��Regular"�	� -    	�Name$
 male��
�������$��15(�$��Cascadia Code)�$
��Male�� d� 	IsChecked$
 TrueY�$
��Left=�$��184,418,0,0q�$	��Top=�$��30��$��86��	� -	   $ female��
�������$��15(�$��Cascadia Code)�$��Female��$
��Left=�$��264,418,0,0q�$	��Top=�$��30��$��86��(  "System.Windows.Controls.DatePicker  -
     Name$ date_bth��$	��300��/  )MaterialDesignThemes.Wpf.DatePickerAssist&   OutlinedBorderInactiveThickness$ 2q�$ Date birthday��$��Regular"����	#FF006FDD $  MaterialDesignOutlinedDatePicker#��[ $��2q�$��450,410,0,0q�
�������$��15(�$��Cascadia Code)�$	��Top=�$
��Left=�$��	10,10,5,5q�$��45���� -    ��Name$ lang_cb��$��2q�$��	10,10,5,5q�$��46��$ Native language�� " MaterialDesignOutlinedComboBox#��[ ���	#FF006FDD$	��300��$��100,470,0,0q�$	��Top=�
�������$��15(�$��Cascadia Code)�$
��Left=�{���  �� Path$ 	IsChecked� �� ElementName$% OutlinedComboBoxEnabledCheckBox��.@��� $��Russian���� $��English���� $��Romanian���� $��Polish���� $��Spanish���� $��Italian���� $��Other���� $��Other languages: ��$
��Left=�$��450,476,0,0q�$	��Top=�
�������$��15(�$��Regular"��� -    ��Name$ languageListBox��$��450,507,107,92q�.@��� $��Russian���� $��English���� $��Romanian���� $��Polish���� $��Spanish���� $��Italian���� $��Other���� -    ��Name$	 msg��$�� ��$��Center=�$��	0,153,0,0q�$	��Top=�$��Regular"����	#DDF72525$	��770��$��Center=�$	��117��